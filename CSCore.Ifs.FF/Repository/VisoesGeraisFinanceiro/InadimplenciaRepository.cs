using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.EstaticasLabel.GG.Entities;

namespace CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro
{
    public class InadimplenciaRepository(AppDbContext appDbContext) : IInadimplenciaRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        private class TituloInadimplenciaInfo
        {
            public DateTime DataEmissao { get; set; }
            public DateTime DataVencimento { get; set; }
            public decimal? ValorTitulo { get; set; }
            public decimal? TotalPagamentos { get; set; }
            public decimal VlLiqTitulo { get; set; }
            public string SituacaoLabel { get; set; } = string.Empty;
            public string? IdEstabelecimento { get; set; }
        }

        public async Task<List<DtoInadimplenciaResponse>> GetInadimplenciaAsync(DtoInadimplenciaRequest request)
        {
            var dataAtual = DateTime.Now.Date;
            var dataInicio = request.DataInicio ?? dataAtual.AddYears(-5);
            var dataFim = request.DataFim ?? dataAtual;

            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        .AsNoTracking()
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        .AsNoTracking()
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        where ff102.TenantId == request.TenantId
                              && ff102.Ff102Tiporegistro == 1 // Contas a receber
                              && ff102.Ff102DataEmissao >= dataInicio
                              && ff102.Ff102DataEmissao <= dataFim
                              && (ff102sit.Label == Csicp_ff102_Situacao.Aberto
                                  || ff102sit.Label == Csicp_ff102_Situacao.BxParcial
                                  || ff102sit.Label == Csicp_ff102_Situacao.Liquidado)

                        select new TituloInadimplenciaInfo
                        {
                            DataEmissao = ff102.Ff102DataEmissao,
                            DataVencimento = ff102.Ff102DataVencimento,
                            ValorTitulo = (ff102.Ff102ValorTitulo ?? 0) + (ff102.Ff102VlAcrescimos ?? 0) - (ff102.Ff102VlDecrescimos ?? 0),
                            TotalPagamentos = ff102.Ff102TotalPagamentos,
                            VlLiqTitulo = ff102.Ff102VlLiqTitulo,
                            SituacaoLabel = ff102sit.Label,
                            IdEstabelecimento = ff102.Ff102Filialid
                        };

            // Aplicar filtro de estabelecimentos se fornecido
            if (request.FiltroEstabelecimentos != null && request.FiltroEstabelecimentos.Any())
            {
                query = query.Where(t => t.IdEstabelecimento != null && request.FiltroEstabelecimentos.Contains(t.IdEstabelecimento));
            }

            var titulos = await query.ToListAsync();

            return ProcessarInadimplencia(titulos, dataAtual);
        }

        private List<DtoInadimplenciaResponse> ProcessarInadimplencia(List<TituloInadimplenciaInfo> titulos, DateTime dataAtual)
        {
            var resultado = new List<DtoInadimplenciaResponse>();

            // Agrupar por ano e mês da data de emissão
            var gruposPorMes = titulos
                .GroupBy(t => new { Ano = t.DataEmissao.Year, Mes = t.DataEmissao.Month })
                .OrderBy(g => g.Key.Ano)
                .ThenBy(g => g.Key.Mes);

            foreach (var grupo in gruposPorMes)
            {
                var titulosDoMes = grupo.ToList();

                // Títulos liquidados
                var titulosLiquidados = titulosDoMes
                    .Where(t => t.SituacaoLabel == Csicp_ff102_Situacao.Liquidado)
                    .ToList();

                // Títulos inadimplentes (em aberto ou baixa parcial que já venceram)
                var titulosInadimplentes = titulosDoMes
                    .Where(t => (t.SituacaoLabel == Csicp_ff102_Situacao.Aberto || t.SituacaoLabel == Csicp_ff102_Situacao.BxParcial)
                                && t.DataVencimento < dataAtual)
                    .ToList();

                // Calcular totais usando os campos específicos
                var quantidadeTotal = titulosDoMes.Count;
                var valorTotal = titulosDoMes.Sum(t => t.ValorTitulo ?? 0);
                var quantidadeLiquidados = titulosLiquidados.Count;
                var valorLiquidados = titulosLiquidados.Sum(t => t.TotalPagamentos ?? 0);
                var quantidadeInadimplentes = titulosInadimplentes.Count;
                var valorInadimplentes = titulosInadimplentes.Sum(t => t.VlLiqTitulo);

                // Calcular percentual de inadimplência
                var percentualInadimplencia = quantidadeTotal > 0
                    ? Math.Round((decimal)quantidadeInadimplentes / quantidadeTotal * 100, 2)
                    : 0;

                var anoMes = $"{grupo.Key.Ano:0000}/{grupo.Key.Mes:00}";

                resultado.Add(new DtoInadimplenciaResponse
                {
                    Ano = grupo.Key.Ano,
                    Mes = grupo.Key.Mes,
                    AnoMes = anoMes,
                    QuantidadeTitulosTotal = quantidadeTotal,
                    ValorTitulosTotal = valorTotal,
                    QuantidadeTitulosLiquidados = quantidadeLiquidados,
                    ValorTitulosLiquidados = valorLiquidados,
                    QuantidadeTitulosInadimplentes = quantidadeInadimplentes,
                    ValorTitulosInadimplentes = valorInadimplentes,
                    PercentualInadimplencia = percentualInadimplencia
                });
            }

            return resultado;
        }
    }
}

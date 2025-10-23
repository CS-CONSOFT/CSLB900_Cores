using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.EstaticasLabel.GG.Entities;

namespace CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro
{
    public class TitulosAgrupadosAnoeMesRepository(AppDbContext appDbContext) : ITitulosAgrupadosAnoeMesRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        private class TituloAgrupadoInfo
        {
            public DateTime DataVencimento { get; set; }
            public int TipoRegistro { get; set; }
            public decimal ValorLiquido { get; set; }
            public string? NomeEmpresa { get; set; }
            public int? CodigoEmpresa { get; set; }
            public string? IdEstabelecimento { get; set; }
        }

        public async Task<(List<DtoTitulosAgrupadosAnoMes>,int)> GetTitulosAgrupadosAnoMesAsync(DtoTitulosAgrupadosAnoMesRequest request)
        {
            var dataAtual = DateTime.Now.Date;
            var dataInicio = request.DataVencimentoInicio ?? dataAtual.AddYears(-2);
            var dataFim = request.DataVencimentoFim ?? dataAtual.AddYears(2);

            // Tipos de registro padrão: 1, 2 (contas a receber) e 3 (contas a pagar)
            var tiposRegistro = request.TiposRegistro ?? new List<int> { 1, 2, 3 };

            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        .AsNoTracking()
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        .AsNoTracking()
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        join bb001 in _appDbContext.E9ACSICP_BB001s
                        on ff102.Ff102Filialid equals bb001.Id into joinEmpresa
                        from bb001 in joinEmpresa.DefaultIfEmpty()

                        where ff102.TenantId == request.TenantId
                              && tiposRegistro.Contains(ff102.Ff102Tiporegistro ?? 0)
                              && ff102.Ff102DataVencimento >= dataInicio
                              && ff102.Ff102DataVencimento <= dataFim
                              && (ff102sit.Label == Csicp_ff102_Situacao.Aberto || ff102sit.Label == Csicp_ff102_Situacao.BxParcial)

                        select new TituloAgrupadoInfo
                        {
                            DataVencimento = ff102.Ff102DataVencimento,
                            TipoRegistro = ff102.Ff102Tiporegistro ?? 0,
                            ValorLiquido = ff102.Ff102VlLiqTitulo,
                            NomeEmpresa = bb001.Bb001Razaosocial,
                            CodigoEmpresa = bb001.Bb001Codigoempresa,
                            IdEstabelecimento = ff102.Ff102Filialid
                        };

            // Aplicar filtro de estabelecimentos se fornecido
            if (request.FiltroEstabelecimentos != null && request.FiltroEstabelecimentos.Count != 0)
            {
                query = query.Where(t => t.IdEstabelecimento != null && request.FiltroEstabelecimentos.Contains(t.IdEstabelecimento));
            }

            var queryCount = query;
            int totalRegistros = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(request.PageNumber, request.PageSize);

            var titulos = await query.ToListAsync();
            var lista = ProcessarAgrupamentoAnoMes(titulos);
            return (lista, totalRegistros);
        }

        private List<DtoTitulosAgrupadosAnoMes> ProcessarAgrupamentoAnoMes(List<TituloAgrupadoInfo> titulos)
        {
            var resultado = new List<DtoTitulosAgrupadosAnoMes>();

            // Agrupar por estabelecimento, ano e mês
            var grupos = titulos
                .GroupBy(t => new
                {
                    t.IdEstabelecimento,
                    t.NomeEmpresa,
                    t.CodigoEmpresa,
                    Ano = t.DataVencimento.Year,
                    Mes = t.DataVencimento.Month
                })
                .OrderBy(g => g.Key.CodigoEmpresa)
                .ThenBy(g => g.Key.Ano)
                .ThenBy(g => g.Key.Mes);

            foreach (var grupo in grupos)
            {
                var titulosDoGrupo = grupo.ToList();

                // Separar por tipo de registro
                var contasReceber = titulosDoGrupo.Where(t => t.TipoRegistro == 1 || t.TipoRegistro == 2).ToList();
                var contasPagar = titulosDoGrupo.Where(t => t.TipoRegistro == 3).ToList();

                var anoMes = $"{grupo.Key.Ano:0000}/{grupo.Key.Mes:00}";

                resultado.Add(new DtoTitulosAgrupadosAnoMes
                {
                    Ano = grupo.Key.Ano,
                    Mes = grupo.Key.Mes,
                    AnoMes = anoMes,
                    IdEstabelecimento = grupo.Key.IdEstabelecimento,
                    NomeEmpresa = grupo.Key.NomeEmpresa,
                    CodigoEmpresa = grupo.Key.CodigoEmpresa,

                    // Contas a Receber
                    QuantidadeContasReceber = contasReceber.Count,
                    ValorContasReceber = contasReceber.Sum(t => t.ValorLiquido),

                    // Contas a Pagar
                    QuantidadeContasPagar = contasPagar.Count,
                    ValorContasPagar = contasPagar.Sum(t => t.ValorLiquido),

                    // Totais
                    QuantidadeTotal = titulosDoGrupo.Count,
                    ValorTotal = titulosDoGrupo.Sum(t => t.ValorLiquido)
                });
            }

            return resultado;
        }
    }
}
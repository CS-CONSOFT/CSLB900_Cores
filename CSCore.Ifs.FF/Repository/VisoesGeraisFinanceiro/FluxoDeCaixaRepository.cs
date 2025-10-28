using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.EstaticasLabel.GG.Entities;

namespace CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro
{
    public class FluxoDeCaixaRepository(AppDbContext appDbContext) : IFluxoDeCaixaRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<List<FluxoDeCaixaDiarioDto>> GetFluxoDeCaixaDiarioAsync(
           int in_tenant,
           DateTime? in_dataVencimentoInicio = null,
           DateTime? in_dataVencimentoFim = null,
           decimal in_saldoAnterior = 0,
           List<string>? in_estabIDs = null)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        .AsNoTracking()

                        join bb012conta in _appDbContext.OsusrE9aCsicpBb012s
                        .AsNoTracking()
                        on ff102.Ff102Contaid equals bb012conta.Id into joinbb012Conta
                        from bb012conta in joinbb012Conta.DefaultIfEmpty()

                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        .AsNoTracking()
                        on ff102.Ff102Situacaoid equals ff102sit.Id
                        
                        where ff102.TenantId == in_tenant
                              && (ff102sit.Label == Csicp_ff102_Situacao.Aberto 
                              || ff102sit.Label == Csicp_ff102_Situacao.BxParcial 
                              || ff102sit.Label == Csicp_ff102_Situacao.Provisao)
                        select new
                        {
                            DataVenc = ff102.Ff102DataVencimento,
                            ValorLiq = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo * -1 : ff102.Ff102VlLiqTitulo,
                            AReceber = ff102.Ff102Tiporegistro == 1 || ff102.Ff102Tiporegistro == 2 ? ff102.Ff102VlLiqTitulo : 0,
                            APagar = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo : 0,
                            ReceitaProvisao = ff102sit.Label == Csicp_ff102_Situacao.Provisao && (ff102.Ff102Tiporegistro == 1
                                || ff102.Ff102Tiporegistro == 2) ? ff102.Ff102VlLiqTitulo : 0,
                            DespesaProvisao = ff102sit.Label == Csicp_ff102_Situacao.Provisao && ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo : 0,
                            EstabID = ff102.Ff102Filialid,
                        };

            if (in_estabIDs != null && in_estabIDs.Count != 0)
                query = query.Where(x => in_estabIDs.Contains(x.EstabID ?? string.Empty));

            if (in_dataVencimentoInicio.HasValue)
                query = query.Where(x => x.DataVenc >= in_dataVencimentoInicio.Value);

            if (in_dataVencimentoFim.HasValue)
                query = query.Where(x => x.DataVenc <= in_dataVencimentoFim.Value);

            var agrupado = query
                .GroupBy(g => new { g.DataVenc })
                .Select(g => new
                {
                    g.Key.DataVenc,
                    TotalDia = g.Sum(x => x.ValorLiq),
                    AReceber = g.Sum(x => x.AReceber),
                    APagar = g.Sum(x => x.APagar),
                    ReceitaProvisao = g.Sum(x => x.ReceitaProvisao),
                    DespesaProvisao = g.Sum(x => x.DespesaProvisao)
                })
                .OrderBy(x => x.DataVenc);

            var totais = await agrupado.ToListAsync();

            decimal saldoAcumulado = in_saldoAnterior;
            decimal saldoAnteriorLinha = in_saldoAnterior;
            var resultado = new List<FluxoDeCaixaDiarioDto>();
            foreach (var item in totais)
            {
                saldoAcumulado = saldoAnteriorLinha + item.TotalDia;
                resultado.Add(new FluxoDeCaixaDiarioDto
                {
                    DataVenc = item.DataVenc,
                    SaldoAnterior = saldoAnteriorLinha,
                    TotalDia = item.TotalDia,
                    AReceber = item.AReceber,
                    APagar = item.APagar,
                    ReceitaProvisao = item.ReceitaProvisao,
                    DespesaProvisao = item.DespesaProvisao,
                    SaldoAcumulado = saldoAcumulado,
                    EstabIDs = in_estabIDs ?? new List<string>(),
                });
                saldoAnteriorLinha = saldoAcumulado;
            }
            return resultado;
        }

        public async Task<List<FluxoDeCaixaMensalDto>> GetFluxoDeCaixaMensalAsync(
            int in_tenant,
            DateTime? in_dataVencimentoInicio = null,
            DateTime? in_dataVencimentoFim = null,
            decimal in_saldoAnterior = 0, 
            List<string>? in_estabIDs = null)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s

                        join bb012conta in _appDbContext.OsusrE9aCsicpBb012s
                        on ff102.Ff102Contaid equals bb012conta.Id into joinbb012Conta
                        from bb012conta in joinbb012Conta.DefaultIfEmpty()

                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        where ff102.TenantId == in_tenant
                            && (ff102sit.Label == Csicp_ff102_Situacao.Aberto 
                            || ff102sit.Label == Csicp_ff102_Situacao.BxParcial 
                            || ff102sit.Label == Csicp_ff102_Situacao.Provisao)
                        select new
                        {
                            Ano = ff102.Ff102DataVencimento.Year,
                            Mes = ff102.Ff102DataVencimento.Month,
                            ValorLiq = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo * -1 : ff102.Ff102VlLiqTitulo,
                            AReceber = ff102.Ff102Tiporegistro == 1 || ff102.Ff102Tiporegistro == 2 ? ff102.Ff102VlLiqTitulo : 0,
                            APagar = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo : 0,
                            ReceitaProvisao = ff102sit.Label == Csicp_ff102_Situacao.Provisao && (ff102.Ff102Tiporegistro == 1 
                                || ff102.Ff102Tiporegistro == 2) ? ff102.Ff102VlLiqTitulo : 0,
                            DespesaProvisao = ff102sit.Label == Csicp_ff102_Situacao.Provisao && ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo : 0,
                            EstabID = ff102.Ff102Filialid,
                        };

            if (in_estabIDs != null && in_estabIDs.Count != 0)
                query = query.Where(x => in_estabIDs.Contains(x.EstabID ?? string.Empty));

            if (in_dataVencimentoInicio.HasValue)
                query = query.Where(x => x.Ano > in_dataVencimentoInicio.Value.Year
                    || x.Ano == in_dataVencimentoInicio.Value.Year && x.Mes >= in_dataVencimentoInicio.Value.Month);

            if (in_dataVencimentoFim.HasValue)
                query = query.Where(x => x.Ano < in_dataVencimentoFim.Value.Year
                    || x.Ano == in_dataVencimentoFim.Value.Year && x.Mes <= in_dataVencimentoFim.Value.Month);

            var agrupado = query
                .GroupBy(x => new { x.Ano, x.Mes })
                .Select(g => new
                {
                    g.Key.Ano,
                    g.Key.Mes,
                    TotalMes = g.Sum(x => x.ValorLiq),
                    AReceber = g.Sum(x => x.AReceber),
                    APagar = g.Sum(x => x.APagar),
                    ReceitaProvisao = g.Sum(x => x.ReceitaProvisao),
                    DespesaProvisao = g.Sum(x => x.DespesaProvisao)
                })
                .OrderBy(x => x.Ano)
                .ThenBy(x => x.Mes);

            var totais = await agrupado.ToListAsync();

            decimal saldoAcumulado = in_saldoAnterior;
            decimal saldoAnteriorLinha = in_saldoAnterior;
            var resultado = new List<FluxoDeCaixaMensalDto>();
            foreach (var item in totais)
            {
                saldoAcumulado = saldoAnteriorLinha + item.TotalMes;
                resultado.Add(new FluxoDeCaixaMensalDto
                {
                    Ano = item.Ano,
                    Mes = item.Mes,
                    TotalMes = item.TotalMes,
                    SaldoAnterior = saldoAnteriorLinha,
                    SaldoAcumulado = saldoAcumulado,
                    AReceber = item.AReceber,
                    APagar = item.APagar,
                    ReceitaProvisao = item.ReceitaProvisao,
                    DespesaProvisao = item.DespesaProvisao,
                    EstabIDs = in_estabIDs ?? new List<string>(),
                });
                saldoAnteriorLinha = saldoAcumulado;
            }
            return resultado;
        }
    }
}

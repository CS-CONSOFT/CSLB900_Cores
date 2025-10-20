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
           decimal in_saldoAnterior = 0)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        .AsNoTracking()

                        join conta in _appDbContext.OsusrE9aCsicpBb012s
                        .AsNoTracking()
                        on ff102.Ff102Contaid equals conta.Id into joinConta
                        from conta in joinConta.DefaultIfEmpty()

                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        .AsNoTracking()
                        on ff102.Ff102Situacaoid equals ff102sit.Id
                        
                        where ff102.TenantId == in_tenant
                              && (ff102sit.Label == Csicp_ff102_Situacao.Aberto 
                              || ff102sit.Label == Csicp_ff102_Situacao.BxParcial 
                              || ff102sit.Label == Csicp_ff102_Situacao.Provisao)
                        select new
                        {
                            Data = ff102.Ff102DataVencimento,
                            DataEmissao = ff102.Ff102DataEmissao,
                            ValorLiq = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo * -1 : ff102.Ff102VlLiqTitulo,
                            IdentificadorTitulo = ff102.Ff102Tiporegistro == 1 
                                               || ff102.Ff102Tiporegistro == 2 ? "A receber" :
                                                  ff102.Ff102Tiporegistro == 3 ? "A pagar" : string.Empty,
                            TipoReg = ff102.Ff102Tiporegistro,
                            ff102sit.Label
                        };

            if (in_dataVencimentoInicio.HasValue)
                query = query.Where(x => x.Data >= in_dataVencimentoInicio.Value);

            if (in_dataVencimentoFim.HasValue)
                query = query.Where(x => x.Data <= in_dataVencimentoFim.Value);

            var agrupado = query
                .GroupBy(x => new
                {
                    x.Data.Date,
                    x.DataEmissao,
                    x.ValorLiq,
                    x.TipoReg,
                    x.IdentificadorTitulo,
                    x.Label
                })
                .Select(g => new
                {
                    Data = g.Key.Date,
                    g.Key.DataEmissao,
                    ValorTitulo = g.Key.ValorLiq,
                    g.Key.TipoReg,
                    g.Key.IdentificadorTitulo,
                    g.Key.Label,
                    TotalDia = g.Sum(x => x.ValorLiq)
                })
                .OrderBy(x => x.Data)
                .ThenBy(x => x.TipoReg);

            var totais = await agrupado.ToListAsync();

            decimal saldoAcumulado = in_saldoAnterior;
            decimal saldoAnteriorLinha = in_saldoAnterior;
            var resultado = new List<FluxoDeCaixaDiarioDto>();
            foreach (var item in totais)
            {
                saldoAcumulado = saldoAnteriorLinha + item.TotalDia;
                resultado.Add(new FluxoDeCaixaDiarioDto
                {
                    Data = item.Data,
                    DataEmissao = item.DataEmissao,
                    IdentificadorTitulo = item.IdentificadorTitulo,
                    Label = item.Label,
                    ValorTitulo = item.ValorTitulo,
                    TotalDia = item.TotalDia,
                    SaldoAnterior = saldoAnteriorLinha,
                    SaldoAcumulado = saldoAcumulado
                });
                saldoAnteriorLinha = saldoAcumulado;
            }
            return resultado;
        }

        public async Task<List<FluxoDeCaixaMensalDto>> GetFluxoDeCaixaMensalAsync(
            int in_tenant,
            DateTime? in_dataVencimentoInicio = null,
            DateTime? in_dataVencimentoFim = null,
            decimal in_saldoAnterior = 0)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        
                        join conta in _appDbContext.OsusrE9aCsicpBb012s
                        on ff102.Ff102Contaid equals conta.Id into joinConta
                        from conta in joinConta.DefaultIfEmpty()
                        
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
                            ProvisaoAPagar = ff102sit.Label == Csicp_ff102_Situacao.Provisao && ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo : 0
                        };

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
                    ProvisaoAPagar = g.Sum(x => x.ProvisaoAPagar)
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
                    ProvisaoAPagar = item.ProvisaoAPagar
                });
                saldoAnteriorLinha = saldoAcumulado;
            }
            return resultado;
        }
    }
}

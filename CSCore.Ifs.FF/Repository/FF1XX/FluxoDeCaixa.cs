using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FluxoDeCaixa(AppDbContext appDbContext)
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public class FluxoDeCaixaDiarioDto
        {
            public DateTime Data { get; set; }
            public DateTime DataEmissao { get; set; }
            public string? Prefixo { get; set; }
            public decimal? Titulo { get; set; }
            public string? Sufixo { get; set; }
            public string? NomeConta { get; set; }
            public decimal ValorTitulo { get; set; }
            public decimal TotalDia { get; set; }
            public decimal SaldoAnterior { get; set; }
            public decimal SaldoAcumulado { get; set; }
            public string IdentificadorTitulo { get; set; } = string.Empty;
            public string Label { get; set; } = string.Empty;
        }

        public async Task<List<FluxoDeCaixaDiarioDto>> GetFluxoDeCaixaDiarioAsync(
           int tenant,
           DateTime? dataVencimentoInicio = null,
           DateTime? dataVencimentoFim = null,
           decimal saldoAnterior = 0)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        join conta in _appDbContext.OsusrE9aCsicpBb012s
                            on ff102.Ff102Contaid equals conta.Id into joinConta
                        from conta in joinConta.DefaultIfEmpty()
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                            on ff102.Ff102Situacaoid equals ff102sit.Id
                        where ff102.TenantId == tenant
                              && (ff102sit.Label == "Aberto" || ff102sit.Label == "Baixa Parcial" || ff102sit.Label == "Provisão")
                        select new
                        {
                            Data = ff102.Ff102DataVencimento,
                            DataEmissao = ff102.Ff102DataEmissao,
                            Prefixo = ff102.Ff102Pfx,
                            Titulo = ff102.Ff102NoTitulo,
                            Sufixo = ff102.Ff102Sfx,
                            NomeConta = conta.Bb012NomeCliente,
                            ValorLiq = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo * -1 : ff102.Ff102VlLiqTitulo,
                            IdentificadorTitulo = (ff102.Ff102Tiporegistro == 1 || ff102.Ff102Tiporegistro == 2) ? "A receber" :
                                                 (ff102.Ff102Tiporegistro == 3 ? "A pagar" : string.Empty),
                            TipoReg = ff102.Ff102Tiporegistro,
                            Label = ff102sit.Label
                        };

            if (dataVencimentoInicio.HasValue)
                query = query.Where(x => x.Data >= dataVencimentoInicio.Value);

            if (dataVencimentoFim.HasValue)
                query = query.Where(x => x.Data <= dataVencimentoFim.Value);

            var agrupado = query
                .GroupBy(x => new
                {
                    x.Data.Date,
                    x.DataEmissao,
                    x.Prefixo,
                    x.Titulo,
                    x.Sufixo,
                    x.NomeConta,
                    x.ValorLiq,
                    x.TipoReg,
                    x.IdentificadorTitulo,
                    x.Label
                })
                .Select(g => new
                {
                    Data = g.Key.Date,
                    DataEmissao = g.Key.DataEmissao,
                    Prefixo = g.Key.Prefixo,
                    Titulo = g.Key.Titulo,
                    Sufixo = g.Key.Sufixo,
                    NomeConta = g.Key.NomeConta,
                    ValorTitulo = g.Key.ValorLiq,
                    TipoReg = g.Key.TipoReg,
                    IdentificadorTitulo = g.Key.IdentificadorTitulo,
                    Label = g.Key.Label,
                    TotalDia = g.Sum(x => x.ValorLiq)
                })
                .OrderBy(x => x.Data)
                .ThenBy(x => x.TipoReg);

            var totais = await agrupado.ToListAsync();

            decimal saldoAcumulado = saldoAnterior;
            decimal saldoAnteriorLinha = saldoAnterior;
            var resultado = new List<FluxoDeCaixaDiarioDto>();
            foreach (var item in totais)
            {
                saldoAcumulado = saldoAnteriorLinha + item.TotalDia;
                resultado.Add(new FluxoDeCaixaDiarioDto
                {
                    Data = item.Data,
                    DataEmissao = item.DataEmissao,
                    Prefixo = item.Prefixo,
                    Titulo = item.Titulo,
                    Sufixo = item.Sufixo,
                    NomeConta = item.NomeConta,
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

        public class FluxoDeCaixaMensalDto
        {
            public int Ano { get; set; }
            public int Mes { get; set; }
            public decimal TotalMes { get; set; }
            public decimal SaldoAnterior { get; set; }
            public decimal SaldoAcumulado { get; set; }
            public decimal AReceber { get; set; }
            public decimal APagar { get; set; }
            public decimal ReceitaProvisao { get; set; }
            public decimal ProvisaoAPagar { get; set; }
        }

        public async Task<List<FluxoDeCaixaMensalDto>> GetFluxoDeCaixaMensalAsync(
            int tenant,
            DateTime? dataVencimentoInicio = null,
            DateTime? dataVencimentoFim = null,
            decimal saldoAnterior = 0)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        join conta in _appDbContext.OsusrE9aCsicpBb012s
                            on ff102.Ff102Contaid equals conta.Id into joinConta
                        from conta in joinConta.DefaultIfEmpty()
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                            on ff102.Ff102Situacaoid equals ff102sit.Id
                        where ff102.TenantId == tenant
                              && (ff102sit.Label == "Aberto" || ff102sit.Label == "Baixa Parcial" || ff102sit.Label == "Provisão")
                        select new
                        {
                            Ano = ff102.Ff102DataVencimento.Year,
                            Mes = ff102.Ff102DataVencimento.Month,
                            ValorLiq = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo * -1 : ff102.Ff102VlLiqTitulo,
                            AReceber = (ff102.Ff102Tiporegistro == 1 || ff102.Ff102Tiporegistro == 2) ? ff102.Ff102VlLiqTitulo : 0,
                            APagar = ff102.Ff102Tiporegistro == 3 ? ff102.Ff102VlLiqTitulo : 0,
                            ReceitaProvisao = (ff102sit.Label == "Provisão" && (ff102.Ff102Tiporegistro == 1 || ff102.Ff102Tiporegistro == 2)) ? ff102.Ff102VlLiqTitulo : 0,
                            ProvisaoAPagar = (ff102sit.Label == "Provisão" && ff102.Ff102Tiporegistro == 3) ? ff102.Ff102VlLiqTitulo : 0
                        };

            if (dataVencimentoInicio.HasValue)
                query = query.Where(x => x.Ano > dataVencimentoInicio.Value.Year
                    || (x.Ano == dataVencimentoInicio.Value.Year && x.Mes >= dataVencimentoInicio.Value.Month));

            if (dataVencimentoFim.HasValue)
                query = query.Where(x => x.Ano < dataVencimentoFim.Value.Year
                    || (x.Ano == dataVencimentoFim.Value.Year && x.Mes <= dataVencimentoFim.Value.Month));

            var agrupado = query
                .GroupBy(x => new { x.Ano, x.Mes })
                .Select(g => new
                {
                    Ano = g.Key.Ano,
                    Mes = g.Key.Mes,
                    TotalMes = g.Sum(x => x.ValorLiq),
                    AReceber = g.Sum(x => x.AReceber),
                    APagar = g.Sum(x => x.APagar),
                    ReceitaProvisao = g.Sum(x => x.ReceitaProvisao),
                    ProvisaoAPagar = g.Sum(x => x.ProvisaoAPagar)
                })
                .OrderBy(x => x.Ano)
                .ThenBy(x => x.Mes);

            var totais = await agrupado.ToListAsync();

            decimal saldoAcumulado = saldoAnterior;
            decimal saldoAnteriorLinha = saldoAnterior;
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

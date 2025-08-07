using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class GerencialTitulosAReceber(AppDbContext appDbContext)
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
            public string? NomeEmpresa { get; set; }
            public int? CodigoEmpresa { get; set; }
            public string? IdEstabelecimento { get; set; }
        }

        public class AnaliseIdadeContasReceberDto
        {
            public string FaixaIdade { get; set; } = string.Empty;
            public int QuantidadeTitulos { get; set; }
            public decimal TotalEmAberto { get; set; }
            public string? NomeEmpresa { get; set; }
            public int? CodigoEmpresa { get; set; }
            public string? IdEstabelecimento { get; set; }
        }

        public class TotalizadorEstabelecimentoDto
        {
            public string? IdEstabelecimento { get; set; }
            public string? NomeEmpresa { get; set; }
            public int? CodigoEmpresa { get; set; }
            public int QuantidadeTitulos { get; set; }
            public decimal TotalValor { get; set; }
            public List<AnaliseIdadeContasReceberDto> FaixasIdade { get; set; } = new List<AnaliseIdadeContasReceberDto>();
        }

        private class TituloDataInfo
        {
            public DateTime DataVencimento { get; set; }
            public decimal ValorLiquido { get; set; }
            public string? NomeEmpresa { get; set; }
            public int? CodigoEmpresa { get; set; }
            public string? IdEstabelecimento { get; set; }
        }

        public async Task<List<FluxoDeCaixaDiarioDto>> GetFluxoDeCaixaDiarioAsync(
           int tenant,
           DateTime? dataVencimentoInicio = null,
           DateTime? dataVencimentoFim = null,
           decimal saldoAnterior = 0,
           bool agruparPorEstabelecimento = false)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        
                        join conta in _appDbContext.OsusrE9aCsicpBb012s
                        on ff102.Ff102Contaid equals conta.Id into joinConta
                        from conta in joinConta.DefaultIfEmpty()
                        
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        join bb001 in _appDbContext.E9ACSICP_BB001s
                        on ff102.Ff102Filialid equals bb001.Id into joinEmpresa
                        from bb001 in joinEmpresa.DefaultIfEmpty()
                        
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
                            Label = ff102sit.Label,
                            NomeEmpresa = bb001.Bb001Razaosocial,
                            CodigoEmpresa = bb001.Bb001Codigoempresa,
                            IdEstabelecimento = ff102.Ff102Filialid
                        };

            if (dataVencimentoInicio.HasValue)
                query = query.Where(x => x.Data >= dataVencimentoInicio.Value);

            if (dataVencimentoFim.HasValue)
                query = query.Where(x => x.Data <= dataVencimentoFim.Value);

            var agrupado = agruparPorEstabelecimento 
                ? query.GroupBy(x => new
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
                        x.Label,
                        x.NomeEmpresa,
                        x.CodigoEmpresa,
                        x.IdEstabelecimento
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
                        NomeEmpresa = g.Key.NomeEmpresa,
                        CodigoEmpresa = g.Key.CodigoEmpresa,
                        IdEstabelecimento = g.Key.IdEstabelecimento,
                        TotalDia = g.Sum(x => x.ValorLiq)
                    })
                    .OrderBy(x => x.IdEstabelecimento)
                    .ThenBy(x => x.Data)
                    .ThenBy(x => x.TipoReg)
                : query.GroupBy(x => new
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
                        x.Label,
                        x.NomeEmpresa,
                        x.CodigoEmpresa,
                        x.IdEstabelecimento
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
                        NomeEmpresa = g.Key.NomeEmpresa,
                        CodigoEmpresa = g.Key.CodigoEmpresa,
                        IdEstabelecimento = g.Key.IdEstabelecimento,
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
                    SaldoAcumulado = saldoAcumulado,
                    NomeEmpresa = item.NomeEmpresa,
                    CodigoEmpresa = item.CodigoEmpresa,
                    IdEstabelecimento = item.IdEstabelecimento
                });
                saldoAnteriorLinha = saldoAcumulado;
            }
            return resultado;
        }
        
        public async Task<List<AnaliseIdadeContasReceberDto>> GetAnaliseIdadeContasReceberAsync(
            int tenant, 
            bool agruparPorEstabelecimento = false,
            List<string>? filtroEstabelecimentos = null)
        {
            var dataAtual = DateTime.Now.Date;

            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        join bb001 in _appDbContext.E9ACSICP_BB001s
                        on ff102.Ff102Filialid equals bb001.Id into joinEmpresa
                        from bb001 in joinEmpresa.DefaultIfEmpty()

                        where ff102.TenantId == tenant
                              && ff102.Ff102Tiporegistro == 1 // Contas a receber
                              && (ff102sit.Label == "Aberto" || ff102sit.Label == "Baixa Parcial")

                        select new TituloDataInfo
                        {
                            DataVencimento = ff102.Ff102DataVencimento,
                            ValorLiquido = ff102.Ff102VlLiqTitulo,
                            NomeEmpresa = bb001.Bb001Razaosocial,
                            CodigoEmpresa = bb001.Bb001Codigoempresa,
                            IdEstabelecimento = ff102.Ff102Filialid
                        };

            if (filtroEstabelecimentos != null && filtroEstabelecimentos.Any())
            {
                query = query.Where(t => t.IdEstabelecimento != null && filtroEstabelecimentos.Contains(t.IdEstabelecimento));
            }
            var titulos = await query.ToListAsync();
            
           

            if (agruparPorEstabelecimento)
            {
                return ProcessarAnaliseAgrupadaPorEstabelecimento(titulos, dataAtual);
            }
            else
            {
                return ProcessarAnaliseGeral(titulos, dataAtual);
            }
        }

        public async Task<List<TotalizadorEstabelecimentoDto>> GetTotalizadorPorEstabelecimentoAsync(
            int tenant, 
            List<string>? filtroEstabelecimentos = null)
        {
            var dataAtual = DateTime.Now.Date;

            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        join bb001 in _appDbContext.E9ACSICP_BB001s
                        on ff102.Ff102Filialid equals bb001.Id into joinEmpresa
                        from bb001 in joinEmpresa.DefaultIfEmpty()

                        where ff102.TenantId == tenant
                              && ff102.Ff102Tiporegistro == 1 // Contas a receber
                              && (ff102sit.Label == "Aberto" || ff102sit.Label == "Baixa Parcial")

                        select new TituloDataInfo
                        {
                            DataVencimento = ff102.Ff102DataVencimento,
                            ValorLiquido = ff102.Ff102VlLiqTitulo,
                            NomeEmpresa = bb001.Bb001Razaosocial,
                            CodigoEmpresa = bb001.Bb001Codigoempresa,
                            IdEstabelecimento = ff102.Ff102Filialid
                        };

            var titulos = await query.ToListAsync();

            // Aplicar filtro de estabelecimentos se fornecido
            if (filtroEstabelecimentos != null && filtroEstabelecimentos.Any())
            {
                titulos = titulos.Where(t => t.IdEstabelecimento != null && filtroEstabelecimentos.Contains(t.IdEstabelecimento)).ToList();
            }

            var estabelecimentos = titulos
                .GroupBy(t => new { t.IdEstabelecimento, t.NomeEmpresa, t.CodigoEmpresa })
                .Select(g => new TotalizadorEstabelecimentoDto
                {
                    IdEstabelecimento = g.Key.IdEstabelecimento,
                    NomeEmpresa = g.Key.NomeEmpresa,
                    CodigoEmpresa = g.Key.CodigoEmpresa,
                    QuantidadeTitulos = g.Count(),
                    TotalValor = g.Sum(x => x.ValorLiquido),
                    FaixasIdade = ProcessarFaixasIdadeParaEstabelecimento(g.ToList(), dataAtual, g.Key.IdEstabelecimento, g.Key.NomeEmpresa, g.Key.CodigoEmpresa)
                })
                .OrderBy(e => e.CodigoEmpresa)
                .ToList();

            return estabelecimentos;
        }

        private List<AnaliseIdadeContasReceberDto> ProcessarAnaliseGeral(List<TituloDataInfo> titulos, DateTime dataAtual)
        {
            var resultado = new List<AnaliseIdadeContasReceberDto>();

            // 000 - 030 Dias
            var faixa0a30 = titulos.Where(x => x.DataVencimento >= dataAtual.AddDays(-30) && x.DataVencimento <= dataAtual).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "000 - 030 Dias",
                QuantidadeTitulos = faixa0a30.Count,
                TotalEmAberto = faixa0a30.Sum(x => x.ValorLiquido)
            });

            // 0031 - 060 Dias
            var faixa31a60 = titulos.Where(x => x.DataVencimento >= dataAtual.AddDays(-60) && x.DataVencimento < dataAtual.AddDays(-30)).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "0031 - 060 Dias",
                QuantidadeTitulos = faixa31a60.Count,
                TotalEmAberto = faixa31a60.Sum(x => x.ValorLiquido)
            });

            // 061 - 090 Dias
            var faixa61a90 = titulos.Where(x => x.DataVencimento >= dataAtual.AddDays(-90) && x.DataVencimento < dataAtual.AddDays(-60)).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "061 - 090 Dias",
                QuantidadeTitulos = faixa61a90.Count,
                TotalEmAberto = faixa61a90.Sum(x => x.ValorLiquido)
            });

            // Maior que 90 Dias
            var faixaMaior90 = titulos.Where(x => x.DataVencimento < dataAtual.AddDays(-90)).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "Maior que 90 Dias",
                QuantidadeTitulos = faixaMaior90.Count,
                TotalEmAberto = faixaMaior90.Sum(x => x.ValorLiquido)
            });

            return resultado;
        }

        private List<AnaliseIdadeContasReceberDto> ProcessarAnaliseAgrupadaPorEstabelecimento(List<TituloDataInfo> titulos, DateTime dataAtual)
        {
            var resultado = new List<AnaliseIdadeContasReceberDto>();

            var estabelecimentos = titulos
                .GroupBy(t => new { t.IdEstabelecimento, t.NomeEmpresa, t.CodigoEmpresa })
                .ToList();

            foreach (var estabelecimento in estabelecimentos)
            {
                var titulosEstab = estabelecimento.ToList();

                // 000 - 030 Dias
                var faixa0a30 = titulosEstab.Where(x => x.DataVencimento >= dataAtual.AddDays(-30) && x.DataVencimento <= dataAtual).ToList();
                resultado.Add(new AnaliseIdadeContasReceberDto
                {
                    FaixaIdade = "000 - 030 Dias",
                    QuantidadeTitulos = faixa0a30.Count,
                    TotalEmAberto = faixa0a30.Sum(x => x.ValorLiquido),
                    NomeEmpresa = estabelecimento.Key.NomeEmpresa,
                    CodigoEmpresa = estabelecimento.Key.CodigoEmpresa,
                    IdEstabelecimento = estabelecimento.Key.IdEstabelecimento
                });

                // 0031 - 060 Dias
                var faixa31a60 = titulosEstab.Where(x => x.DataVencimento >= dataAtual.AddDays(-60) && x.DataVencimento < dataAtual.AddDays(-30)).ToList();
                resultado.Add(new AnaliseIdadeContasReceberDto
                {
                    FaixaIdade = "0031 - 060 Dias",
                    QuantidadeTitulos = faixa31a60.Count,
                    TotalEmAberto = faixa31a60.Sum(x => x.ValorLiquido),
                    NomeEmpresa = estabelecimento.Key.NomeEmpresa,
                    CodigoEmpresa = estabelecimento.Key.CodigoEmpresa,
                    IdEstabelecimento = estabelecimento.Key.IdEstabelecimento
                });

                // 061 - 090 Dias
                var faixa61a90 = titulosEstab.Where(x => x.DataVencimento >= dataAtual.AddDays(-90) && x.DataVencimento < dataAtual.AddDays(-60)).ToList();
                resultado.Add(new AnaliseIdadeContasReceberDto
                {
                    FaixaIdade = "061 - 090 Dias",
                    QuantidadeTitulos = faixa61a90.Count,
                    TotalEmAberto = faixa61a90.Sum(x => x.ValorLiquido),
                    NomeEmpresa = estabelecimento.Key.NomeEmpresa,
                    CodigoEmpresa = estabelecimento.Key.CodigoEmpresa,
                    IdEstabelecimento = estabelecimento.Key.IdEstabelecimento
                });

                // Maior que 90 Dias
                var faixaMaior90 = titulosEstab.Where(x => x.DataVencimento < dataAtual.AddDays(-90)).ToList();
                resultado.Add(new AnaliseIdadeContasReceberDto
                {
                    FaixaIdade = "Maior que 90 Dias",
                    QuantidadeTitulos = faixaMaior90.Count,
                    TotalEmAberto = faixaMaior90.Sum(x => x.ValorLiquido),
                    NomeEmpresa = estabelecimento.Key.NomeEmpresa,
                    CodigoEmpresa = estabelecimento.Key.CodigoEmpresa,
                    IdEstabelecimento = estabelecimento.Key.IdEstabelecimento
                });
            }

            return resultado.OrderBy(r => r.CodigoEmpresa).ThenBy(r => r.FaixaIdade).ToList();
        }

        private List<AnaliseIdadeContasReceberDto> ProcessarFaixasIdadeParaEstabelecimento(List<TituloDataInfo> titulos, DateTime dataAtual, string? idEstabelecimento, string? nomeEmpresa, int? codigoEmpresa)
        {
            var resultado = new List<AnaliseIdadeContasReceberDto>();

            // 000 - 030 Dias
            var faixa0a30 = titulos.Where(x => x.DataVencimento >= dataAtual.AddDays(-30) && x.DataVencimento <= dataAtual).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "000 - 030 Dias",
                QuantidadeTitulos = faixa0a30.Count,
                TotalEmAberto = faixa0a30.Sum(x => x.ValorLiquido),
                NomeEmpresa = nomeEmpresa,
                CodigoEmpresa = codigoEmpresa,
                IdEstabelecimento = idEstabelecimento
            });

            // 0031 - 060 Dias
            var faixa31a60 = titulos.Where(x => x.DataVencimento >= dataAtual.AddDays(-60) && x.DataVencimento < dataAtual.AddDays(-30)).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "0031 - 060 Dias",
                QuantidadeTitulos = faixa31a60.Count,
                TotalEmAberto = faixa31a60.Sum(x => x.ValorLiquido),
                NomeEmpresa = nomeEmpresa,
                CodigoEmpresa = codigoEmpresa,
                IdEstabelecimento = idEstabelecimento
            });

            // 061 - 090 Dias
            var faixa61a90 = titulos.Where(x => x.DataVencimento >= dataAtual.AddDays(-90) && x.DataVencimento < dataAtual.AddDays(-60)).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "061 - 090 Dias",
                QuantidadeTitulos = faixa61a90.Count,
                TotalEmAberto = faixa61a90.Sum(x => x.ValorLiquido),
                NomeEmpresa = nomeEmpresa,
                CodigoEmpresa = codigoEmpresa,
                IdEstabelecimento = idEstabelecimento
            });

            // Maior que 90 Dias
            var faixaMaior90 = titulos.Where(x => x.DataVencimento < dataAtual.AddDays(-90)).ToList();
            resultado.Add(new AnaliseIdadeContasReceberDto
            {
                FaixaIdade = "Maior que 90 Dias",
                QuantidadeTitulos = faixaMaior90.Count,
                TotalEmAberto = faixaMaior90.Sum(x => x.ValorLiquido),
                NomeEmpresa = nomeEmpresa,
                CodigoEmpresa = codigoEmpresa,
                IdEstabelecimento = idEstabelecimento
            });

            return resultado;
        }
    }
}

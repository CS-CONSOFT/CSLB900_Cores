using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro
{
    public class TitulosAbertoPorFaixaDiasRepository(AppDbContext appDbContext) : ITitulosAbertoPorFaixaDiasRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
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


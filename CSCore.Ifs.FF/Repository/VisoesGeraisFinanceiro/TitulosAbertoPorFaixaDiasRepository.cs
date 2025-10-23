using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using static CSCore.Domain.EstaticasLabel.GG.Entities;

namespace CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro
{
    public class TitulosAbertoPorFaixaDiasRepository(AppDbContext appDbContext) : ITitulosAbertoPorFaixaDiasRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private class TituloDataInfo
        {
            public DateTime DataVencimento { get; set; }
            public decimal ValorLiquido { get; set; }
            public string? NomeEmpresa { get; set; }
            public int? CodigoEmpresa { get; set; }
            public string? IdEstabelecimento { get; set; }
        }

        public async Task<(List<DtoAnaliseIdadeContasReceber>, int)> GetAnaliseIdadeContasReceberAsync(
            int in_tenant,
                        int PageNumber, int PageSize,
            bool in_agruparPorEstabelecimento = false,
            List<string>? in_filtroEstabelecimentos = null)
        {
            var dataAtual = DateTime.Now.Date;

            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        .AsNoTracking()
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        .AsNoTracking()
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        join bb001 in _appDbContext.E9ACSICP_BB001s
                        on ff102.Ff102Filialid equals bb001.Id into joinEmpresa
                        from bb001 in joinEmpresa.DefaultIfEmpty()

                        where ff102.TenantId == in_tenant
                              && ff102.Ff102Tiporegistro == 1 // Contas a receber
                              && (ff102sit.Label == Csicp_ff102_Situacao.Aberto || ff102sit.Label == Csicp_ff102_Situacao.BxParcial)

                        select new TituloDataInfo
                        {
                            DataVencimento = ff102.Ff102DataVencimento,
                            ValorLiquido = ff102.Ff102VlLiqTitulo,
                            NomeEmpresa = bb001.Bb001Razaosocial,
                            CodigoEmpresa = bb001.Bb001Codigoempresa,
                            IdEstabelecimento = ff102.Ff102Filialid
                        };

            if (in_filtroEstabelecimentos != null && in_filtroEstabelecimentos.Count != 0)
            {
                query = query.Where(t => t.IdEstabelecimento != null && in_filtroEstabelecimentos.Contains(t.IdEstabelecimento));
            }


            var queryCount = query;
            int totalRegistros = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(PageNumber, PageSize);

            var titulos = await query.ToListAsync();

            if (in_agruparPorEstabelecimento)
            {
                var lista = ProcessarAnaliseAgrupadaPorEstabelecimento(titulos, dataAtual);
                return (lista, totalRegistros);
            }
            else
            {
                var lista = ProcessarAnaliseGeral(titulos, dataAtual);
                return (lista, totalRegistros);
            }
        }

        public async Task<(List<DtoTotalizadorEstabelecimento>, int)> GetTotalizadorPorEstabelecimentoAsync(
            int in_tenant,
                    int PageNumber, int PageSize,
            List<string>? in_filtroEstabelecimentos = null)
        {
            var dataAtual = DateTime.Now.Date;

            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                        on ff102.Ff102Situacaoid equals ff102sit.Id

                        join bb001 in _appDbContext.E9ACSICP_BB001s
                        on ff102.Ff102Filialid equals bb001.Id into joinEmpresa
                        from bb001 in joinEmpresa.DefaultIfEmpty()

                        where ff102.TenantId == in_tenant
                              && ff102.Ff102Tiporegistro == 1 // Contas a receber
                              && (ff102sit.Label == Csicp_ff102_Situacao.Aberto || ff102sit.Label == Csicp_ff102_Situacao.BxParcial)

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
            if (in_filtroEstabelecimentos != null && in_filtroEstabelecimentos.Any())
            {
                titulos = titulos.Where(t => t.IdEstabelecimento != null && in_filtroEstabelecimentos.Contains(t.IdEstabelecimento)).ToList();
            }

            var queryCount = query;
            int totalRegistros = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(PageNumber, PageSize);


            var estabelecimentos = titulos
                .GroupBy(t => new { t.IdEstabelecimento, t.NomeEmpresa, t.CodigoEmpresa })
                .Select(g => new DtoTotalizadorEstabelecimento
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

            return (estabelecimentos, totalRegistros);
        }

        private List<DtoAnaliseIdadeContasReceber> ProcessarAnaliseGeral
            (List<TituloDataInfo> in_titulos, DateTime in_dataAtual)
        {
            var resultado = new List<DtoAnaliseIdadeContasReceber>();

            // 000 - 030 Dias
            var faixa0a30 = in_titulos
                .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-30) && x.DataVencimento <= in_dataAtual).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
            {
                FaixaIdade = "000 - 030 Dias",
                QuantidadeTitulos = faixa0a30.Count,
                TotalEmAberto = faixa0a30.Sum(x => x.ValorLiquido)
            });

            // 0031 - 060 Dias
            var faixa31a60 = in_titulos
                .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-60) && x.DataVencimento < in_dataAtual.AddDays(-30)).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
            {
                FaixaIdade = "0031 - 060 Dias",
                QuantidadeTitulos = faixa31a60.Count,
                TotalEmAberto = faixa31a60.Sum(x => x.ValorLiquido)
            });

            // 061 - 090 Dias
            var faixa61a90 = in_titulos
                .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-90) && x.DataVencimento < in_dataAtual.AddDays(-60)).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
            {
                FaixaIdade = "061 - 090 Dias",
                QuantidadeTitulos = faixa61a90.Count,
                TotalEmAberto = faixa61a90.Sum(x => x.ValorLiquido)
            });

            // Maior que 90 Dias
            var faixaMaior90 = in_titulos
                .Where(x => x.DataVencimento < in_dataAtual.AddDays(-90)).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
            {
                FaixaIdade = "Maior que 90 Dias",
                QuantidadeTitulos = faixaMaior90.Count,
                TotalEmAberto = faixaMaior90.Sum(x => x.ValorLiquido)
            });

            return resultado;
        }

        private List<DtoAnaliseIdadeContasReceber> ProcessarAnaliseAgrupadaPorEstabelecimento
            (List<TituloDataInfo> in_titulos, DateTime in_dataAtual)
        {
            var resultado = new List<DtoAnaliseIdadeContasReceber>();

            var estabelecimentos = in_titulos
                .GroupBy(t => new { t.IdEstabelecimento, t.NomeEmpresa, t.CodigoEmpresa })
                .ToList();

            foreach (var estabelecimento in estabelecimentos)
            {
                var titulosEstab = estabelecimento.ToList();

                // 000 - 030 Dias
                var faixa0a30 = titulosEstab
                    .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-30) && x.DataVencimento <= in_dataAtual).ToList();
                resultado.Add(new DtoAnaliseIdadeContasReceber
                {
                    FaixaIdade = "000 - 030 Dias",
                    QuantidadeTitulos = faixa0a30.Count,
                    TotalEmAberto = faixa0a30.Sum(x => x.ValorLiquido),
                    NomeEmpresa = estabelecimento.Key.NomeEmpresa,
                    CodigoEmpresa = estabelecimento.Key.CodigoEmpresa,
                    IdEstabelecimento = estabelecimento.Key.IdEstabelecimento
                });

                // 0031 - 060 Dias
                var faixa31a60 = titulosEstab
                    .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-60) && x.DataVencimento < in_dataAtual.AddDays(-30)).ToList();
                resultado.Add(new DtoAnaliseIdadeContasReceber
                {
                    FaixaIdade = "0031 - 060 Dias",
                    QuantidadeTitulos = faixa31a60.Count,
                    TotalEmAberto = faixa31a60.Sum(x => x.ValorLiquido),
                    NomeEmpresa = estabelecimento.Key.NomeEmpresa,
                    CodigoEmpresa = estabelecimento.Key.CodigoEmpresa,
                    IdEstabelecimento = estabelecimento.Key.IdEstabelecimento
                });

                // 061 - 090 Dias
                var faixa61a90 = titulosEstab
                    .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-90) && x.DataVencimento < in_dataAtual.AddDays(-60)).ToList();
                resultado.Add(new DtoAnaliseIdadeContasReceber
                {
                    FaixaIdade = "061 - 090 Dias",
                    QuantidadeTitulos = faixa61a90.Count,
                    TotalEmAberto = faixa61a90.Sum(x => x.ValorLiquido),
                    NomeEmpresa = estabelecimento.Key.NomeEmpresa,
                    CodigoEmpresa = estabelecimento.Key.CodigoEmpresa,
                    IdEstabelecimento = estabelecimento.Key.IdEstabelecimento
                });

                // Maior que 90 Dias
                var faixaMaior90 = titulosEstab
                    .Where(x => x.DataVencimento < in_dataAtual.AddDays(-90)).ToList();
                resultado.Add(new DtoAnaliseIdadeContasReceber
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

        private List<DtoAnaliseIdadeContasReceber> ProcessarFaixasIdadeParaEstabelecimento
            (List<TituloDataInfo> in_titulos, DateTime in_dataAtual, string? idEstabelecimento, string? nomeEmpresa, int? codigoEmpresa)
        {
            var resultado = new List<DtoAnaliseIdadeContasReceber>();

            // 000 - 030 Dias
            var faixa0a30 = in_titulos
                .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-30) && x.DataVencimento <= in_dataAtual).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
            {
                FaixaIdade = "000 - 030 Dias",
                QuantidadeTitulos = faixa0a30.Count,
                TotalEmAberto = faixa0a30.Sum(x => x.ValorLiquido),
                NomeEmpresa = nomeEmpresa,
                CodigoEmpresa = codigoEmpresa,
                IdEstabelecimento = idEstabelecimento
            });

            // 0031 - 060 Dias
            var faixa31a60 = in_titulos
                .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-60) && x.DataVencimento < in_dataAtual.AddDays(-30)).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
            {
                FaixaIdade = "0031 - 060 Dias",
                QuantidadeTitulos = faixa31a60.Count,
                TotalEmAberto = faixa31a60.Sum(x => x.ValorLiquido),
                NomeEmpresa = nomeEmpresa,
                CodigoEmpresa = codigoEmpresa,
                IdEstabelecimento = idEstabelecimento
            });

            // 061 - 090 Dias
            var faixa61a90 = in_titulos
                .Where(x => x.DataVencimento >= in_dataAtual.AddDays(-90) && x.DataVencimento < in_dataAtual.AddDays(-60)).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
            {
                FaixaIdade = "061 - 090 Dias",
                QuantidadeTitulos = faixa61a90.Count,
                TotalEmAberto = faixa61a90.Sum(x => x.ValorLiquido),
                NomeEmpresa = nomeEmpresa,
                CodigoEmpresa = codigoEmpresa,
                IdEstabelecimento = idEstabelecimento
            });

            // Maior que 90 Dias
            var faixaMaior90 = in_titulos
                .Where(x => x.DataVencimento < in_dataAtual.AddDays(-90)).ToList();
            resultado.Add(new DtoAnaliseIdadeContasReceber
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


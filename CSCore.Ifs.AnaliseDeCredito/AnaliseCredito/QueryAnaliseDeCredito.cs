using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.AnaliseDeCredito.NovaPasta
{
    public class QueryAnaliseDeCredito(AppDbContext appDbContext)
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<AnaliseCreditoResultado?> GetAnaliseCreditoAsync(int in_tenantID, string in_contaID, AnaliseCreditoParametros parametros)
        {
            // 1. Calcular e_b (Média Salarial do Bairro) baseado no IDH_R
            decimal e_b = parametros.IDHR switch
            {
                >= 0.800m and <= 1m => 1m,
                >= 0.700m and < 0.800m => 0.7m,
                >= 0.600m and < 0.700m => 0.6m,
                >= 0.500m and < 0.600m => 0.5m,
                _ => 0.4m
            };

            // 2. Calcular TS (Taxa Score)
            decimal TS = parametros.ScoreClear switch
            {
                >= 800m and <= 900m => 0.4m,
                >= 600m and < 800m => 0.3m,
                >= 400m and < 600m => 0.2m,
                < 400m => 0.1m,
                _ => 0.1m
            };

            // Pesos para atrasos
            decimal Peso_AF = 0.2m, Peso_AM = 0.5m, Peso_PP = 0.8m, Peso_SP = 1m;

            // 3. Obter dados de comportamento de compras e pagamentos
            var dataLimite = DateTime.Now.AddYears(-1);

            var compras = _appDbContext.OsusrTeiCsicpDd040s
                .Where(x => x.TenantId == in_tenantID
                    && x.Dd040DataEmissao <= DateTime.Now
                    && x.Dd040DataEmissao >= dataLimite
                    && x.Dd040ContaId == in_contaID);

            int qtdComportamentoCompras = await compras.CountAsync();

            int? id = _appDbContext.OsusrE9aCsicpFf103Tpbais.FirstOrDefault(t => t.Label == "Baixa")?.Id;
            // Subqueries para atrasos e pagamentos
            var ff103 = _appDbContext.OsusrE9aCsicpFf103s
                .Where(ff => ff.TenantId == in_tenantID
                    && ff.NavFF102!.Ff102Contaid == in_contaID
                    && ff.NavFF102!.Ff102DataEmissao <= DateTime.Now
                    && ff.NavFF102!.Ff102DataEmissao >= dataLimite
                    && ff.Ff103Baixado == true
                    && ff.Ff103Estornado == false
                    && ff.Ff103Cancelado == false
                    && ff.Ff103Tpbaixaid == id);

            decimal qtdAtrasosFreq = await ff103
                .Where(ff => EF.Functions.DateDiffDay(ff.NavFF102!.Ff102DataVencimento, ff.Ff103DataBaixa) > 15)
                .CountAsync() * Peso_AF;

            decimal qtdAtrasosModerados = await ff103
                .Where(ff => EF.Functions.DateDiffDay(ff.NavFF102!.Ff102DataVencimento, ff.Ff103DataBaixa) >= 6
                          && EF.Functions.DateDiffDay(ff.NavFF102!.Ff102DataVencimento, ff.Ff103DataBaixa) <= 15)
                .CountAsync() * Peso_AM;

            decimal qtdPagtosPontuais = await ff103
                .Where(ff => EF.Functions.DateDiffDay(ff.NavFF102!.Ff102DataVencimento, ff.Ff103DataBaixa) >= 1
                          && EF.Functions.DateDiffDay(ff.NavFF102!.Ff102DataVencimento, ff.Ff103DataBaixa) <= 5)
                .CountAsync() * Peso_PP;

            decimal qtdSemprePagaPrazo = await ff103
                .Where(ff => EF.Functions.DateDiffDay(ff.NavFF102!.Ff102DataVencimento, ff.Ff103DataBaixa) <= 0)
                .CountAsync() * Peso_SP;

            int qtdTitulos = await ff103.CountAsync();

            // 4. Calcular Peso_C
            decimal pesoC = qtdComportamentoCompras switch
            {
                0 => 0m,
                >= 1 and <= 2 => 0.3m,
                >= 3 and <= 5 => 0.5m,
                >= 6 and <= 10 => 0.8m,
                > 10 => 1m,
                _ => 0m
            };

            // 5. Calcular Peso_P
            decimal pesoP = qtdTitulos > 0
                ? Math.Round((qtdAtrasosFreq + qtdAtrasosModerados + qtdPagtosPontuais + qtdSemprePagaPrazo) / qtdTitulos, 1)
                : 1m;

            // 6. Calcular Crédito Sem Score
            decimal creditoSemScore = ((pesoC * parametros.WC) + (pesoP * parametros.WP) + (e_b * parametros.WE) + (pesoP * parametros.WR))
                / (parametros.WC + parametros.WP + parametros.WE + parametros.WR)
                * parametros.Renda * parametros.F;

            // 7. Calcular Crédito Com Score
            decimal creditoComScore = Math.Round(parametros.Renda * TS, 2);

            // 8. Calcular Média Crédito
            decimal mediaCredito = ((parametros.WS * creditoComScore) + (parametros.WN * creditoSemScore))
                / (parametros.WS + parametros.WN);

            // 9. Montar resultado
            return new AnaliseCreditoResultado
            {
                Ano = DateTime.Now.Year,
                Mes = DateTime.Now.Month,
                ContaId = in_contaID ?? "",
                QtdComportamentoCompras = qtdComportamentoCompras,
                QtdAtrasosFreq = qtdAtrasosFreq,
                QtdAtrasosModerados = qtdAtrasosModerados,
                QtdPagtosPontuais = qtdPagtosPontuais,
                QtdSemprePagaPrazo = qtdSemprePagaPrazo,
                QtdTitulos = qtdTitulos,
                PesoC = pesoC,
                PesoP = pesoP,
                MediaSalarialBairro = e_b,
                Renda = parametros.Renda,
                FatorAjuste = parametros.F,
                WC = parametros.WC,
                WP = parametros.WP,
                WE = parametros.WE,
                WR = parametros.WR,
                CreditoSemScore = creditoSemScore,
                ScoreClearSale = parametros.ScoreClear,
                TaxaScore = TS,
                CreditoComScore = creditoComScore,
                MediaCredito = mediaCredito
            };
        }
    }

    public class AnaliseCreditoParametros
    {
        public decimal Renda { get; set; } = 0m;
        public decimal WC { get; set; } = 0m;
        public decimal WP { get; set; } = 0m;
        public decimal WE { get; set; } = 0m;
        public decimal WR { get; set; } = 0m;
        public decimal e_b { get; set; } = 0m;
        public decimal TS { get; set; } = 0m;
        public decimal F { get; set; } = 0m;
        public decimal IDHR { get; set; } = 0m;
        public decimal ScoreClear { get; set; } = 0m;
        public decimal WS { get; set; } = 0m;
        public decimal WN { get; set; } = 0m;
    }

    public class AnaliseCreditoResultado
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string ContaId { get; set; }
        public int QtdComportamentoCompras { get; set; }
        public decimal QtdAtrasosFreq { get; set; }
        public decimal QtdAtrasosModerados { get; set; }
        public decimal QtdPagtosPontuais { get; set; }
        public decimal QtdSemprePagaPrazo { get; set; }
        public int QtdTitulos { get; set; }
        public decimal PesoC { get; set; }
        public decimal PesoP { get; set; }
        public decimal MediaSalarialBairro { get; set; }
        public decimal Renda { get; set; }
        public decimal FatorAjuste { get; set; }
        public decimal WC { get; set; }
        public decimal WP { get; set; }
        public decimal WE { get; set; }
        public decimal WR { get; set; }
        public decimal CreditoSemScore { get; set; }
        public decimal ScoreClearSale { get; set; }
        public decimal TaxaScore { get; set; }
        public decimal CreditoComScore { get; set; }
        public decimal MediaCredito { get; set; }
    }
}

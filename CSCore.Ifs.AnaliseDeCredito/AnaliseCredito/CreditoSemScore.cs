using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Ifs.AnaliseDeCredito.NovaPasta;
using CSCore.Ifs.Compartilhado.Utilidade.SiteProperties;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.Json;
namespace CSCore.Ifs.AnaliseDeCredito.AnaliseCredito
{
    public class CreditoSemScore(
        AppDbContext appDbContext,
        ScoreClearSale scoreClearSale,
        QueryAnaliseDeCredito queryAnaliseDeCredito)
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly ScoreClearSale _scoreClearSale = scoreClearSale;
        private readonly QueryAnaliseDeCredito _queryAnaliseDeCredito = queryAnaliseDeCredito;
        public async Task<DtoOutRetorno> ExecutarAnaliseCredito
            (bool in_CalcularScoreClearsale, int in_tenantID, string in_contaID)
        {
            Serilog.Log.Information(
        "Executando análise de crédito | CalcularScoreClearsale: {CalcularScoreClearsale}, TenantID: {TenantID}, ContaID: {ContaID}, Data: {Data}",
        in_CalcularScoreClearsale, in_tenantID, in_contaID, DateTime.Now);

            var in_variaveisCalculo = new AnaliseCreditoParametros();
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                ContaDadosDto getDadosContaConta = await GetDadosConta(in_tenantID, in_contaID);
                List<CSICP_BB01210> creditoGradual = await GetCreditoGradual(in_contaID);
                CSICP_BB01210? getScore = await GetScore(in_contaID);

                if (!in_CalcularScoreClearsale)
                {
                    if (getScore is not null)
                    {
                        return new DtoOutRetorno
                        {
                            CsicpBb01210 = getScore,
                            CsicpBb012 = getDadosContaConta.Bb012,
                            CsicpBb01201 = getDadosContaConta.Bb01201,
                            CsicpBb01202 = getDadosContaConta.Bb01202,
                            CreditoGradualList = creditoGradual
                        };
                    }
                    CS_DefinirRendaConta(in_variaveisCalculo, getDadosContaConta.Bb01202?.Bb012Valorremuneracao);
                }

                if (in_CalcularScoreClearsale && in_variaveisCalculo.Renda == 0)
                    CS_DefinirRendaConta(in_variaveisCalculo, getDadosContaConta.Bb01202?.Bb012Valorremuneracao);

                await CS_CalcularIDHR(in_variaveisCalculo, getDadosContaConta.Bb01206?.Bb012CodigoCidade,
                                              getDadosContaConta.Bb01206?.Bb012Logradouro,
                                              getDadosContaConta.Bb01206?.Bb012Bairro,
                                              getDadosContaConta.Bb01206?.Bb012Complemento);

                (string scoreJson, decimal scoreDecimal) =
                    await CS_CalculaScoreDecimal(in_tenantID, in_variaveisCalculo, getDadosContaConta.Bb01202?.Bb012Cpf ?? 0m);

                AnaliseCreditoResultado? analiseCreditoResultado
                    = await GetAnaliseDeCredito(
                        in_tenantID, in_contaID, in_variaveisCalculo, getDadosContaConta.Bb01202?.Bb012Valorremuneracao, scoreDecimal);

                CSICP_BB01210 bb010ParaSalvar = await CS_SalvaBB01210(in_contaID, in_tenantID, scoreJson, analiseCreditoResultado);

                await AtualizaLimiteDeCredito(getDadosContaConta, analiseCreditoResultado, in_variaveisCalculo.Renda);

                await transaction.CommitAsync();
                return new DtoOutRetorno
                {
                    CsicpBb01210 = bb010ParaSalvar,
                    CsicpBb012 = getDadosContaConta.Bb012,
                    CsicpBb01201 = getDadosContaConta.Bb01201,
                    CsicpBb01202 = getDadosContaConta.Bb01202,
                    CreditoGradualList = creditoGradual
                };
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }

        }

        private async Task<CSICP_BB01210?> GetScore(string in_contaID)
        {
            return await (from bb01210 in _appDbContext.OsusrE9aCsicpBb01210s
                          where bb01210.Bb012Id == in_contaID
                                && bb01210.Bb01210Tipo == 1
                          select bb01210)
                                            .FirstOrDefaultAsync();
        }

        private async Task<List<CSICP_BB01210>> GetCreditoGradual(string in_contaID)
        {
            return await _appDbContext.OsusrE9aCsicpBb01210s
                 .Where(e => e.Bb012Id == in_contaID && e.Bb01210Tipo == 2)
                 .ToListAsync();
        }

        private async Task<ContaDadosDto> GetDadosConta(int in_tenantID, string in_contaID)
        {
            return await (from b01202 in _appDbContext.OsusrE9aCsicpBb01202s
                          join b012 in _appDbContext.OsusrE9aCsicpBb012s on b01202.Id equals b012.Id
                          join b01206 in _appDbContext.OsusrE9aCsicpBb01206s on b012.Id equals b01206.Bb012Id into b01206Group
                          from b01206 in b01206Group.DefaultIfEmpty()
                          join b01201 in _appDbContext.OsusrE9aCsicpBb01201s on b012.Id equals b01201.Id into b01201Group
                          from b01201 in b01201Group.DefaultIfEmpty()

                          where b01202.TenantId == in_tenantID && b01202.Id == in_contaID
                          select new ContaDadosDto
                          {
                              Bb01202 = b01202,
                              Bb012 = b012,
                              Bb01206 = b01206,
                              Bb01201 = b01201
                          }).FirstAsync();
        }

        private async Task AtualizaLimiteDeCredito(ContaDadosDto getDadosContaConta, AnaliseCreditoResultado? analiseCreditoResultado, decimal in_renda)
        {
            if (getDadosContaConta.Bb01201 != null)
            {
                getDadosContaConta.Bb01201.Bb012Limitecredito = analiseCreditoResultado?.MediaCredito ?? 0m;
                _appDbContext.Update(getDadosContaConta.Bb01201);
            }
            await _appDbContext.SaveChangesAsync();
        }

        private async Task<CSICP_BB01210> CS_SalvaBB01210(
            string in_contaID,
            int in_tenantID,
            string in_scoreJson,
            AnaliseCreditoResultado? analiseCreditoResultado)
        {
            CSICP_BB01210? getScore = await GetScore(in_contaID);
            if (getScore is null)
            {
                getScore = new CSICP_BB01210();
                AtualizarPropriedadesScore(getScore, in_tenantID, in_contaID, analiseCreditoResultado, in_scoreJson);
                _appDbContext.Add(getScore);
            }
            if (getScore is not null)
            {
                AtualizarPropriedadesScore(getScore, in_tenantID, in_contaID, analiseCreditoResultado, in_scoreJson);
                _appDbContext.Update(getScore);
            }
            await _appDbContext.SaveChangesAsync();
            return getScore!;
        }

        private static void AtualizarPropriedadesScore(
                CSICP_BB01210 score,
                int tenantId,
                string contaId,
                AnaliseCreditoResultado? resultado,
                string scoreJson)
        {
            score.TenantId = tenantId;
            score.Bb012Id = contaId;
            score.Bb01210Tipo = 1;
            score.Bb01210Ano = resultado?.Ano;
            score.Bb01210Mes = resultado?.Mes;
            score.Bb01210Vcredsemscore = resultado?.CreditoSemScore;
            score.Bb01210Vcredcomscore = resultado?.CreditoComScore;
            score.Bb01210Vcredmedia = resultado?.MediaCredito;
            score.Bb01210Dtregistro = DateTime.Now;
            score.QtdComportamentoCompras = resultado?.QtdComportamentoCompras;
            score.QtdAtrasosfreq = resultado?.QtdAtrasosFreq;
            score.QtdAtrasosmoderados = resultado?.QtdAtrasosModerados;
            score.QtdPagtospontuais = resultado?.QtdPagtosPontuais;
            score.QtdSemprepagaprazo = resultado?.QtdSemprePagaPrazo;
            score.QtdTitulos = resultado?.QtdTitulos;
            score.CteObtemPesoC = resultado?.PesoC;
            score.CteObtemPesoP = resultado?.PesoP;
            score.Mediasalarialbairro = resultado?.MediaSalarialBairro;
            score.Renda = resultado?.Renda;
            score.FFatorajuste = resultado?.FatorAjuste;
            score.Wc = resultado?.WC;
            score.We = resultado?.WE;
            score.Wp = resultado?.WP;
            score.Wr = resultado?.WR;
            score.Scoreclearsale = resultado?.ScoreClearSale;
            score.Taxascore = resultado?.TaxaScore;
            score.JsonCreditpro = scoreJson;
        }

        private async Task<AnaliseCreditoResultado?> GetAnaliseDeCredito(
            int in_tenantID, string in_contaID, AnaliseCreditoParametros in_variaveisCalculo,
            decimal? Bb012Valorremuneracao, decimal scoreDecimal)
        {
            ListDtoAA001Json? parametrosAnaliseDeCredito =
                await CS_Get_ParametrosAnaliseCredito(in_tenantID);

            var parametros = new AnaliseCreditoParametros
            {
                Renda = Bb012Valorremuneracao ?? 0m,
                WC = Get_ValorParmAnaliseCredito(parametrosAnaliseDeCredito!.Parametros_List, "wC"),
                WP = Get_ValorParmAnaliseCredito(parametrosAnaliseDeCredito.Parametros_List, "wP"),
                WE = Get_ValorParmAnaliseCredito(parametrosAnaliseDeCredito.Parametros_List, "wE"),
                WR = Get_ValorParmAnaliseCredito(parametrosAnaliseDeCredito.Parametros_List, "wR"),
                F = Get_ValorParmAnaliseCredito(parametrosAnaliseDeCredito.Parametros_List, "F"),
                IDHR = in_variaveisCalculo.IDHR,
                ScoreClear = scoreDecimal,
                WS = Get_ValorParmAnaliseCredito(parametrosAnaliseDeCredito.Parametros_List, "wS"),
                WN = Get_ValorParmAnaliseCredito(parametrosAnaliseDeCredito.Parametros_List, "wN"),
                e_b = in_variaveisCalculo.e_b,
                TS = in_variaveisCalculo.TS
            };
            AnaliseCreditoResultado? analiseCreditoResultado = await _queryAnaliseDeCredito.GetAnaliseCreditoAsync(
                in_tenantID, in_contaID, parametros);
            return analiseCreditoResultado;
        }

        private async Task<(string, decimal)> CS_CalculaScoreDecimal(int in_tenantID, AnaliseCreditoParametros in_variaveisCalculo, decimal cpf)
        {
            (string scoreValor, string scoreJson) = await _scoreClearSale.CS_ScoreClearSale(in_tenantID, cpf);
            decimal scoreDecimal = decimal.TryParse(scoreValor, out var score) ? score : 0m;
            var _ = scoreDecimal switch
            {
                >= 0.800m and <= 0.900m => in_variaveisCalculo.TS = 0.4m,
                >= 0.600m and <= 0.799m => in_variaveisCalculo.TS = 0.3m,
                >= 0.400m and <= 0.599m => in_variaveisCalculo.TS = 0.2m,
                _ => in_variaveisCalculo.TS = 0.1m
            };
            return (scoreJson, scoreDecimal);
        }

        private static decimal Get_ValorParmAnaliseCredito(IEnumerable<DtoAA001Json> parametrosAnaliseDeCredito, string in_parametro)
        {
            string? value = parametrosAnaliseDeCredito.Where(e => e.Descricao == in_parametro).FirstOrDefault()?.Value;
            decimal valor = decimal.Parse(value ?? "0", CultureInfo.InvariantCulture);
            return valor;
        }

        private async Task CS_CalcularIDHR(
            AnaliseCreditoParametros in_variaveisCalculo,
            string? codigoCidade,
            string? logradouro,
            string? bairro,
            string? complemento)
        {
            CSICP_Aa024? aa024Dados = await GetIDHR(
                                          codigoCidade, logradouro, bairro, complemento
                                          );

            if (aa024Dados is null) in_variaveisCalculo.IDHR = 0.556m;
            else in_variaveisCalculo.IDHR = aa024Dados.Aa024IdhmR ?? 0.556m;

            var _ = in_variaveisCalculo.IDHR switch
            {
                >= 0.800m and <= 1.000m => in_variaveisCalculo.e_b = 1m,
                >= 0.700m and <= 0.799m => in_variaveisCalculo.e_b = 0.7m,
                >= 0.600m and <= 0.699m => in_variaveisCalculo.e_b = 0.6m,
                >= 0.500m and <= 0.599m => in_variaveisCalculo.e_b = 0.5m,
                >= 0.000m and <= 0.499m => in_variaveisCalculo.e_b = 0.4m,
                _ => in_variaveisCalculo.e_b
            };
        }

        private async Task<CSICP_Aa024?> GetIDHR(string? codigoCidade, string? logradouro, string? bairro, string? complemento)
        {

            var resultado =
                await (from aa024 in _appDbContext.OsusrE9aCsicpAa024s
                       where aa024.Aa028Id == codigoCidade &&
                             (
                                EF.Functions.Like(aa024.Aa024NomeUdh, "%" + logradouro + "%") ||
                                EF.Functions.Like(aa024.Aa024NomeUdh, "%" + bairro + "%") ||
                                EF.Functions.Like(aa024.Aa024NomeUdh, "%" + complemento + "%")
                             )
                       select new CSICP_Aa024
                       {
                           Aa024IdhmR = aa024.Aa024IdhmR,
                       })
                       .FirstOrDefaultAsync();

            return resultado;
        }

        private static void CS_DefinirRendaConta(AnaliseCreditoParametros in_variaveisCalculo, decimal? valorRemuneracao)
        {
            in_variaveisCalculo.Renda = valorRemuneracao ?? 0m;
        }

        private async Task<ListDtoAA001Json?> CS_Get_ParametrosAnaliseCredito(int in_tenantID)
        {
            var query = from aa001 in _appDbContext.OsusrE9aCsicpAa001s
                        where aa001.TenantId == in_tenantID && aa001.Aa001Identificacao == SiteProperties.DD001_ParmAnaliseCredito
                        select aa001.Aa001Json;

            var parametros = await query.FirstOrDefaultAsync();
            if (parametros == null) return null;
            ListDtoAA001Json? parametrosAnaliseCredito = JsonSerializer.Deserialize<ListDtoAA001Json>(parametros);
            return parametrosAnaliseCredito ?? null;
        }
        private class DtoAA001Json
        {
            public string Orientacao { get; set; } = string.Empty;
            public string Value { get; set; } = "";
            public int Item { get; set; }
            public string Descricao { get; set; } = "";
        }

        private class ListDtoAA001Json
        {
            public List<DtoAA001Json> Parametros_List { get; set; } = [];
        }

        private class ContaDadosDto
        {
            public CSICP_BB01202? Bb01202 { get; set; }
            public CSICP_BB012? Bb012 { get; set; }
            public CSICP_BB01206? Bb01206 { get; set; }
            public CSICP_BB01201? Bb01201 { get; set; }
        }
    }
}

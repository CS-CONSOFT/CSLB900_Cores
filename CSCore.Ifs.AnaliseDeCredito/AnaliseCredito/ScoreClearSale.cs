using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces;
using CSCore.Ifs.AnaliseDeCredito.ServicosExternos;
using CSCore.Ifs.AnaliseDeCredito.ServicosExternos.Dto;
using Refit;
using System.Text.Json;

namespace CSCore.Ifs.AnaliseDeCredito.NovaPasta
{
    public class ScoreClearSale(ITokenGenericoRepository tokenGenericoRepository)
    {
        private readonly ITokenGenericoRepository _tokenGenericoRepository = tokenGenericoRepository;
        public async Task<(string, string)> CS_ScoreClearSale(int in_tenantID, decimal? cpf)
        {
            CSICP_AA030? resultToken =
                await _tokenGenericoRepository.GetTokenGenericoPorLabel(Entities.AA030_TpToken.Clearsale, in_tenantID);

            var api = RestService.For<ICS_Clearsale_Api>("https://hmlproductsapi.clearsale.com.br");

            var dtoAutenticacao = new DtoAutenticacaoRequest
            {
                username = resultToken?.Aa030User ?? "",
                password = resultToken?.Aa030Senha ?? ""
            };
            DtoAutenticacaoResponse responseAuth = await api.Autenticar_ClearSale(dtoAutenticacao);

            var dtoVerificarScore = new DtoTransacaoRequest
            {
                document = cpf.ToString() ?? "",
                criterion = 15
            };
            DtoTransacaoResponse dtoTransacaoResponse = await api.VerificarScore(dtoVerificarScore, "Bearer " + responseAuth.token);

            ScoreItem? scoresFiltrados = dtoTransacaoResponse.Scores.Where(e => e.Name.Equals("Score v3")).FirstOrDefault();

            return (scoresFiltrados?.Value ?? "", JsonSerializer.Serialize(dtoTransacaoResponse));
        }
    }
}

using CSCore.Ifs.AnaliseDeCredito.ServicosExternos.Dto;
using Refit;

namespace CSCore.Ifs.AnaliseDeCredito.ServicosExternos
{
    public interface ICS_Clearsale_Api
    {
        [Post("/v1/authentication")]
        Task<DtoAutenticacaoResponse> Autenticar_ClearSale([Body] DtoAutenticacaoRequest dto);


        [Post("/v1/creditriskpro/transaction")]
        Task<DtoTransacaoResponse> VerificarScore([Body] DtoTransacaoRequest dto, [Header("Authorization")] string authorization);
    }
}

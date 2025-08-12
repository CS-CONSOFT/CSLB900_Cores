using CSCore.Ifs.FF.External.Parametros;
using CSLB900.MSTools.Util;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Interface.Impl
{
    public class BancoDoBrasilServiceBaseImpl(IRefitBancoBrasil refitBancoBrasil) : IBancoDoBrasilAuth
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;
        public async Task<string> ObterTokenAutenticacao(string in_tokenAutenticacao, string ggwdevappkey)
        {
            var apiAuthBBResponse = await _refitBancoBrasil.Auth(Authorization: in_tokenAutenticacao, gwdevappkey: ggwdevappkey);
            if (!apiAuthBBResponse.IsSuccessful)
                throw new Exception("Erro no login: " + HandlerExceptionMessage.CreateExceptionMessage(apiAuthBBResponse.Error));
            ReturnPostLogin retornoPostLogin = apiAuthBBResponse.Content;
            return "Bearer " + retornoPostLogin.access_token;
        }
    }
}

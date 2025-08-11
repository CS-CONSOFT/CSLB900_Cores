using CSCore.Ifs.FF.External;
using CSCore.Ifs.FF.External.Parametros;
using CSLB900.MSTools.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Auth
{
    public class AuthBancoBrasilImpl(IRefitBancoBrasil refitBancoBrasil) : IAuthBancoBrasil
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;
        public async Task<ReturnPostLogin> CS51_Auth_BancoBrasil(string in_tokenAutenticacao)
        {
            var apiAuthBBResponse = await _refitBancoBrasil.Auth(Authorization: in_tokenAutenticacao);
            if (!apiAuthBBResponse.IsSuccessful)
                throw new Exception("Erro no login: " + HandlerExceptionMessage.CreateExceptionMessage(apiAuthBBResponse.Error));
            ReturnPostLogin retornoPostLogin = apiAuthBBResponse.Content;
            return retornoPostLogin;
        }
    }
}

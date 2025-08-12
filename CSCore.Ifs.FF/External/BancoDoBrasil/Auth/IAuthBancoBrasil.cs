using CSCore.Ifs.FF.External.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Auth
{
    public interface IAuthBancoBrasil
    {
        Task<ReturnPostLogin> CS51_Auth_BancoBrasil(string in_tokenAutenticacao);
    }
}

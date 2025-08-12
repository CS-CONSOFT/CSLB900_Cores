using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Interface
{
    public interface IBancoDoBrasilAuth
    {
        Task<string> ObterTokenAutenticacao(string estabAuthToken);
    }
}

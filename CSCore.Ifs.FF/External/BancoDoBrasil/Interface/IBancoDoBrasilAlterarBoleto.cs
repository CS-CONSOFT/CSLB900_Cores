using CSCore.Ifs.FF.External.Parametros;
using CSCore.Ifs.FF.External.Retornos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Interface
{
    public interface IBancoDoBrasilAlterarBoleto : IBancoDoBrasilAuth
    {
        Task<AlterarBoletoBancarioResponse> AlterarBoletoBancario(
            string id,
            string appKey,
            string authorization,
             AlteraBoletoRequest requisicao
        );
    }
}

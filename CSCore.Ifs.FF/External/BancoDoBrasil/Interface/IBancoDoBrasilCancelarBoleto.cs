using CSCore.Ifs.FF.External.Parametros;
using CSCore.Ifs.FF.External.Retornos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Interface
{
    public interface IBancoDoBrasilCancelarBoleto : IBancoDoBrasilAuth
    {
        Task<RespostaBaixaBoleto> CancelarBoletoMethod(
            string gwdevappkey,
            string estabAuthToken,
            string idBoleto,
            int numeroConvenio,
            RequisicaoBaixaBoleto requisicao);
    }
}

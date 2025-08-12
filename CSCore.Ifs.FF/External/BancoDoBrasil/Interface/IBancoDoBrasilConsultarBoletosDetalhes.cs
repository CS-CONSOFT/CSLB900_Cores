using CSCore.Ifs.FF.External.Retornos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Interface
{
    public interface IBancoDoBrasilConsultarBoletosDetalhes : IBancoDoBrasilAuth
    {
        Task<RetornoConsultarBoleto> ConsultarBoletosDetalhes(string gwdevappkey,
            string estabAuthToken, string idBoleto, int in_numeroConvenio);
    }
}

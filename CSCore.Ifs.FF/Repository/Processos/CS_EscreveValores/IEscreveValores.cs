using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_EscreveValores
{
    public interface IEscreveValores
    {
        Task<bool> Executar(PrmEscreveValores InPrmEscreveValores);
    }
}

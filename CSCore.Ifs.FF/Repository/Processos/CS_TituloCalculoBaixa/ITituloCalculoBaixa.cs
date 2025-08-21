using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa
{
    public interface ITituloCalculoBaixa
    {
        Task<bool> Executar(PrmEntradaCalculoBaixa InPrmEntradaCalculo);
    }
}

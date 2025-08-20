using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloEstornar
{
    public interface IMovtoTituloEstornar
    {
        Task<bool> Executar(string InFF103ID, int InTenantID);
    }
}

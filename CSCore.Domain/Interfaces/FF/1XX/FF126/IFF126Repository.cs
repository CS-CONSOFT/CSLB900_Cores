using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Domain.Interfaces.FF._1XX.FF126
{
    public interface IFF126Repository
    {
        Task<CSICP_FF126?> GetFF126PeloTituloFF102(int InTenantID, string InFF102_ID);
    }
}

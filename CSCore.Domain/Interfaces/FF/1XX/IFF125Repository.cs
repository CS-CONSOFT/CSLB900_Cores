using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.PrmFiltros.FF125;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    
    public interface IFF125Repository
    {
        Task<List<CSICP_FF125>> GetListAsync(int InTenantID,PrmFiltrosFF125 InPrmFiltrosFF125);
    }

  
}

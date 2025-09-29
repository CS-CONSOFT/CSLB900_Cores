using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX.FF140
{
    public interface IFF140Repository : IGetListBase<CSICP_FF140, PrmFiltrosFF140Repo>, IRepositorioBase<CSICP_FF140>
    {
        Task<CSICP_FF140?> GetByIdAsync(int InTenantID, long InFF140ID);
    }
}

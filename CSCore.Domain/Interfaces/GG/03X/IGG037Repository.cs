using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Domain.Interfaces.GG._03X
{
    public interface IGG037Repository
    {
        Task<(IEnumerable<CSICP_GG037>, int)> GetListAsync(int tenant, string IDInventario,int pageSize, int page);
    }
}

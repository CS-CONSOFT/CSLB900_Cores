using CSCore.Domain.CS_Models.CSICP_AA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA143Repository
    {
        Task<(List<CSICP_AA143>, int)> GetListAsync(int in_pageSize, int in_pageNumber);
    }
}

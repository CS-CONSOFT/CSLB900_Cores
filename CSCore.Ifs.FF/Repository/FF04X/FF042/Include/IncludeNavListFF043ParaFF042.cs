using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF042.Include
{
    internal class IncludeNavListFF043ParaFF042 : ICSInclude<CSICP_FF042>
    {
        public IQueryable<CSICP_FF042> ApplyIncludes(IQueryable<CSICP_FF042> query)
        {
            return query.Include(e => e.NavListFF043);
        }
    }
}

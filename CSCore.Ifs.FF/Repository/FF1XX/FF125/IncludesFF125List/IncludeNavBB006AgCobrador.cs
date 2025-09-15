using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF125.IncludesFF125List
{
    internal class IncludeNavBB006AgCobrador : ICSInclude<CSICP_FF125>
    {
        public IQueryable<CSICP_FF125> ApplyIncludes(IQueryable<CSICP_FF125> query)
        {
            return query.Include(e => e.NavBB006AgCobrador);
        }
    }
}

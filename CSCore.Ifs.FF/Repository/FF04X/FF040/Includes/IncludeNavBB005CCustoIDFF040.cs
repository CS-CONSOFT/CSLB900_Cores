using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Includes
{
    internal class IncludeNavBB005CCustoIDFF040 : ICSInclude<CSICP_FF040>
    {
        public IQueryable<CSICP_FF040> ApplyIncludes(IQueryable<CSICP_FF040> query)
        {
            return query.Include(e => e.NavBB005CCustoID);
        }
    }
}

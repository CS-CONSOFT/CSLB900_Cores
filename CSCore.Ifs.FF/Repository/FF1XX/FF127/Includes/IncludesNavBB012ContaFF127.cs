using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127.Includes
{
    internal class IncludesNavBB012ContaFF127 : ICSInclude<CSICP_FF127>
    {
        public IQueryable<CSICP_FF127> ApplyIncludes(IQueryable<CSICP_FF127> query)
        {
           return query.Include(e => e.NavBB012Conta);  
        }
    }
}

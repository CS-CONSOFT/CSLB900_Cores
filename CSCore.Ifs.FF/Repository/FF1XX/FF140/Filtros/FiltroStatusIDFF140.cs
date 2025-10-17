using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF140.Filtros
{
    internal class FiltroStatusIDFF140 : ICSFilter<CSICP_FF140>
    {
        private readonly int? _statusID;
        public FiltroStatusIDFF140(int? statusID)
        {
            _statusID = statusID;
        }
        public IQueryable<CSICP_FF140> Apply(IQueryable<CSICP_FF140> query)
        {
            if (_statusID.HasValue)
            {
                query = query.Where(e => e.Ff140Statusid == _statusID.Value);
            }
            return query;
        }
    }
}

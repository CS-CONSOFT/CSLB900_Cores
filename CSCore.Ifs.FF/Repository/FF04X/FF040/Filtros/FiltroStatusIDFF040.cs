using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros
{
    internal class FiltroStatusIDFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly int? _statusID;
        public FiltroStatusIDFF040(int? statusID)
        {
            _statusID = statusID;
        }
        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (_statusID.HasValue)
            {
                query = query.Where(e => e.Ff040Situacaoid == _statusID);
            }
            return query;
        }
    }
}

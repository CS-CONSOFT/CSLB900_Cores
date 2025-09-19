using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040
{
    internal class FiltroEstabIDFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly string? _estabID;

        public FiltroEstabIDFF040(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Ff040Empresaid == _estabID);
            }
            return query;
        }
    }
}

using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X.CG000.Filtros
{
    internal class FiltroEstabIDCG000 : ICSFilter<CSICP_CG000>
    {
        private readonly string? _estabID;

        public FiltroEstabIDCG000(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_CG000> Apply(IQueryable<CSICP_CG000> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Cg000Filialid == _estabID);
            }
            return query;
        }
    }
}

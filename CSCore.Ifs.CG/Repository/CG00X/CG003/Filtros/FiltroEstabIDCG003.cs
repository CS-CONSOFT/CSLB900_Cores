using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X.CG003.Filtros
{
    internal class FiltroEstabIDCG003 : ICSFilter<CSICP_CG003>
    {
        private readonly string? _estabID;

        public FiltroEstabIDCG003(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_CG003> Apply(IQueryable<CSICP_CG003> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Cg003FilialId == _estabID);
            }
            return query;
        }
    }
}

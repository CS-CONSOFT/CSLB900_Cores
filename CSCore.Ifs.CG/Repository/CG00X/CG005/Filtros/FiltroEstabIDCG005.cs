using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG005.Filtros
{
    internal class FiltroEstabIDCG005 : ICSFilter<CSICP_CG005>
    {
        private readonly string? _estabID;

        public FiltroEstabIDCG005(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_CG005> Apply(IQueryable<CSICP_CG005> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Cg005FilialId == _estabID);
            }
            return query;
        }
    }
}
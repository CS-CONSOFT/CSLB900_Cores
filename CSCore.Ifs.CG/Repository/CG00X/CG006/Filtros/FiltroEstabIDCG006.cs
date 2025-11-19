using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG006.Filtros
{
    internal class FiltroEstabIDCG006 : ICSFilter<CSICP_CG006>
    {
        private readonly string? _estabID;

        public FiltroEstabIDCG006(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_CG006> Apply(IQueryable<CSICP_CG006> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Cg006FilialId == _estabID);
            }
            return query;
        }
    }
}
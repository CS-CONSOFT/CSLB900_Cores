using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG009.Filtros
{
    internal class FiltroEstabIDCG009 : ICSFilter<CSICP_CG009>
    {
        private readonly string? _estabID;

        public FiltroEstabIDCG009(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_CG009> Apply(IQueryable<CSICP_CG009> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Cg009FilialId == _estabID);
            }
            return query;
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG020.Filtros
{
    public class FiltroFilialIdCG020 : ICSFilter<CSICP_CG020>
    {
        private readonly string? _estabID;

        public FiltroFilialIdCG020(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_CG020> Apply(IQueryable<CSICP_CG020> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Cg020FilialId == _estabID);
            }
            return query;
        }
    }
}
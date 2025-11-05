using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG021.Filtros
{
    public class FiltroFilialIdCG021 : ICSFilter<Osusr8dwCsicpCg021>
    {
        private readonly string _filialId;

        public FiltroFilialIdCG021(string filialId)
        {
            _filialId = filialId;
        }
        public IQueryable<Osusr8dwCsicpCg021> Apply(IQueryable<Osusr8dwCsicpCg021> query)
        {
            if (!string.IsNullOrEmpty(_filialId))
            {
                query = query.Where(e => e.Cg021FilialId == _filialId);
            }
            return query;
        }
    }
}
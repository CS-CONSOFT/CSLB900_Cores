using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG021.Filtros
{
    public class FiltroLoteIdCG021 : ICSFilter<Osusr8dwCsicpCg021>
    {
        private readonly string _loteId;

        public FiltroLoteIdCG021(string loteId)
        {
            _loteId = loteId;
        }

        public IQueryable<Osusr8dwCsicpCg021> Apply(IQueryable<Osusr8dwCsicpCg021> query)
        {
            if (!string.IsNullOrEmpty(_loteId))
            {
                query = query.Where(e => e.Cg021LoteId == _loteId);
            }
            return query;
        }
    }
}
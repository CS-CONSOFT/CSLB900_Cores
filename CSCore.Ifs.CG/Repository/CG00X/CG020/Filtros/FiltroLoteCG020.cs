using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG020.Filtros
{
    public class FiltroLoteCG020 : ICSFilter<CSICP_CG020>
    {
        private readonly int? _lote;

        public FiltroLoteCG020(int? lote)
        {
            _lote = lote;
        }

        public IQueryable<CSICP_CG020> Apply(IQueryable<CSICP_CG020> query)
        {
            if (_lote.HasValue)
            {
                query = query.Where(e => e.Cg020Lote == _lote.Value);
            }
            return query;
        }
    }
}
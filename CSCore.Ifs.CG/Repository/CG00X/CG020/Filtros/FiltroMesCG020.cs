using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using NPOI.SS.Formula.Functions;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG020.Filtros
{
    public class FiltroMesCG020 : ICSFilter<CSICP_CG020>
    {
        private readonly int? _mes;

        public FiltroMesCG020(int? mes)
        {
            _mes = mes;
        }

        public IQueryable<CSICP_CG020> Apply(IQueryable<CSICP_CG020> query)
        {
            if (_mes.HasValue)
            {
                query = query.Where(e => e.Cg020Mes == _mes.Value);
            }
            return query;
        }
    }
}
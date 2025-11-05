using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG021.Filtros
{
    public class FiltroDataCG021 : ICSFilter<Osusr8dwCsicpCg021>
    {
        private readonly DateTime? _dataInicio;
        private readonly DateTime? _dataFinal;

        public FiltroDataCG021(DateTime? dataInicio, DateTime? dataFinal)
        {
            _dataInicio = dataInicio;
            _dataFinal = dataFinal;
        }

        public IQueryable<Osusr8dwCsicpCg021> Apply(IQueryable<Osusr8dwCsicpCg021> query)
        {
            if (_dataInicio.HasValue)
            {
                query = query.Where(e => e.Cg021Data >= _dataInicio.Value);
            }

            if (_dataFinal.HasValue)
            {
                query = query.Where(e => e.Cg021Data <= _dataFinal.Value);
            }

            return query;
        }
    }
}
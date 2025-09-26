using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros
{
    internal class FiltroDataMovtFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly DateTime? _dataInicio;
        private readonly DateTime? _dataFim;

        public FiltroDataMovtFF040(DateTime? dataInicio, DateTime? dataFim)
        {
            _dataInicio = dataInicio;
            _dataFim = dataFim;
        }

        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (_dataInicio.HasValue)
            {
                query = query.Where(e => e.Ff040DataMovimento >= _dataInicio.Value);
            }
            
            if (_dataFim.HasValue)
            {
                query = query.Where(e => e.Ff040DataMovimento <= _dataFim.Value);
            }
            
            return query;
        }
    }
}
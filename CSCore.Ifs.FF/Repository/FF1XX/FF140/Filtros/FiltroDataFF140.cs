using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF140.Filtros
{
    internal class FiltroDataFF140 : ICSFilter<CSICP_FF140>
    {
        private readonly DateTime? _dataInicio;
        private readonly DateTime? _dataFinal;
        public FiltroDataFF140(DateTime? dataInicio , DateTime? dataFinal)
        {
            _dataInicio = dataInicio;
            _dataFinal = dataFinal;
        }
        public IQueryable<CSICP_FF140> Apply(IQueryable<CSICP_FF140> query)
        {
            if (_dataInicio.HasValue)
            {
                query = query.Where(e => e.Ff140Data >= _dataInicio.Value);
            }
            if (_dataFinal.HasValue)
            {
                query = query.Where(e => e.Ff140Data <= _dataFinal.Value);
            }
            return query;
        }
    }
}

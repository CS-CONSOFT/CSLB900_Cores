using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF140.Filtros
{
    internal class FiltroContaIDFF140 : ICSFilter<CSICP_FF140>
    {
        private readonly string? _contaID;
        public FiltroContaIDFF140(string? contaID)
        {
            _contaID = contaID;
        }
        public IQueryable<CSICP_FF140> Apply(IQueryable<CSICP_FF140> query)
        {
            if (!string.IsNullOrEmpty(_contaID))
            {
                query = query.Where(e => e.Ff140Contaid == _contaID);
            }
            return query;
        }
    }
}

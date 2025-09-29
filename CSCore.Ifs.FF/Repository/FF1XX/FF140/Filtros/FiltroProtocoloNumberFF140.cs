using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF140.Filtros
{
    internal class FiltroProtocoloNumberFF140 : ICSFilter<CSICP_FF140>
    {
        private readonly string? _protocoloNumber;
        public FiltroProtocoloNumberFF140(string? protocoloNumber)
        {
            _protocoloNumber = protocoloNumber;
        }
        public IQueryable<CSICP_FF140> Apply(IQueryable<CSICP_FF140> query)
        {
            if (!string.IsNullOrEmpty(_protocoloNumber))
            {
                query = query.Where(e => e.Ff140Protocolnumber == _protocoloNumber);
            }
            return query;
        }
    }
}

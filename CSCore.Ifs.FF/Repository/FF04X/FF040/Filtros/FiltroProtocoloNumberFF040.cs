using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros
{
    internal class FiltroProtocoloNumberFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly string? _protocoloNumber;

        public FiltroProtocoloNumberFF040(string? protocoloNumber)
        {
            _protocoloNumber = protocoloNumber;
        }

        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (!string.IsNullOrEmpty(_protocoloNumber))
            {
                query = query.Where(e => e.Ff040Protocolnumber == _protocoloNumber);
            }
            return query;
        }
    }
}
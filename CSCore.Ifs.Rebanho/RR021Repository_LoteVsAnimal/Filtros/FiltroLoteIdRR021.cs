using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.Filtros
{
    internal class FiltroLoteIdRR021 : ICSFilter<OsusrTo3CsicpRr021>
    {
        private readonly string? _loteId;
        public FiltroLoteIdRR021(string? loteId)
        {
            _loteId = loteId;
        }
        public IQueryable<OsusrTo3CsicpRr021> Apply(IQueryable<OsusrTo3CsicpRr021> query)
        {
            if (!string.IsNullOrEmpty(_loteId))
            {
                query = query.Where(e => e.Rr021Loteid == _loteId);
            }
            return query;
        }
    }
}

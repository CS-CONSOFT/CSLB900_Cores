using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros
{
    public class FiltroLoteIdRR022 : ICSFilter<OsusrTo3CsicpRr022>
    {
        private readonly string? _loteId;

        public FiltroLoteIdRR022(string? loteId)
        {
            _loteId = loteId;
        }

        public IQueryable<OsusrTo3CsicpRr022> Apply(IQueryable<OsusrTo3CsicpRr022> query)
        {
            if (!string.IsNullOrWhiteSpace(_loteId))
            {
                query = query.Where(e => e.Rr022Loteid == _loteId);
            }

            return query;
        }
    }
}
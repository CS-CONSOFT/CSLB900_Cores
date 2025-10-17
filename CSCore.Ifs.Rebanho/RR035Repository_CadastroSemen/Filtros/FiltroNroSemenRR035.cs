using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR035Repository_CadastroSemen.Filtros
{
    public class FiltroNroSemenRR035 : ICSFilter<OsusrTo3CsicpRr035>
    {
        private readonly string? _nroSemen;

        public FiltroNroSemenRR035(string? nroSemen)
        {
            _nroSemen = nroSemen;
        }

        public IQueryable<OsusrTo3CsicpRr035> Apply(IQueryable<OsusrTo3CsicpRr035> query)
        {
            if (!string.IsNullOrWhiteSpace(_nroSemen))
            {
                query = query.Where(e => e.Rr035Nrosemem != null && e.Rr035Nrosemem.Contains(_nroSemen));
            }
            return query;
        }
    }
}
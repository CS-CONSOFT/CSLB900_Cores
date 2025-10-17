using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR031Repository_RegistroControleGestacao.Filtros
{
    public class FiltroIATFRR030IdRR031 : ICSFilter<OsusrTo3CsicpRr031>
    {
        private readonly string? _iatfId;

        public FiltroIATFRR030IdRR031(string? iatfId)
        {
            _iatfId = iatfId;
        }

        public IQueryable<OsusrTo3CsicpRr031> Apply(IQueryable<OsusrTo3CsicpRr031> query)
        {
            if (!string.IsNullOrWhiteSpace(_iatfId))
            {
                query = query.Where(e => e.Rr031IatfId == _iatfId);
            }
            return query;
        }
    }
}
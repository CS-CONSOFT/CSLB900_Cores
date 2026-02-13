using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR031Repository_RegistroControleGestacao.Filtros
{
    public class FiltroTiporegRR031 : ICSFilter<OsusrTo3CsicpRr031>
    {
        private readonly int? _tiporeg;

        public FiltroTiporegRR031(int? tiporeg)
        {
            _tiporeg = tiporeg;
        }

        public IQueryable<OsusrTo3CsicpRr031> Apply(IQueryable<OsusrTo3CsicpRr031> query)
        {
            if (_tiporeg.HasValue)
            {
                query = query.Where(e => e.Rr031Tiporeg == _tiporeg.Value);
            }
            return query;
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR004Repository_Raca.Filtros
{
    internal class FiltroRacaRR004 : ICSFilter<OsusrTo3CsicpRr004>
    {
        private readonly string? _raca;

        public FiltroRacaRR004(string? raca)
        {
            _raca = raca;
        }

        public IQueryable<OsusrTo3CsicpRr004> Apply(IQueryable<OsusrTo3CsicpRr004> query)
        {
            if (!string.IsNullOrEmpty(_raca))
            {
                query = query.Where(e => e.Rr004Raca != null && 
                                         e.Rr004Raca.Contains(_raca));
            }
            return query;
        }
    }
}
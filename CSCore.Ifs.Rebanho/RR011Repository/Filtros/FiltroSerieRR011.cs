using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using System.Linq.Expressions;

namespace CSCore.Ifs.Rebanho.RR011Repository.Filtros
{
    public class FiltroSerieRR011 : ICSFilter<OsusrTo3CsicpRr011>
    {
        private readonly string? _serie;

        public FiltroSerieRR011(string? serie)
        {
            _serie = serie;
        }

        public IQueryable<OsusrTo3CsicpRr011> Apply(IQueryable<OsusrTo3CsicpRr011> query)
        {
            if (!string.IsNullOrEmpty(_serie))
            {
                query = query.Where(e => e.Rr011Serie != null && e.Rr011Serie.Contains(_serie));
            }
            return query;
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using System.Linq.Expressions;

namespace CSCore.Ifs.Rebanho.RR011Repository.Filtros
{
    public class FiltroUltRgnRR011 : ICSFilter<OsusrTo3CsicpRr011>
    {
        private readonly int? _ultRgn;

        public FiltroUltRgnRR011(int? ultRgn)
        {
            _ultRgn = ultRgn;
        }

        public IQueryable<OsusrTo3CsicpRr011> Apply(IQueryable<OsusrTo3CsicpRr011> query)
        {
            if (_ultRgn.HasValue)
            {
                query = query.Where(e => e.Rr011Ultrgn == _ultRgn.Value);
            }
            return query;
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using System.Linq.Expressions;

namespace CSCore.Ifs.Rebanho.RR010Repository.Filtros
{
    public class FiltroDescritivoRR010 : ICSFilter<OsusrTo3CsicpRr010>
    {
        private readonly string? _descritivo;

        public FiltroDescritivoRR010(string? descritivo)
        {
            _descritivo = descritivo;
        }

        public IQueryable<OsusrTo3CsicpRr010> Apply(IQueryable<OsusrTo3CsicpRr010> query)
        {
            if (!string.IsNullOrEmpty(_descritivo))
            {
                query = query.Where(e => e.Rr010Descritivo != null && e.Rr010Descritivo == _descritivo);
            }
            return query;
        }
    }
}
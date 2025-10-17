using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.Filtros
{
    internal class FiltroDtRegistroRR021 : ICSFilter<OsusrTo3CsicpRr021>
    {
        private readonly DateTime? _dtInicio;
        private readonly DateTime? _dtFim;

        public FiltroDtRegistroRR021(DateTime? dtInicio, DateTime? dtFim)
        {
            _dtInicio = dtInicio;
            _dtFim = dtFim;
        }

        public IQueryable<OsusrTo3CsicpRr021> Apply(IQueryable<OsusrTo3CsicpRr021> query)
        {
            if (_dtInicio.HasValue)
            {
                query = query.Where(e => e.Rr021Dtregistro >= _dtInicio);
            }

            if (_dtFim.HasValue)
            {
                query = query.Where(e => e.Rr021Dtregistro <= _dtFim);
            }

            return query;
        }
    }
}
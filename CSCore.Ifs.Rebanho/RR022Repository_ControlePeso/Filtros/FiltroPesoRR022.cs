using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros
{
    internal class FiltroPesoRR022 : ICSFilter<OsusrTo3CsicpRr022>
    {
        private readonly decimal? _pesoMinimo;
        private readonly decimal? _pesoMaximo;

        public FiltroPesoRR022(decimal? pesoMinimo, decimal? pesoMaximo)
        {
            _pesoMinimo = pesoMinimo;
            _pesoMaximo = pesoMaximo;
        }

        public IQueryable<OsusrTo3CsicpRr022> Apply(IQueryable<OsusrTo3CsicpRr022> query)
        {
            if (_pesoMinimo.HasValue)
            {
                query = query.Where(e => e.Rr022Peso >= _pesoMinimo);
            }

            if (_pesoMaximo.HasValue)
            {
                query = query.Where(e => e.Rr022Peso <= _pesoMaximo);
            }

            return query;
        }
    }
}
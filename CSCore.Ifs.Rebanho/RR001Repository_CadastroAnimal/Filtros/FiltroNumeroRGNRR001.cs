using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Repository;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroNumeroRGNRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly int? _numeroRGN;

        public FiltroNumeroRGNRR001(int? numeroRGN)
        {
            _numeroRGN = numeroRGN;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (_numeroRGN.HasValue)
            {
                query = query.Where(e => e.Rr001Nrorgn == _numeroRGN.Value);
            }
            return query;
        }
    }
}
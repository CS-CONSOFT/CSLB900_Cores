using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros
{
    internal class FiltroAnimalIdRR022 : ICSFilter<OsusrTo3CsicpRr022>
    {
        private readonly string? _animalId;

        public FiltroAnimalIdRR022(string? animalId)
        {
            _animalId = animalId;
        }

        public IQueryable<OsusrTo3CsicpRr022> Apply(IQueryable<OsusrTo3CsicpRr022> query)
        {
            if (!string.IsNullOrEmpty(_animalId))
            {
                query = query.Where(e => e.Rr022Animalid == _animalId);
            }
            return query;
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.Filtros
{
    internal class FiltroAnimalIdRR021 : ICSFilter<OsusrTo3CsicpRr021>
    {
        private readonly string? _animalId;

        public FiltroAnimalIdRR021(string? animalId)
        {
            _animalId = animalId;
        }

        public IQueryable<OsusrTo3CsicpRr021> Apply(IQueryable<OsusrTo3CsicpRr021> query)
        {
            if (!string.IsNullOrEmpty(_animalId))
            {
                query = query.Where(e => e.Rr021Animalid == _animalId);
            }
            return query;
        }
    }
}
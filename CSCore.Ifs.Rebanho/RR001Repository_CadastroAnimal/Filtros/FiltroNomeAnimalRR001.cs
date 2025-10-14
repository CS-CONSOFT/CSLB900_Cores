using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Repository;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroNomeAnimalRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly string? _nomeAnimal;

        public FiltroNomeAnimalRR001(string? nomeAnimal)
        {
            _nomeAnimal = nomeAnimal;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (!string.IsNullOrEmpty(_nomeAnimal))
            {
                query = query.Where(e => e.Rr001Nomeanimal != null && 
                                         e.Rr001Nomeanimal.Contains(_nomeAnimal));
            }
            return query;
        }
    }
}
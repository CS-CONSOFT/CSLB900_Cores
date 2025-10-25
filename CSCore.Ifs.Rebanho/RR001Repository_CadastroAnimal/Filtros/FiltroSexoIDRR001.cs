using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroSexoIDRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly int? _sexoID;

        public FiltroSexoIDRR001(int? sexoID)
        {
            _sexoID = sexoID;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (_sexoID.HasValue)
            {
                query = query.Where(e => e.Rr001Sexoid == _sexoID.Value);
            }
            return query;
        }
    }
}
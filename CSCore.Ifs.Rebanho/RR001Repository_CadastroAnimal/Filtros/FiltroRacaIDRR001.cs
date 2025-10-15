using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroRacaIDRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly long? _racaID;

        public FiltroRacaIDRR001(long? racaID)
        {
            _racaID = racaID;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (_racaID.HasValue)
            {
                query = query.Where(e => e.Rr001Racaid == _racaID.Value);
            }
            return query;
        }
    }
}
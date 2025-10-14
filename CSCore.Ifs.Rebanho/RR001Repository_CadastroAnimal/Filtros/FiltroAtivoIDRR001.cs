using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Repository;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroAtivoIDRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly int? _ativoID;

        public FiltroAtivoIDRR001(int? ativoID)
        {
            _ativoID = ativoID;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (_ativoID.HasValue)
            {
                query = query.Where(e => e.Rr001Ativoid == _ativoID.Value);
            }
            return query;
        }
    }
}
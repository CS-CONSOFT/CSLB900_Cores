using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroSituacaoIDRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly long? _situacaoID;

        public FiltroSituacaoIDRR001(long? situacaoID)
        {
            _situacaoID = situacaoID;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (_situacaoID.HasValue)
            {
                query = query.Where(e => e.Rr001Situacaoid == _situacaoID.Value);
            }
            return query;
        }
    }
}
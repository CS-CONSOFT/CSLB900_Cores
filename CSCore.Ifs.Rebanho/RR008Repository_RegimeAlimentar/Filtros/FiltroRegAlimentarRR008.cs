using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR008Repository_RegimeAlimentar.Filtros
{
    internal class FiltroRegAlimentarRR008 : ICSFilter<OsusrTo3CsicpRr008>
    {
        private readonly string? _regAlimentar;

        public FiltroRegAlimentarRR008(string? regAlimentar)
        {
            _regAlimentar = regAlimentar;
        }

        public IQueryable<OsusrTo3CsicpRr008> Apply(IQueryable<OsusrTo3CsicpRr008> query)
        {
            if (!string.IsNullOrEmpty(_regAlimentar))
            {
                query = query.Where(e => e.Rr008Regalimentar != null && 
                                         e.Rr008Regalimentar.Contains(_regAlimentar));
            }
            return query;
        }
    }
}
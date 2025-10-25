using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace FF105Financeiro.C82Application.Service.FF1XX.FF125
{
    internal class FiltroSitCtaIdFF127 : ICSFilter<CSICP_FF125>
    {
        private readonly int? _sitCtaId;
        public FiltroSitCtaIdFF127(int? sitCtaId)
        {
            _sitCtaId = sitCtaId;
        }
        public IQueryable<CSICP_FF125> Apply(IQueryable<CSICP_FF125> query)
        {
           if (!_sitCtaId.HasValue)
                return query;
            return query.Where(e => e.Ff125Sitcobranca == _sitCtaId);
        }
    }
}

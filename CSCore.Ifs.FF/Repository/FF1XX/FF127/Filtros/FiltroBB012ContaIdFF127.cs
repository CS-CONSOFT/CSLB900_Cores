using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127.Filtros
{
    internal class FiltroBB012ContaIdFF127 : ICSFilter<CSICP_FF127>
    {
        private readonly string? _bb012ContaID;
        public FiltroBB012ContaIdFF127(string? bb012ContaID)
        {
            _bb012ContaID = bb012ContaID;
        }
        public IQueryable<CSICP_FF127> Apply(IQueryable<CSICP_FF127> query)
        {
            if (!string.IsNullOrEmpty(_bb012ContaID))
            {
                query = query.Where(e => e.Ff127ContaId == _bb012ContaID);
            }
            return query;
        }
    }
}

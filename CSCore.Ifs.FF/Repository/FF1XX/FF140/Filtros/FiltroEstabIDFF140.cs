using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF140.Filtros
{
    internal class FiltroEstabIDFF140 : ICSFilter<CSICP_FF140>
    {
        private readonly string? _estabID;
        public FiltroEstabIDFF140(string? estabID)
        {
            _estabID = estabID;
        }

        public IQueryable<CSICP_FF140> Apply(IQueryable<CSICP_FF140> query)
        {
            if (!string.IsNullOrEmpty(_estabID))
            {
                query = query.Where(e => e.Ff140Estabid == _estabID);
            }
            return query;
        }
    }
}

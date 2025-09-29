using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF140.Filtros
{
    internal class FiltroEstabIDFF140
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
                //query = query.Where(e => e.Ff140Empresaid == _estabID);
            }
            return query;
        }
    }
}

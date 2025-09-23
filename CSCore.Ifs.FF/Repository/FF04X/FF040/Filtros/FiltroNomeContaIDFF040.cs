using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros
{
    internal class FiltroNomeContaIDFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly string? _nomeContaID;

        public FiltroNomeContaIDFF040(string nomeContaID)
        {
            _nomeContaID = nomeContaID;
        }

        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (!string.IsNullOrEmpty(_nomeContaID))
            {
                query = query.Where(e => e.Ff040ContaId == _nomeContaID);
            }
            return query;
        }
    }
}
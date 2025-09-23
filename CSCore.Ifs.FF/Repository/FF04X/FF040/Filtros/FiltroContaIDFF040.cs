using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros
{
    internal class FiltroContaIDFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly string? _contaID;

        public FiltroContaIDFF040(string? contaID)
        {
            _contaID = contaID;
        }

        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (!string.IsNullOrEmpty(_contaID))
            {
                query = query.Where(e => e.Ff040ContaId == _contaID);
            }
            return query;
        }
    }
}
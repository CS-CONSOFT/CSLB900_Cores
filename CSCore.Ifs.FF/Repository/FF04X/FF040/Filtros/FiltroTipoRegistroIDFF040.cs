using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros
{
    public class FiltroTipoRegistroIDFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly int? _InTipoRegistroID;
        public FiltroTipoRegistroIDFF040(int? tipoRegistroID)
        {
            _InTipoRegistroID = tipoRegistroID;
        }
        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (_InTipoRegistroID.HasValue)
            {
                query = query.Where(e => e.Ff040Tiporegistro == _InTipoRegistroID.Value);
            }
            return query;
        }
    }
}

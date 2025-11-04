using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG009.Filtros
{
    internal class FiltroMesCG009 : ICSFilter<CSICP_CG009>
    {
        private readonly int? _mes;

        public FiltroMesCG009(int? mes)
        {
            _mes = mes;
        }

        public IQueryable<CSICP_CG009> Apply(IQueryable<CSICP_CG009> query)
        {
            if (_mes.HasValue)
            {
                query = query.Where(e => e.Cg009Mes == _mes.Value);
            }
            return query;
        }
    }
}
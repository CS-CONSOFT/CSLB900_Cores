using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG009.Filtros
{
    internal class FiltroContaIdCG009 : ICSFilter<CSICP_CG009>
    {
        private readonly string? _contaId;

        public FiltroContaIdCG009(string? contaId)
        {
            _contaId = contaId;
        }

        public IQueryable<CSICP_CG009> Apply(IQueryable<CSICP_CG009> query)
        {
            if (!string.IsNullOrEmpty(_contaId))
            {
                query = query.Where(e => e.Cg009ContaId == _contaId);
            }
            return query;
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG005.Filtros
{
    internal class FiltroHistoricoCG005 : ICSFilter<CSICP_CG005>
    {
        private readonly string? _historico;

        public FiltroHistoricoCG005(string? historico)
        {
            _historico = historico;
        }

        public IQueryable<CSICP_CG005> Apply(IQueryable<CSICP_CG005> query)
        {
            if (!string.IsNullOrEmpty(_historico))
            {
                query = query.Where(e => e.Cg005Historico != null && 
                                         e.Cg005Historico.Contains(_historico));
            }
            return query;
        }
    }
}
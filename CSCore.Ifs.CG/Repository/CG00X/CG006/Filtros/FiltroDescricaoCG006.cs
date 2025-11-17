using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG006.Filtros
{
    internal class FiltroDescricaoCG006 : ICSFilter<CSICP_CG006>
    {
        private readonly string? _descricao;

        public FiltroDescricaoCG006(string? descricao)
        {
            _descricao = descricao;
        }

        public IQueryable<CSICP_CG006> Apply(IQueryable<CSICP_CG006> query)
        {
            if (!string.IsNullOrEmpty(_descricao))
            {
                query = query.Where(e => e.Cg006Descricao != null && 
                                         e.Cg006Descricao.Contains(_descricao));
            }
            return query;
        }
    }
}
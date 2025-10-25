using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR003Repository_Cat.Filtros
{
    internal class FiltroDescricaoRR003 : ICSFilter<OsusrTo3CsicpRr003>
    {
        private readonly string? _descricao;

        public FiltroDescricaoRR003(string? descricao)
        {
            _descricao = descricao;
        }

        public IQueryable<OsusrTo3CsicpRr003> Apply(IQueryable<OsusrTo3CsicpRr003> query)
        {
            if (!string.IsNullOrEmpty(_descricao))
            {
                query = query.Where(e => e.Rr003Descricao != null && 
                                         e.Rr003Descricao.Contains(_descricao));
            }
            return query;
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR035Repository_CadastroSemen.Filtros
{
    public class FiltroDescricaoRR035 : ICSFilter<OsusrTo3CsicpRr035>
    {
        private readonly string? _descricao;

        public FiltroDescricaoRR035(string? descricao)
        {
            _descricao = descricao;
        }

        public IQueryable<OsusrTo3CsicpRr035> Apply(IQueryable<OsusrTo3CsicpRr035> query)
        {
            if (!string.IsNullOrWhiteSpace(_descricao))
            {
                query = query.Where(e => e.Rr035Descricao != null && e.Rr035Descricao.Contains(_descricao));
            }
            return query;
        }
    }
}
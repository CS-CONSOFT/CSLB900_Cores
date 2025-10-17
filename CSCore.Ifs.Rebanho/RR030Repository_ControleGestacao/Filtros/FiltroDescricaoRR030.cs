using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR030Repository_ControleGestacao.Filtros
{
    internal class FiltroDescricaoRR030 : ICSFilter<OsusrTo3CsicpRr030>
    {
        private readonly string? _descricao;

        public FiltroDescricaoRR030(string? descricao)
        {
            _descricao = descricao;
        }

        public IQueryable<OsusrTo3CsicpRr030> Apply(IQueryable<OsusrTo3CsicpRr030> query)
        {
            if (!string.IsNullOrWhiteSpace(_descricao))
            {
                query = query.Where(e => e.Rr030Descricao != null && e.Rr030Descricao.Contains(_descricao));
            }
            return query;
        }
    }
}
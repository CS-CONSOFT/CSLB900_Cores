using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using System.Linq.Expressions;

namespace CSCore.Ifs.Rebanho.RR010Repository.Filtros
{
    public class FiltroCondCriacaoRR010 : ICSFilter<OsusrTo3CsicpRr010>
    {
        private readonly string? _condCriacao;

        public FiltroCondCriacaoRR010(string? condCriacao)
        {
            _condCriacao = condCriacao;
        }

        public IQueryable<OsusrTo3CsicpRr010> Apply(IQueryable<OsusrTo3CsicpRr010> query)
        {
            if (!string.IsNullOrEmpty(_condCriacao))
            {
                query = query.Where(e => e.Rr010Condcriacao != null &&
                         e.Rr010Condcriacao.Contains(_condCriacao));
            }
            return query;
        }
    }
}
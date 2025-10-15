using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR005Repository_Situacao.Filtros
{
    internal class FiltroSituacaoRR005 : ICSFilter<OsusrTo3CsicpRr005>
    {
        private readonly string? _situacao;

        public FiltroSituacaoRR005(string? situacao)
        {
            _situacao = situacao;
        }

        public IQueryable<OsusrTo3CsicpRr005> Apply(IQueryable<OsusrTo3CsicpRr005> query)
        {
            if (!string.IsNullOrEmpty(_situacao))
            {
                query = query.Where(e => e.Rr005Situacao != null && 
                                         e.Rr005Situacao.Contains(_situacao));
            }
            return query;
        }
    }
}
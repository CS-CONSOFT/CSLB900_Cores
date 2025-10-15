using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Repository;

namespace CSCore.Ifs.Rebanho.RR002Repository_CadastroFazenda.Filtros
{
    internal class FiltroNomeFazendaRR002 : ICSFilter<OsusrTo3CsicpRr002>
    {
        private readonly string? _nomeFazenda;

        public FiltroNomeFazendaRR002(string? nomeFazenda)
        {
            _nomeFazenda = nomeFazenda;
        }

        public IQueryable<OsusrTo3CsicpRr002> Apply(IQueryable<OsusrTo3CsicpRr002> query)
        {
            if (!string.IsNullOrEmpty(_nomeFazenda))
            {
                query = query.Where(e => e.Rr002Nomefazenda != null && 
                                         e.Rr002Nomefazenda.Contains(_nomeFazenda));
            }
            return query;
        }
    }
}
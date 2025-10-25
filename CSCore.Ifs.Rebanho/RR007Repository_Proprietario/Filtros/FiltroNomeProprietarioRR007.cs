using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR007Repository_Proprietario.Filtros
{
    internal class FiltroNomeProprietarioRR007 : ICSFilter<OsusrTo3CsicpRr007>
    {
        private readonly string? _nomeProprietario;

        public FiltroNomeProprietarioRR007(string? nomeProprietario)
        {
            _nomeProprietario = nomeProprietario;
        }

        public IQueryable<OsusrTo3CsicpRr007> Apply(IQueryable<OsusrTo3CsicpRr007> query)
        {
            if (!string.IsNullOrEmpty(_nomeProprietario))
            {
                query = query.Where(e => e.Rr007Proprietario != null && 
                                         e.Rr007Proprietario.Contains(_nomeProprietario));
            }
            return query;
        }
    }
}
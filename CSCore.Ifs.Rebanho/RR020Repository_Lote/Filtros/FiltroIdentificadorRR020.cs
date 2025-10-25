using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR020Repository_Lote.Filtros
{
    internal class FiltroIdentificadorRR020 : ICSFilter<OsusrTo3CsicpRr020>
    {
        private readonly string? _identificador;

        public FiltroIdentificadorRR020(string? identificador)
        {
            _identificador = identificador;
        }

        public IQueryable<OsusrTo3CsicpRr020> Apply(IQueryable<OsusrTo3CsicpRr020> query)
        {
            if (!string.IsNullOrEmpty(_identificador))
            {
                query = query.Where(e => e.Rr020Identificador != null && 
                                         e.Rr020Identificador.Contains(_identificador));
            }
            return query;
        }
    }
}
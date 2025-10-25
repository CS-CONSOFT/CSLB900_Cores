using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR020Repository_Lote.Filtros
{
    internal class FiltroDescricaoRR020 : ICSFilter<OsusrTo3CsicpRr020>
    {
        private readonly string? _descricao;

        public FiltroDescricaoRR020(string? descricao)
        {
            _descricao = descricao;
        }

        public IQueryable<OsusrTo3CsicpRr020> Apply(IQueryable<OsusrTo3CsicpRr020> query)
        {
            if (!string.IsNullOrEmpty(_descricao))
            {
                query = query.Where(e => e.Rr020Descricao != null && 
                                         e.Rr020Descricao.Contains(_descricao));
            }
            return query;
        }
    }
}
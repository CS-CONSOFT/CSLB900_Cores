using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros
{
    public class FiltroUsuarioIdRR022 : ICSFilter<OsusrTo3CsicpRr022>
    {
        private readonly string? _usuarioId;

        public FiltroUsuarioIdRR022(string? usuarioId)
        {
            _usuarioId = usuarioId;
        }

        public IQueryable<OsusrTo3CsicpRr022> Aplicar(IQueryable<OsusrTo3CsicpRr022> query)
        {
            if (!string.IsNullOrWhiteSpace(_usuarioId))
            {
                query = query.Where(e => e.Rr022Usuarioid == _usuarioId);
            }
            return query;
        }
    }
}
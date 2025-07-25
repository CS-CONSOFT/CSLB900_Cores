using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.TT.TT0XX.TT030
{
    public class DtoGetTT030
    {
        public int TenantId { get; set; }

        public long Tt030Id { get; set; }

        public string? Tt030Estabid { get; set; }

        public int? Tt030Protocolonumber { get; set; }

        public DateTime? Tt030Datahora { get; set; }

        public string? Tt030Usuariopropid { get; set; }

        public string? Tt030Usuariovendedorid { get; set; }

        public string? Tt030Observacao { get; set; }

        public string? Tt030Protocolnumber { get; set; }
        public string? CS_EstabNomeFantasia { get; set; }
        public string? CS_UsuarioPropNome { get; set; }
    }
}

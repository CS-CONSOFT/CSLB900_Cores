using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF108
{
    public class DtoGetFF108
    {
        public int TenantId { get; set; }

        public long Ff108Id { get; set; }

        public string? Ff105Borderoid { get; set; }

        public DateTime? Ff108Datahora { get; set; }

        public string? Ff108Mensagem { get; set; }

        public string? Ff108UsuarioId { get; set; }

        public virtual CSICP_FF105? Ff105Bordero { get; set; }
    }
}

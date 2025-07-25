using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF002
{
    public class DtoGetFF002
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Ff002Tiporegistro { get; set; }

        public int? Ff002Codigo { get; set; }

        public string? Ff002Motivo { get; set; }

        public int? Ff002Peso { get; set; }

        public OsusrE9aCsicpFf002Mod? NavFF002_Mod { get; set; }
    }
}

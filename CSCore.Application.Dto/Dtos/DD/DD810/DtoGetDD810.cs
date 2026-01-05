using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD.DD810
{
    public class DtoGetDD810
    {
        public int TenantId { get; set; }

        public string Dd810Id { get; set; } = null!;

        public int? Dd810CfopSaida { get; set; }

        public int? Dd810CfopEntrada { get; set; }

        public string? Dd810Anotacao { get; set; }

        public string? Dd810Hashid { get; set; }

        public Osusr66cSpedInCfop NavDD810_CFOP_Saida { get; set; }

        public Osusr66cSpedInCfop NavDD810_CFOP_Entrada { get; set; }
    }
}

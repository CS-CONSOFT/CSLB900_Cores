using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF019
{
    public class DtoGetFF019
    {
        public int TenantId { get; set; }

        public long Ff019Id { get; set; }

        public string? Ff000Id { get; set; }

        public string? Ff019FpagtoId { get; set; }

        public string? Ff019Condicaoid { get; set; }

        public Dto_GetBB008_Exibicao? NavCondicaoPgto { get; set; }
        public Dto_GetBB026_Exibicao? NavFormaPgto { get; set; }
    }
}

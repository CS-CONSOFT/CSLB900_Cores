using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF131;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF132
{
    public class DtoGetFF132
    {
        public int TenantId { get; set; }

        public long Ff132Id { get; set; }

        public long? Ff131Id { get; set; }

        public string? Ff102Id { get; set; }

        public DtoGetFF131_SemNavs? NavFF131 { get; set; }

        public DtoGetFF102_Exibicao? NavFF102 { get; set; }
    }
}

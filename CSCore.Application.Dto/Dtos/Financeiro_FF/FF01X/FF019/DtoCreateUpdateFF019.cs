using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF019
{
    public class DtoCreateUpdateFF019 : IConverteParaEntidade<CSICP_FF019>
    {
        public string? Ff000Id { get; set; }

        public string? Ff019FpagtoId { get; set; }

        public string? Ff019Condicaoid { get; set; }

        public CSICP_FF019 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF019
            {
                TenantId = tenant,
                Ff019Id = long.Parse(id!),
                Ff000Id = Ff000Id,
                Ff019FpagtoId = Ff019FpagtoId,
                Ff019Condicaoid = Ff019Condicaoid,
            };
        }
    }
}

using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF114;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF114Mapper
    {
        public static DtoGetFF114 ToDtoGet(this CSICP_FF114 entity)
        {
            return new DtoGetFF114
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff114Refconfigbanco = entity.Ff114Refconfigbanco,
                Ff114Lote = entity.Ff114Lote,
                Ff114Ordem = entity.Ff114Ordem,
                Ff114Linha240 = entity.Ff114Linha240,
                Ff114Linha400 = entity.Ff114Linha400,
                Ff114Idcontrole = entity.Ff114Idcontrole
            };
        }
    }
}

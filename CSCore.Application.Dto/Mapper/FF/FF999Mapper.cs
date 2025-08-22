using CSCore.Application.Dto.Dtos.Financeiro_FF;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF
{
    public static class FF999Mapper
    {
        public static DtoGetFF999 ToDtoGet(this CSICP_FF999 entity)
        {
            return new DtoGetFF999
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff999IdControle = entity.Ff999IdControle,
                Ff999Parcela = entity.Ff999Parcela,
                Ff999Datavencto = entity.Ff999Datavencto,
                Ff999Valorparcela = entity.Ff999Valorparcela
            };
        }
    }
}

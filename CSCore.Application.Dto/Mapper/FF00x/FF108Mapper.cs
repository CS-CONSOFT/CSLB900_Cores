using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF108;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF108Mapper
    {
        public static DtoGetFF108 ToDtoGetFF108(this CSICP_FF108 entity)
        {
            return new DtoGetFF108
            {
                TenantId = entity.TenantId,
                Ff108Id = entity.Ff108Id,
                Ff105Borderoid = entity.Ff105Borderoid,
                Ff108Datahora = entity.Ff108Datahora,
                Ff108Mensagem = entity.Ff108Mensagem,
                Ff108UsuarioId = entity.Ff108UsuarioId
            };
        }
    }
}

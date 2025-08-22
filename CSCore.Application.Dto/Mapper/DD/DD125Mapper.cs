using CSCore.Application.Dto.Dtos.DD.DD125;
using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.DD
{
    public static class DD125Mapper
    {
        public static DtoGetDD125 ToDtoGet(this CSICP_DD125 entity)
        {
            return new DtoGetDD125
            {
                TenantId = entity.TenantId,
                Dd125CartacredId = entity.Dd125CartacredId,
                Dd125FilialId = entity.Dd125FilialId,
                Dd120TrocaId = entity.Dd120TrocaId,
                Dd125ContaId = entity.Dd125ContaId,
                Dd125DataMovto = entity.Dd125DataMovto,
                Dd125Vcarta = entity.Dd125Vcarta,
                Dd125VsaldoCarta = entity.Dd125VsaldoCarta,
                Dd125UsuariopropId = entity.Dd125UsuariopropId,
                Dd125StatusId = entity.Dd125StatusId,
                Dd125Email = entity.Dd125Email,
                Dd125Sms = entity.Dd125Sms,
                Dd125Protocolnumber = entity.Dd125Protocolnumber,
                Dd125Islock = entity.Dd125Islock,
                Dd125Tiporegid = entity.Dd125Tiporegid
            };
        }
    }
}
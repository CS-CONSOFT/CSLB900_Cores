using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008RFTransacao;
using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.GG00X.GG008
{
    public static class GG008RFTransacaoMapper
    {
        public static DtoGetGG008RFTransacao ToDtoGetGG008RFT(this OsusrE9aCsicpGg008rftransacao entity)
        {
            return new DtoGetGG008RFTransacao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg008tTiporegistro = entity.Gg008tTiporegistro,
                Gg008tFilialid = entity.Gg008tFilialid,
                Gg008tKardexId = entity.Gg008tKardexId,
                Gg008tNcmId = entity.Gg008tNcmId,
                Gg008tTransacaoid = entity.Gg008tTransacaoid
            };
        }
    }
}

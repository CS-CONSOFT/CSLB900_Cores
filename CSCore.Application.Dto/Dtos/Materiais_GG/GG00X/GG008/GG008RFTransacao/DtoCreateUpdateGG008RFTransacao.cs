using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008RFTransacao
{
    public class DtoCreateUpdateGG008RFTransacao : IConverteParaEntidade<OsusrE9aCsicpGg008rftransacao>
    {
        public int? Gg008tTiporegistro { get; set; }

        public string? Gg008tFilialid { get; set; }

        public string? Gg008tKardexId { get; set; }

        public string? Gg008tNcmId { get; set; }

        public string? Gg008tTransacaoid { get; set; }

        public OsusrE9aCsicpGg008rftransacao ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpGg008rftransacao
            {
                TenantId = tenant,
                Id = id!,
                Gg008tTiporegistro = this.Gg008tTiporegistro,
                Gg008tFilialid = this.Gg008tFilialid,
                Gg008tKardexId = this.Gg008tKardexId,
                Gg008tNcmId = this.Gg008tNcmId,
                Gg008tTransacaoid = this.Gg008tTransacaoid
            };
        }
    }
}

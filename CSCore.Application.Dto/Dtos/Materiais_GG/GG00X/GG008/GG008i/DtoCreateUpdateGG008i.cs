using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008i
{
    public class DtoCreateUpdateGG008i : IConverteParaEntidade<CSICP_GG008i>
    {
        public string? Gg008iFilialid { get; set; }

        public string? Gg008iKardexId { get; set; }

        public string? Gg008iProdutoid { get; set; }

        public string? Gg008iTransacaoid { get; set; }

        public int? Gg008iTiporegistro { get; set; }

        public string? Gg008iNcmId { get; set; }

        public CSICP_GG008i ToEntity(int tenant, string? id)
        {
            return new CSICP_GG008i
            {
                TenantId = tenant,
                Id = id!,
                Gg008iFilialid = this.Gg008iFilialid,
                Gg008iKardexId = this.Gg008iKardexId,
                Gg008iProdutoid = this.Gg008iProdutoid,
                Gg008iTransacaoid = this.Gg008iTransacaoid,
                Gg008iTiporegistro = this.Gg008iTiporegistro,
                Gg008iNcmId = this.Gg008iNcmId,
                NavBB027Transacao = null,
                NavGG008Trans = null

            };
        }
    }
}

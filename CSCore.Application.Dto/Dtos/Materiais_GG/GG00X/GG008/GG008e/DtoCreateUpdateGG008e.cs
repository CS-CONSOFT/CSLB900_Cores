using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using System.Text.Json.Serialization;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008e
{
    public class DtoCreateUpdateGG008e : IConverteParaEntidade<CSICP_GG008e>
    {
        [JsonIgnore]
        public long? ID = 0;
        public string? Gg008eSeq { get; set; }

        public string? Gg008eDescricao { get; set; }

        public string? Gg008eCodigo { get; set; }

        public string? Gg008eProdutoid { get; set; }

        public CSICP_GG008e ToEntity(int tenant, string? _)
        {
            var entity = new CSICP_GG008e
            {
                Gg008eId = ID ?? 0,
                TenantId = tenant,
                Gg008eSeq = this.Gg008eSeq,
                Gg008eDescricao = this.Gg008eDescricao,
                Gg008eCodigo = this.Gg008eCodigo,
                Gg008eProdutoid = this.Gg008eProdutoid,
            };
            return entity;
        }
    }
}

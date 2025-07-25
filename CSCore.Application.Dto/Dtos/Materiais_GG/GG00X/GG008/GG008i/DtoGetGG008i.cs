using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008i
{
    public class DtoGetGG008i
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg008iFilialid { get; set; }

        public string? Gg008iKardexId { get; set; }

        public string? Gg008iProdutoid { get; set; }

        public string? Gg008iTransacaoid { get; set; }

        public int? Gg008iTiporegistro { get; set; }

        public string? Gg008iNcmId { get; set; }

        public Dto_GetBB027Simples? NavBB027Transacao { get; set; }
        public OsusrE9aCsicpGg008Tran? NavGG008Trans { get; set; }
    }
}

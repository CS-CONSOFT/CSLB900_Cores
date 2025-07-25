using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG071
{
    public class DtoGetGG071
    {
        public int TenantId { get; set; }

        public long Gg071Id { get; set; }

        public string? Gg071Estabid { get; set; }

        public string? Gg071Protocolnumber { get; set; }

        public DateTime? Gg071DataMovimento { get; set; }

        public string? Gg071Usuarioid { get; set; }

        public string? Gg071Observacao { get; set; }

        public string? Gg071Ccustoid { get; set; }

        public string? Gg071NoDocto { get; set; }

        public int? Gg071Statusid { get; set; }

        public string? Dd070Id { get; set; }

        public string? Gg071Almoxsaidaid { get; set; }

        public string? Gg071Almoxentid { get; set; }

        public string? Gg071AtendenteUsuarioid { get; set; }

        public DateTime? Gg071Datendimento { get; set; }

        public int? Gg071Tpreqid { get; set; }

        public DateTime? Gg071Dhsolicitacao { get; set; }

        public CSICP_GG001? Gg071Almoxent { get; set; }

        public CSICP_GG001? Gg071Almoxsaida { get; set; }

        public OsusrE9aCsicpGg071Stum? Gg071Status { get; set; }

        public OsusrE9aCsicpGg041Tpreq? Gg071Tpreq { get; set; }
    }
}

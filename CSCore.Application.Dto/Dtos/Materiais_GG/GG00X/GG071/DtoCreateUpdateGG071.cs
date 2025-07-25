using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG071
{
    public class DtoCreateUpdateGG071 : IConverteParaEntidade<CSICP_GG071>
    {
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
        public CSICP_GG071 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG071
            {
                TenantId = tenant,
                Gg071Estabid = this.Gg071Estabid,
                Gg071Protocolnumber = this.Gg071Protocolnumber,
                Gg071DataMovimento = this.Gg071DataMovimento,
                Gg071Usuarioid = this.Gg071Usuarioid,
                Gg071Observacao = this.Gg071Observacao,
                Gg071Ccustoid = this.Gg071Ccustoid,
                Gg071NoDocto = this.Gg071NoDocto,
                Gg071Statusid = this.Gg071Statusid,
                Dd070Id = this.Dd070Id,
                Gg071Almoxsaidaid = this.Gg071Almoxsaidaid,
                Gg071Almoxentid = this.Gg071Almoxentid,
                Gg071AtendenteUsuarioid = this.Gg071AtendenteUsuarioid,
                Gg071Datendimento = this.Gg071Datendimento,
                Gg071Tpreqid = this.Gg071Tpreqid,
            };
        }
    }
}

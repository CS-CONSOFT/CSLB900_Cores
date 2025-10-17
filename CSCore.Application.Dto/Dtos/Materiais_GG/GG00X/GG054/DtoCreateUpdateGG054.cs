using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG054
{
    public class DtoCreateUpdateGG054 : IConverteParaEntidade<CSICP_GG054>
    {
        public string? Gg054Filialid { get; set; }

        public string? Gg054Protocolnumber { get; set; }

        public string? Gg054UsuarioId { get; set; }

        public DateTime? Gg054DataColeta { get; set; }

        public string? Gg054Observacao { get; set; }

        public int? Gg054Status { get; set; }

        public string? Gg054Almox { get; set; }

        public DateTime? Gg054DataInc { get; set; }

        public DateTime? Gg054HoraInc { get; set; }

        public DateTime? Gg054DataAlt { get; set; }

        public DateTime? Gg054HoraAlt { get; set; }

        public string? Gg054UsuarioAlt { get; set; }

        public string? Gg032Id { get; set; }

        public string? Gg054DocInvent { get; set; }

        public bool? Gg054Ismarcado { get; set; }
        public CSICP_GG054 ToEntity(int tenant, string? _)
        {
            return new CSICP_GG054
            {
                TenantId = tenant,
                Gg054Filialid = this.Gg054Filialid,
                Gg054Protocolnumber = this.Gg054Protocolnumber,
                Gg054UsuarioId = this.Gg054UsuarioId,
                Gg054DataColeta = this.Gg054DataColeta,
                Gg054Observacao = this.Gg054Observacao,
                Gg054Status = this.Gg054Status,
                Gg054Almox = this.Gg054Almox,
                Gg054DataInc = this.Gg054DataInc,
                Gg054HoraInc = this.Gg054HoraInc,
                Gg054DataAlt = this.Gg054DataAlt,
                Gg054HoraAlt = this.Gg054HoraAlt,
                Gg054UsuarioAlt = this.Gg054UsuarioAlt,
                Gg032Id = this.Gg032Id,
                Gg054DocInvent = this.Gg054DocInvent,
                Gg054Ismarcado = this.Gg054Ismarcado,
            };
        }
    }
}

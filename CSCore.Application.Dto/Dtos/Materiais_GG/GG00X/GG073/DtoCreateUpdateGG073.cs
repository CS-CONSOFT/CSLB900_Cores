using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.Extensao;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG073
{
    public class DtoCreateUpdateGG073 : IConverteParaEntidade<CSICP_GG073>
    {
        public string? Gg073Estabid { get; set; }

        public DateTime Gg073DataMovimento { get; set; } = default;

        public string? Gg073Usuarioid { get; set; }

        public string? Gg073Observacao { get; set; }

        public string? Gg073Ccustoid { get; set; }

        public string? Gg073Almoxmovd { get; set; }

        public DateTime? Gg073Dhregistro { get; set; }

        public int? Gg073Statusid { get; set; }

        public int? Gg073Tmovid { get; set; }

        public int? Gg073Valorizarporid { get; set; }

        public decimal? Gg073Tmovimento { get; set; }

        public string? Gg073Protocolonro { get; set; }

        public string? Gg073Almoxmovsaida { get; set; }

        public long? Gg073QtdeItens { get; set; }

        public string? Gg073IdOrig { get; set; }

        public long? Dd190Obraid { get; set; }
        public CSICP_GG073 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_GG073
            {
                TenantId = tenant,
                Gg073Id = id!,
                Gg073Estabid = this.Gg073Estabid,
                Gg073DataMovimento = this.Gg073DataMovimento,
                Gg073Usuarioid = this.Gg073Usuarioid,
                Gg073Observacao = this.Gg073Observacao,
                Gg073Ccustoid = this.Gg073Ccustoid,
                Gg073Almoxmovd = this.Gg073Almoxmovd,
                Gg073Dhregistro = this.Gg073Dhregistro,
                Gg073Statusid = this.Gg073Statusid,
                Gg073Tmovid = this.Gg073Tmovid,
                Gg073Valorizarporid = this.Gg073Valorizarporid,
                Gg073Tmovimento = this.Gg073Tmovimento,
                Gg073Protocolonro = this.Gg073Protocolonro,
                Gg073Almoxmovsaida = this.Gg073Almoxmovsaida,
                Gg073QtdeItens = this.Gg073QtdeItens,
                Gg073IdOrig = this.Gg073IdOrig,
                Dd190Obraid = this.Dd190Obraid,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

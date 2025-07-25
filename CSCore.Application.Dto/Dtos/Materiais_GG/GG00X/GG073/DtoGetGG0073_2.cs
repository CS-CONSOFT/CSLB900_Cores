using CSBS101._82Application.Dto.BB00X.BB005;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain.CS_Models.Staticas.GG;
using GG104Materiais.C82Application.Dto.GG00X.GG001;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG073
{
    public class DtoGetGG0073_2
    {
        public int TenantId { get; set; }

        public string Gg073Id { get; set; } = null!;

        public string? Gg073Estabid { get; set; }

        public int? Gg073Protocolnumber { get; set; }

        public DateTime? Gg073DataMovimento { get; set; }

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
        public DtoGetGG001? NavGg001Almoxmovd { get; set; }
        public DtoGetGG001? NavGg001Almoxmovsaida { get; set; }
        public Dto_GetSY001Simples? NavSY001Usuario { get; set; }
        public Dto_GetBB005? NavBB005CentroDeCusto { get; set; }
        public OsusrE9aCsicpGg073Stat? NavGg073Status { get; set; }
        public OsusrE9aCsicpGg073Tmov? NavGg073Tmov { get; set; }
        public CSICP_GG023Val? NavGg073Valorizarpor { get; set; }
    }
}

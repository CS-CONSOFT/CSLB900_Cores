using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG032
{
    public class DtoGetGG032
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg032Filialid { get; set; }

        public string? Gg032Usuarioid { get; set; }

        public int? Gg032Filial { get; set; }

        public DateTime? Gg032Datamovimento { get; set; }

        public string? Gg032Observacao { get; set; }

        public string? Gg032Almoxid { get; set; }

        public int? Gg032Codgalmox { get; set; }

        public decimal? Gg032Totalcusto { get; set; }

        public decimal? Gg032Totalcreal { get; set; }

        public decimal? Gg032Totalcmedio { get; set; }

        public decimal? Gg032Totalvenda { get; set; }

        public DateTime? Gg032DataHoraBloqueado { get; set; }

        public DateTime? Gg032DataHoraProcessado { get; set; }

        public int? Gg032QtosPodutos { get; set; }

        public int? Gg032QtosNaoconform { get; set; }

        public int? Gg032QtosNaoinventariado { get; set; }

        public decimal? Gg032QtdRegraNconf { get; set; }

        public int? Gg032TipoinventarioId { get; set; }

        public int? Gg032StatusId { get; set; }

        public string? Gg032Protocolnumber { get; set; }
        public OsusrE9aCsicpGg032Stum? NavGG032Status { get; set; }

        public Dto_GetSY001Simples? NavSy001Usuario { get; set; }

        public CSICP_GG001Talmox? NavGG001Talmox { get; set; }

    }
}

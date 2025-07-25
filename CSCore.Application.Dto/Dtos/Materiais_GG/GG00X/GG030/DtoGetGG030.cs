using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB007;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG031;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG030
{
    public class DtoGetGG030
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg030Usuarioid { get; set; }

        public int? Gg030Filial { get; set; }

        public string? Gg030Filialid { get; set; }

        public DateTime? Gg030DataMovimento { get; set; }

        public string? Gg030Observacao { get; set; }

        public int? Gg030CodgCCusto { get; set; }

        public string? Gg030Ccustoid { get; set; }

        public int? Gg030NoDocto { get; set; }

        public decimal? Gg030Percajuste { get; set; }

        public int? Gg030Responsavel { get; set; }

        public string? Gg030Responsavelid { get; set; }

        public decimal? Gg030TotalMovimento { get; set; }

        public int? Gg030Status { get; set; }

        public int? Gg030PrecoajusteId { get; set; }

        public string? Gg030Protocolnumber { get; set; }

        public DtoGetGG031? NavGG031 { get; set; }
        public Dto_GetBB005? NavBB005 { get; set; }
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public Dto_GetBB007SemList? NavBB007 { get; set; }
        public CSICP_GG030Sta? NavGG030Sta { get; set; }
        public CSICP_GG023Val? NavGG023Val { get; set; }
        public Dto_GetSY001Simples? NavSY001 { get; set; }
    }


    public class DtoGetGG030Est
    {
        public int TenantId { get; set; }
        public long Gg030aId { get; set; }
        public string? Gg030Id { get; set; }
        public string? Bb001Id { get; set; }
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
    }
}

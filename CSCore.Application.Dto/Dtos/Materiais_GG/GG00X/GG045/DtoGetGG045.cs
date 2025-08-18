using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG046;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG045
{
    public class DtoGetGG045
    {
        public int TenantId { get; set; }

        public string Gg045Id { get; set; } = null!;

        public string? Gg045EstabelecimentoId { get; set; }

        public string? Gg045Saldoid { get; set; }

        public decimal? Gg045Qtd { get; set; }

        public string? Gg045Protocolnumber { get; set; }

        public DateTime? Gg045Datamovto { get; set; }

        public string? Gg045UsuariopropId { get; set; }

        public string? Gg045Descricao { get; set; }

        public string? Cc040Id { get; set; }

        public int? Gg045Statid { get; set; }

        public string? Cc060Id { get; set; }

        public string? CS_Gg520KardexId { get; set; }

        public string? CS_Gg520Almoxid { get; set; }
        public string? CS_Gg520AlmoxCodigo { get; set; }
        public string? CS_Gg520AlmoxDesc { get; set; }
        public string? CS_Gg520DescLote { get; set; }
        public string? CS_Gg520DescSaldo { get; set; }

        public decimal CS_Gg520Saldo { get; set; } = -1;
        public decimal CS_Gg520NS { get; set; } = -1;

        public int? CS_Gg008Codgproduto { get; set; }

        public string? CS_Gg008Descreduzida { get; set; }
        public OSUSR_E9A_CSICP_GG045_STAT? Gg045Stat { get; set; }
        public IEnumerable<DtoGetSaldoGG520ParaGG45>? CS_Gg520SaldosCandidatos { get; set; }
        public IEnumerable<DtoGetGG046>? CS_Gg046ListaPeloGG045 { get; set; }



    }
}

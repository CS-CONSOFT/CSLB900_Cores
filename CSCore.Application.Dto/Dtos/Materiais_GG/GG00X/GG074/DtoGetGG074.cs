using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG073;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;
using CSCore.Domain.CS_Models.Staticas.GG;
using GG104Materiais.C82Application.Dto.GG00X.GG007;
using GG104Materiais.C82Application.Dto.GG00X.GG008.GG008Kdx;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG074
{
    public class DtoGetGG074
    {
        public int TenantId { get; set; }

        public long Gg074Id { get; set; }

        public string? Gg073Id { get; set; }

        public string? Gg074Codbarrasalfa { get; set; }

        public string? Gg074KardexId { get; set; }

        public string Gg074Saldoid { get; set; }

        public string? Gg074UnId { get; set; }

        public decimal Gg074Qtd { get; set; }

        public decimal? Gg074Vunitario { get; set; }

        public int Gg074Statusestqid { get; set; }

        public int? Gg074Tmovid { get; set; }

        public decimal? Gg074Tproduto { get; set; }

        public DtoGetGG073? NavGG073 { get; set; }
        public DtoGetGG008Kdx? NavGG008Kdx { get; set; }
        public DtoGetGG520Simples? NavGG520 { get; set; }
        public DtoGetGG007Simples? NavGG007 { get; set; }
        public CSICP_GG072Stq? NavGG072Stq { get; set; }
        public OSUSR_E9A_CSICP_GG073_TMOV? NavGG073TpMov { get; set; }
    }
}

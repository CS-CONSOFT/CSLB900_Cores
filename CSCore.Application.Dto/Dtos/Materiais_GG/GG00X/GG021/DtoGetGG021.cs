using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace GG104Materiais.C82Application.Dto.GG00X.GG021
{
    public class DtoGetGG021
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public decimal? Gg021Ncm { get; set; }

        public string? Gg021ExNcm { get; set; }

        public string? Gg021Descricao { get; set; }

        public string? Gg021Unidade { get; set; }

        public string? Gg021Unid { get; set; }

        public decimal? Gg021PercIpi { get; set; }

        public decimal? Gg021PercIcms { get; set; }

        public string? Gg021Tipi { get; set; }

        public string? Gg021ExNbm { get; set; }

        public bool? Gg021IsActive { get; set; }

        public string? Gg021NcmGenero { get; set; }

        public int? Gg021Mp255Id { get; set; }

        public int? Gg021GeneroId { get; set; }

        public string? Gg021CnaeId { get; set; }

        public int? Gg021IsinalanteId { get; set; }

        public int? Gg021CestId { get; set; }

        public string? Gg021CestN2 { get; set; }

        public string? Gg021CestN3 { get; set; }

        public decimal? Gg021PercCsll { get; set; }

        public decimal? Gg021PercCofins { get; set; }

        public decimal? Gg021PercPis { get; set; }

        public decimal? Gg021IcmsPauta { get; set; }

        public decimal? Gg021IpiPauta { get; set; }

        public decimal? Gg021AliquotaIrpj { get; set; }

        public int? Gg021Ierelevanteid { get; set; }

        public DateTime? Gg021Dtiniciovigencia { get; set; }

        public DateTime? Gg021Dtfimvigencia { get; set; }

        public OsusrE9aCsicpGg021cest? NavGg021Cest { get; set; }
        public OsusrNnxSpedInGenItem? NavGenero { get; set; }

        public CSICP_GG007? NavGg007Un { get; set; }
    }

}

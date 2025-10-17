using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG021
{
    public class DtoCreateUpdateGG021 : IConverteParaEntidade<CSICP_GG021>
    {
        public decimal? Gg021Ncm { get; set; }

        public string? Gg021ExNcm { get; set; }

        public string? Gg021Descricao { get; set; }

        public string? Gg021Unidade { get; set; }

        public string? Gg021Unid { get; set; }

        public decimal? Gg021PercIpi { get; set; }

        public decimal? Gg021PercIcms { get; set; }

        public string? Gg021Tipi { get; set; }

        public string? Gg021ExNbm { get; set; }

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

        public string? Gg021Dtiniciovigencia { get; set; }

        public string? Gg021Dtfimvigencia { get; set; }
        public bool? Gg021IsActive { get; set; }

        public CSICP_GG021 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG021
            {
                TenantId = tenant,
                Id = id!,
                Gg021Ncm = this.Gg021Ncm,
                Gg021ExNcm = this.Gg021ExNcm,
                Gg021Descricao = this.Gg021Descricao,
                Gg021Unidade = this.Gg021Unidade,
                Gg021Unid = this.Gg021Unid,
                Gg021PercIpi = this.Gg021PercIpi,
                Gg021PercIcms = this.Gg021PercIcms,
                Gg021Tipi = this.Gg021Tipi,
                Gg021ExNbm = this.Gg021ExNbm,
                Gg021IsActive = Gg021IsActive,
                Gg021NcmGenero = this.Gg021NcmGenero,
                Gg021Mp255Id = this.Gg021Mp255Id,
                Gg021GeneroId = this.Gg021GeneroId,
                Gg021CnaeId = this.Gg021CnaeId,
                Gg021IsinalanteId = this.Gg021IsinalanteId,
                Gg021CestId = this.Gg021CestId,
                Gg021CestN2 = this.Gg021CestN2,
                Gg021CestN3 = this.Gg021CestN3,
                Gg021PercCsll = this.Gg021PercCsll,
                Gg021PercCofins = this.Gg021PercCofins,
                Gg021PercPis = this.Gg021PercPis,
                Gg021IcmsPauta = this.Gg021IcmsPauta,
                Gg021IpiPauta = this.Gg021IpiPauta,
                Gg021AliquotaIrpj = this.Gg021AliquotaIrpj,
                Gg021Ierelevanteid = this.Gg021Ierelevanteid,
                Gg021Dtiniciovigencia = this.Gg021Dtiniciovigencia.ConverteStringVaziaParaDataNula(),
                Gg021Dtfimvigencia = this.Gg021Dtfimvigencia.ConverteStringVaziaParaDataNula(),
            };
        }
    }
}


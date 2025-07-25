using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas.PD;
using System.ComponentModel.DataAnnotations;

namespace CSBS101.C82Application.Dto.BB00X.BB01X.BB017
{
    public class Dto_GetBB017
    {
        public int TenantId { get; set; }

        [Key]
        public string Bb017Id { get; set; } = null!;

        public string? Bb017Empresaid { get; set; }

        public string? Bb017Fpagtoid { get; set; }

        public string? Bb017Condicaoid { get; set; }

        public decimal? Bb017Fatoracrescimo { get; set; }

        public decimal? Bb017Fatorsementrada { get; set; }

        public int? Bb017Ordem { get; set; }

        public int? Bb017CmdTefVdId { get; set; }

        public int? Bb017CmdTefCancId { get; set; }

        public int? Bb017Parcliquidadas { get; set; }

        public int? Bb017Entliquidada { get; set; }

        public decimal? Bb017Vacimade { get; set; }
        public CSICP_Statica? NavSta_BB017_EntLiquidada { get; set; }
        public CSICP_Statica? NavSta_BB017_ParcLiquidadas { get; set; }

        public CSICP_PD001Ctef? NavCSICP_PD001Ctef_Cmd_Tef_VD { get; set; }
        public CSICP_PD001Ctef? NavCSICP_PD001Ctef_Cmd_Tef_Canc { get; set; }

        public Dto_GetBB008_Exibicao? NavBb008Condicao { get; set; }
        public Dto_GetBB026_Exibicao? NavBB026FormaPagamento { get; set; }

        //public CSICP_PD001Ctef? NavStaPD001_CTef_Cmd_Tef_Canc { get; set; }
        //public CSICP_PD001Ctef? NavStaPD001_CTef_Cmd_Tef_VD { get; set; }
    }
}

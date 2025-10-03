using CSCore.Application.Dto.Dtos.Basico_AA.AA00X;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD061
{
    public class DtoGetDD061
    {
        public int TenantId { get; set; }

        public string Dd061Id { get; set; } = null!;

        public string? Dd060Id { get; set; }

        public int? Dd061ImpostoId { get; set; }

        public string? Dd061Produtoid { get; set; }

        public int? Dd061Codgproduto { get; set; }

        public string? Dd061ImpostoidGeneric { get; set; }

        public string? Dd061CodgImposto { get; set; }

        public string? Dd061Cst { get; set; }

        public string? Dd061Cfop { get; set; }

        public string? Dd061Descimposto { get; set; }

        public decimal? Dd061ValorContabil { get; set; }

        public decimal? Dd061BaseCalculo { get; set; }

        public decimal? Dd061Aliquota { get; set; }

        public decimal? Dd061Valorimposto { get; set; }

        public decimal? Dd061Percreducbase { get; set; }

        public decimal? Dd061Vredbcicms { get; set; }

        public decimal? Dd061Isento { get; set; }

        public decimal? Dd061Outros { get; set; }

        public decimal? Dd061Cancelamentos { get; set; }

        public decimal? Dd061Descontos { get; set; }

        public decimal? Dd061Lucroestimado { get; set; }

        public decimal? Dd061Vltribaux { get; set; }

        public decimal? Dd061Predbcst { get; set; }

        public decimal? Dd061Vbcst { get; set; }

        public decimal? Dd061Picmsst { get; set; }

        public decimal? Dd061Vicmsst { get; set; }

        public decimal? Dd061Vbcfcp { get; set; }

        public decimal? Dd061Pfcp { get; set; }

        public decimal? Dd061Vfcp { get; set; }

        public decimal? Dd061Vbcfcpst { get; set; }

        public decimal? Dd061Pfcpst { get; set; }

        public decimal? Dd061Vfcpst { get; set; }

        public int? Dd061Agregasubtribut { get; set; }

        public decimal? Dd061QtdTributada { get; set; }

        public decimal? Dd061VlrUnidade { get; set; }

        public decimal? Dd061VlrImposto { get; set; }

        public int? Dd061SomaIpiBaseId { get; set; }

        public int? Dd061BaseliqbrutaId { get; set; }

        public decimal? Dd061Vbcstret { get; set; }

        public decimal? Dd061Vicmsstret { get; set; }

        public decimal? Dd061Vbcfcpstret { get; set; }

        public decimal? Dd061Pfcpstret { get; set; }

        public decimal? Dd061Vfcpstret { get; set; }

        public decimal? Dd061Vsuframa { get; set; }

        public decimal? Dd061Psuframa { get; set; }

        public decimal? Dd061Vbcsuframa { get; set; }

        public decimal? Dd061VicmsDesonerado { get; set; }

        public decimal? Dd061VpautaIcms { get; set; }

        public decimal? Dd061Vbcufdest { get; set; }

        public decimal? Dd061Picmsufdest { get; set; }

        public decimal? Dd061Picmsinter { get; set; }

        public decimal? Dd061Picmsinterpart { get; set; }

        public decimal? Dd061Vbcfcpufdest { get; set; }

        public decimal? Dd061Pfcpufdest { get; set; }

        public decimal? Dd061Vfcpufdest { get; set; }

        public decimal? Dd061Vicmsufremet { get; set; }

        public decimal? Dd061Vicmsufdest { get; set; }

        public decimal? Dd061Pcredsn { get; set; }

        public decimal? Dd061Vcredicmssn { get; set; }

        public string? Dd061Impostodevol { get; set; }

        public decimal? Dd061Pdevol { get; set; }

        public string? Dd061Ipi { get; set; }

        public decimal? Dd061Vipidevol { get; set; }

        public decimal? Dd061Vbcefet { get; set; }

        public decimal? Dd061Picmsefet { get; set; }

        public decimal? Dd061Vicmsefet { get; set; }

        public decimal? Dd061Predbcefet { get; set; }

        public decimal? Dd061Pst { get; set; }

        public decimal? Dd061Vicmssubstituto { get; set; }

        public decimal? Dd061Vicmsop { get; set; }

        public decimal? Dd061Pdif { get; set; }

        public decimal? Dd061Vicmsdif { get; set; }

        public decimal? N37aQbcmono { get; set; }

        public decimal? N38Adremicms { get; set; }

        public decimal? N39Vicmsmono { get; set; }

        public decimal? N39aQbcmonoreten { get; set; }

        public decimal? N40Adremicmsreten { get; set; }

        public decimal? N41Vicmsmonoreten { get; set; }

        public decimal? N47Predadrem { get; set; }

        public string? N48Motredadrem { get; set; }

        public decimal? N41aVicmsmonoop { get; set; }

        public decimal? N42Pdif { get; set; }

        public decimal? N43Vicmsmonodif { get; set; }

        public decimal? N43aQbcmonoret { get; set; }

        public decimal? N44Adremicmsret { get; set; }

        public decimal? N45Vicmsmonoret { get; set; }

        //-------Reforma Tributária-------//

        public decimal? UB16_VBC { get; set; }

        public string? UB17_UFID { get; set; }

        public string? UB36_MUNICIPIOID { get; set; }

        public decimal? UB18_37_56_PIBSCBS { get; set; }

        public decimal? UB22_41_60_PDIF { get; set; }

        public decimal? UB23_42_61_VDIF { get; set; }

        public decimal? UB25_44_63_VDEVTRIB { get; set; }

        public decimal? UB27_46_65_PREDALIQ { get; set; }

        public decimal? UB28_47_66_PALIQEFET { get; set; }

        public decimal? UB35_54_67_VIBSCBS { get; set; }

        public decimal? UB77_82_VCREDPRESCONDSUS { get; set; }

        public decimal? UB71_72A_72C_PIBSCBS { get; set; }

        public decimal? UB72_72B_72D_VTRIBREGIBS { get; set; }

        public decimal? UB75_80_PCREDPRES { get; set; }

        public decimal? UB76_81_VCREDPRES { get; set; }

        public decimal? UB82B_82D_82F_PIBS { get; set; }

        public decimal? UB82C_82E_82G_VIBS { get; set; }

        public decimal? UB85_QBCMONO { get; set; }

        public decimal? UB86_ADREMIBS { get; set; }

        public decimal? UB87_ADREMCBS { get; set; }

        public decimal? UB88_VIBSMONO { get; set; }

        public decimal? UB88_VCBSMONO { get; set; }

        public decimal? UB91_QBCMONORETEN { get; set; }

        public decimal? UB92_ADREMIBSRETEN { get; set; }

        public decimal? UB93_VIBSMONORETEN { get; set; }

        public decimal? UB93A_ADREMCBSRETEN { get; set; }

        public decimal? UB93B_VCBSMONORETEN { get; set; }

        public decimal? UB95_QBCMONORET { get; set; }

        public decimal? UB96_ADREMIBSRET { get; set; }

        public decimal? UB97_VIBSMONORET { get; set; }

        public decimal? UB98_ADREMCBSRET { get; set; }

        public decimal? UB98A_VCBSMONORET { get; set; }

        public decimal? UB100_PDIFIBS { get; set; }

        public decimal? UB101_VIBSMONODIF { get; set; }

        public decimal? UB102_PDIFCBS { get; set; }

        public decimal? UB103_VCBSMONODIF { get; set; }

        public decimal? UB104_VTOTIBSMONOITEM { get; set; }

        public decimal? UB105_VTOTCBSMONOITEM { get; set; }

        public decimal? UB05_VBCIS { get; set; }

        public decimal? UB06_PIS { get; set; }

        public decimal? UB06_PISESPEC { get; set; }

        public decimal? UB10_QTRIB { get; set; }

        public decimal? UB11_VIS { get; set; }

        public decimal? UB107_108_VIBS { get; set; }

        public string? UB110_TPCREDPRESIBSZFM { get; set; }

        public decimal? UB111_VCREDPRESIBSZFM { get; set; }

        //-------------------------------------------------------//
        public DtoGetAA037Imp? NavAA037Imp { get; set; }
    }
}

using CSBS101._82Application.MapperAA00X.AA030;
using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD061;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X
{
    public static class DD061Mapper
    {
        public static DtoGetDD061 ToDtoGetDD061(this CSICP_DD061 entity)
        {
            return new DtoGetDD061
            {
                TenantId = entity.TenantId,
                Dd061Id = entity.Dd061Id,
                Dd060Id = entity.Dd060Id,
                Dd061ImpostoId = entity.Dd061ImpostoId,
                Dd061Produtoid = entity.Dd061Produtoid,
                Dd061Codgproduto = entity.Dd061Codgproduto,
                Dd061ImpostoidGeneric = entity.Dd061ImpostoidGeneric,
                Dd061CodgImposto = entity.Dd061CodgImposto,
                Dd061Cst = entity.Dd061Cst,
                Dd061Cfop = entity.Dd061Cfop,
                Dd061Descimposto = entity.Dd061Descimposto,
                Dd061ValorContabil = entity.Dd061ValorContabil,
                Dd061BaseCalculo = entity.Dd061BaseCalculo,
                Dd061Aliquota = entity.Dd061Aliquota,
                Dd061Valorimposto = entity.Dd061Valorimposto,
                Dd061Percreducbase = entity.Dd061Percreducbase,
                Dd061Vredbcicms = entity.Dd061Vredbcicms,
                Dd061Isento = entity.Dd061Isento,
                Dd061Outros = entity.Dd061Outros,
                Dd061Cancelamentos = entity.Dd061Cancelamentos,
                Dd061Descontos = entity.Dd061Descontos,
                Dd061Lucroestimado = entity.Dd061Lucroestimado,
                Dd061Vltribaux = entity.Dd061Vltribaux,
                Dd061Predbcst = entity.Dd061Predbcst,
                Dd061Vbcst = entity.Dd061Vbcst,
                Dd061Picmsst = entity.Dd061Picmsst,
                Dd061Vicmsst = entity.Dd061Vicmsst,
                Dd061Vbcfcp = entity.Dd061Vbcfcp,
                Dd061Pfcp = entity.Dd061Pfcp,
                Dd061Vfcp = entity.Dd061Vfcp,
                Dd061Vbcfcpst = entity.Dd061Vbcfcpst,
                Dd061Pfcpst = entity.Dd061Pfcpst,
                Dd061Vfcpst = entity.Dd061Vfcpst,
                Dd061Agregasubtribut = entity.Dd061Agregasubtribut,
                Dd061QtdTributada = entity.Dd061QtdTributada,
                Dd061VlrUnidade = entity.Dd061VlrUnidade,
                Dd061VlrImposto = entity.Dd061VlrImposto,
                Dd061SomaIpiBaseId = entity.Dd061SomaIpiBaseId,
                Dd061BaseliqbrutaId = entity.Dd061BaseliqbrutaId,
                Dd061Vbcstret = entity.Dd061Vbcstret,
                Dd061Vicmsstret = entity.Dd061Vicmsstret,
                Dd061Vbcfcpstret = entity.Dd061Vbcfcpstret,
                Dd061Pfcpstret = entity.Dd061Pfcpstret,
                Dd061Vfcpstret = entity.Dd061Vfcpstret,
                Dd061Vsuframa = entity.Dd061Vsuframa,
                Dd061Psuframa = entity.Dd061Psuframa,
                Dd061Vbcsuframa = entity.Dd061Vbcsuframa,
                Dd061VicmsDesonerado = entity.Dd061VicmsDesonerado,
                Dd061VpautaIcms = entity.Dd061VpautaIcms,
                Dd061Vbcufdest = entity.Dd061Vbcufdest,
                Dd061Picmsufdest = entity.Dd061Picmsufdest,
                Dd061Picmsinter = entity.Dd061Picmsinter,
                Dd061Picmsinterpart = entity.Dd061Picmsinterpart,
                Dd061Vbcfcpufdest = entity.Dd061Vbcfcpufdest,
                Dd061Pfcpufdest = entity.Dd061Pfcpufdest,
                Dd061Vfcpufdest = entity.Dd061Vfcpufdest,
                Dd061Vicmsufremet = entity.Dd061Vicmsufremet,
                Dd061Vicmsufdest = entity.Dd061Vicmsufdest,
                Dd061Pcredsn = entity.Dd061Pcredsn,
                Dd061Vcredicmssn = entity.Dd061Vcredicmssn,
                Dd061Impostodevol = entity.Dd061Impostodevol,
                Dd061Pdevol = entity.Dd061Pdevol,
                Dd061Ipi = entity.Dd061Ipi,
                Dd061Vipidevol = entity.Dd061Vipidevol,
                Dd061Vbcefet = entity.Dd061Vbcefet,
                Dd061Picmsefet = entity.Dd061Picmsefet,
                Dd061Vicmsefet = entity.Dd061Vicmsefet,
                Dd061Predbcefet = entity.Dd061Predbcefet,
                Dd061Pst = entity.Dd061Pst,
                Dd061Vicmssubstituto = entity.Dd061Vicmssubstituto,
                Dd061Vicmsop = entity.Dd061Vicmsop,
                Dd061Pdif = entity.Dd061Pdif,
                Dd061Vicmsdif = entity.Dd061Vicmsdif,
                N37aQbcmono = entity.N37aQbcmono,
                N38Adremicms = entity.N38Adremicms,
                N39Vicmsmono = entity.N39Vicmsmono,
                N39aQbcmonoreten = entity.N39aQbcmonoreten,
                N40Adremicmsreten = entity.N40Adremicmsreten,
                N41Vicmsmonoreten = entity.N41Vicmsmonoreten,
                N47Predadrem = entity.N47Predadrem,
                N48Motredadrem = entity.N48Motredadrem,
                N41aVicmsmonoop = entity.N41aVicmsmonoop,
                N42Pdif = entity.N42Pdif,
                N43Vicmsmonodif = entity.N43Vicmsmonodif,
                N43aQbcmonoret = entity.N43aQbcmonoret,
                N44Adremicmsret = entity.N44Adremicmsret,
                N45Vicmsmonoret = entity.N45Vicmsmonoret,
                NavAA037Imp = entity.NavAA037Imp?.ToDtoGetAA037Imp(),
                UB16_VBC = entity.UB16_VBC,
                UB17_UFID = entity.UB17_UFID,
                UB36_MUNICIPIOID = entity.UB36_MUNICIPIOID,
                UB18_37_56_PIBSCBS = entity.UB18_37_56_PIBSCBS,
                UB22_41_60_PDIF = entity.UB22_41_60_PDIF,
                UB23_42_61_VDIF = entity.UB23_42_61_VDIF,
                UB25_44_63_VDEVTRIB = entity.UB25_44_63_VDEVTRIB,
                UB27_46_65_PREDALIQ = entity.UB27_46_65_PREDALIQ,
                UB28_47_66_PALIQEFET = entity.UB28_47_66_PALIQEFET,
                UB35_54_67_VIBSCBS = entity.UB35_54_67_VIBSCBS,
                UB77_82_VCREDPRESCONDSUS = entity.UB77_82_VCREDPRESCONDSUS,
                UB71_72A_72C_PIBSCBS = entity.UB71_72A_72C_PIBSCBS,
                UB72_72B_72D_VTRIBREGIBS = entity.UB72_72B_72D_VTRIBREGIBS,
                UB75_80_PCREDPRES = entity.UB75_80_PCREDPRES,
                UB76_81_VCREDPRES = entity.UB76_81_VCREDPRES,
                UB82B_82D_82F_PIBS = entity.UB82B_82D_82F_PIBS,
                UB82C_82E_82G_VIBS = entity.UB82C_82E_82G_VIBS,
                UB85_QBCMONO = entity.UB85_QBCMONO,
                UB86_ADREMIBS = entity.UB86_ADREMIBS,
                UB87_ADREMCBS = entity.UB87_ADREMCBS,
                UB88_VIBSMONO = entity.UB88_VIBSMONO,
                UB88_VCBSMONO = entity.UB88_VCBSMONO,
                UB91_QBCMONORETEN = entity.UB91_QBCMONORETEN,
                UB92_ADREMIBSRETEN = entity.UB92_ADREMIBSRETEN,
                UB93_VIBSMONORETEN = entity.UB93_VIBSMONORETEN,
                UB93A_ADREMCBSRETEN = entity.UB93A_ADREMCBSRETEN,
                UB93B_VCBSMONORETEN = entity.UB93B_VCBSMONORETEN,
                UB95_QBCMONORET = entity.UB95_QBCMONORET,
                UB96_ADREMIBSRET = entity.UB96_ADREMIBSRET,
                UB97_VIBSMONORET = entity.UB97_VIBSMONORET,
                UB98_ADREMCBSRET = entity.UB98_ADREMCBSRET,
                UB98A_VCBSMONORET = entity.UB98A_VCBSMONORET,
                UB100_PDIFIBS = entity.UB100_PDIFIBS,
                UB101_VIBSMONODIF = entity.UB101_VIBSMONODIF,
                UB102_PDIFCBS = entity.UB102_PDIFCBS,
                UB103_VCBSMONODIF = entity.UB103_VCBSMONODIF,
                UB104_VTOTIBSMONOITEM = entity.UB104_VTOTIBSMONOITEM,
                UB105_VTOTCBSMONOITEM = entity.UB105_VTOTCBSMONOITEM,
                UB05_VBCIS = entity.UB05_VBCIS,
                UB06_PIS = entity.UB06_PIS,
                UB06_PISESPEC = entity.UB06_PISESPEC,
                UB10_QTRIB = entity.UB10_QTRIB,
                UB11_VIS = entity.UB11_VIS,
                UB107_108_VIBS = entity.UB107_108_VIBS,
                UB110_TPCREDPRESIBSZFM = entity.UB110_TPCREDPRESIBSZFM,
                UB111_VCREDPRESIBSZFM = entity.UB111_VCREDPRESIBSZFM,
            };
        }
    }
}



















using CSBS101._82Application.Dto.BB00X.BB027;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027;
using CSCore.Application.Dto.Dtos.DD.DD061;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.Staticas.AA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.DD
{
    public static class DD061CfgImpMapper
    {
        public static DtoGetDD061CfgImp ToDtoGetDD061CfgImp(this CSICP_DD061Cfgimp entity)
        {
            if (entity == null) return null!;
            return new DtoGetDD061CfgImp
            {
                TenantId = entity.TenantId,
                Dd060Id = entity.Dd060Id,
                Dd061Bb027Id = entity.Dd061Bb027Id,
                Dd061Bb027bCfgimpId = entity.Dd061Bb027bCfgimpId,
                Dd061Bb027bCodgcst = entity.Dd061Bb027bCodgcst,
                Dd061Bb027bRegimeId = entity.Dd061Bb027bRegimeId,
                Dd061Bb027bOrigemId = entity.Dd061Bb027bOrigemId,
                Dd061Bb027bCstIcmsId = entity.Dd061Bb027bCstIcmsId,
                Dd061Bb027bCstIpiId = entity.Dd061Bb027bCstIpiId,
                Dd061Bb027bCstPisId = entity.Dd061Bb027bCstPisId,
                Dd061NatBcCredPis = entity.Dd061NatBcCredPis,
                Dd061Bb027bCstCofinsId = entity.Dd061Bb027bCstCofinsId,
                Dd061NatBcCredCofins = entity.Dd061NatBcCredCofins,
                Dd061Bb027bInfornf = entity.Dd061Bb027bInfornf,
                Dd061Bb027bInforipi = entity.Dd061Bb027bInforipi,
                Dd061Bb027bInforpis = entity.Dd061Bb027bInforpis,
                Dd061Bb027bInforcofins = entity.Dd061Bb027bInforcofins,
                Dd061Bb027bModbcId = entity.Dd061Bb027bModbcId,
                Dd061Bb027bMotdesoneracao = entity.Dd061Bb027bMotdesoneracao,
                Dd061Bb027bUfDestId = entity.Dd061Bb027bUfDestId,
                Dd061Bb027bClassecontaId = entity.Dd061Bb027bClassecontaId,
                Dd061Bb027bCfopStaticaId = entity.Dd061Bb027bCfopStaticaId,
                Dd061Bb027bModalbcIcmsSt = entity.Dd061Bb027bModalbcIcmsSt,
                Dd061Bb027bAliquota = entity.Dd061Bb027bAliquota,
                Dd061Bb027bReducaobase = entity.Dd061Bb027bReducaobase,
                Dd061Bb027bMp255Id = entity.Dd061Bb027bMp255Id,
                Dd061Bb027bReducaobcst = entity.Dd061Bb027bReducaobcst,
                Dd061Bb027CfopId = entity.Dd061Bb027CfopId,
                Dd061Bb027bCfopExcecaoId = entity.Dd061Bb027bCfopExcecaoId,
                Dd061Bb027bCenquadIpiId = entity.Dd061Bb027bCenquadIpiId,
                Dd061Bb027bAliqInternauf = entity.Dd061Bb027bAliqInternauf,
                Dd061Bb027bIndpres = entity.Dd061Bb027bIndpres,

                //---------Reforma Tributária-------
                Ub13Ub14RfclasstribId = entity.Ub13Ub14RfclasstribId,
                Dd061RflcId = entity.Dd061RflcId,
                Ub03IsRfclasstribId = entity.Ub03IsRfclasstribId,
                Ub6970RfclasstribregId = entity.Ub6970RfclasstribregId,
                Ub7479Ccredpresid = entity.Ub7479Ccredpresid,
                Dd061RfBb027Id = entity.Dd061RfBb027Id,
                Dd061RfBb027bCfgimpId = entity.Dd061RfBb027bCfgimpId,
                //NavCsicpAa143 = entity.NavCsicpAa143,
                //NavCsicpAa144 = entity.NavCsicpAa144,
                //NavCsicpAa144_1 = entity.NavCsicpAa144_1,
                //NavCsicpAa144_2 = entity.NavCsicpAa144_2,
                //NavAa150Ccredpre = entity.NavAa150Ccredpre,
                NavBB027 = entity.CSICP_BB027?.ToDtoGet(),
                NavBB027Imp = entity.CSICP_BB027_imp?.ToDtoGetBB027ImpSemNavs(),
            };
        }
    }
}




















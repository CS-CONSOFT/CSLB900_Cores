using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027
{
    public class DtoCreateUpdateBB027Imp : IConverteParaEntidade<CSICP_Bb027Imp>
    {
        public string? Bb027Id { get; set; }

        public int? Bb027bImpostosId { get; set; }

        public int? Bb027bCodgfilial { get; set; }

        public int? Bb027bCodgtransacao { get; set; }

        public string? Bb027bCodgcst { get; set; }

        public int? Bb027bRegimeId { get; set; }

        public int? Bb027bOrigemId { get; set; }

        public int? Bb027bCstIcmsId { get; set; }

        public int? Bb027bCstIpiId { get; set; }

        public int? Bb027bCstPisId { get; set; }

        public int? Bb027bNatBcCredPis { get; set; }

        public int? Bb027bCstCofinsId { get; set; }

        public int? Bb027bNatBcCredCofins { get; set; }

        public string? Bb027bInformacoesnf { get; set; }

        public string? Bb027bInformacoesipi { get; set; }

        public string? Bb027bInformacoespis { get; set; }

        public string? Bb027bInformacoescofins { get; set; }

        public int? Bb027bModbcId { get; set; }

        public int? Bb027bMotdesoneracaoid { get; set; }

        public string? Bb027bUfDestId { get; set; }

        public int? Bb027bClassecontaId { get; set; }

        public int? Bb027bModalbcIcmsStId { get; set; }

        public decimal? Bb027bAliquota { get; set; }

        public decimal? Bb027bReducaobase { get; set; }

        public int? Bb027bMp255Id { get; set; }

        public decimal? Bb027bReducaobcst { get; set; }

        public int? Bb027bCfopStaticaId { get; set; }

        public int? Bb027bCenquadIpiId { get; set; }

        public decimal? Bb027bAliqInternauf { get; set; }

        public string? Bb027bHashid { get; set; }

        public bool? Bb027bIsvicmsdesSubtrai { get; set; }

        public int? Bb027bFcalcicmsdesId { get; set; }

        public decimal? Bb027bPicmsDiferido { get; set; }

        public int? Bb027bVicmsdesonsubId { get; set; }

        public int? Bb027cIndpres { get; set; }

        public string? Bb027bCbenef { get; set; }

        public decimal? Bb027bPpropocaodestino { get; set; }

        public long? Bb027bRfclasstribId { get; set; }

        public string? Bb027bRflcId { get; set; }

        public int? Bb027bTpdebcreid { get; set; }

        public decimal? Bb027bPaliqefetregIbsUf { get; set; }

        public decimal? Bb027bPaliqefetregIbsMun { get; set; }

        public decimal? Bb027bPcredpresIbsUf { get; set; }

        public decimal? Bb027bPcredpresIbsMun { get; set; }

        public decimal? Bb027bPcredpresCbs { get; set; }

        public decimal? Bb027bPdifCbs { get; set; }

        public decimal? Bb027bPaliqefetregCbs { get; set; }

        public decimal? Bb027bPdifIbs { get; set; }

        public long? Bb027bIsRfclasstribId2 { get; set; }

        public decimal? Bb027bPreducaoibs { get; set; }

        public decimal? Bb027bPreducaocbs { get; set; }

        public int? Bb027bCcredpreid { get; set; }

        public CSICP_Bb027Imp ToEntity(int tenant, string? id)
        {
            return new CSICP_Bb027Imp
            {
                TenantId = tenant,
                Bb027bId = id!,
                Bb027Id = Bb027Id,
                Bb027bImpostosId = Bb027bImpostosId,
                Bb027bCodgfilial = Bb027bCodgfilial,
                Bb027bCodgtransacao = Bb027bCodgtransacao,
                Bb027bCodgcst = Bb027bCodgcst,
                Bb027bRegimeId = Bb027bRegimeId,
                Bb027bOrigemId = Bb027bOrigemId,
                Bb027bCstIcmsId = Bb027bCstIcmsId,
                Bb027bCstIpiId = Bb027bCstIpiId,
                Bb027bCstPisId = Bb027bCstPisId,
                Bb027bNatBcCredPis = Bb027bNatBcCredPis,
                Bb027bCstCofinsId = Bb027bCstCofinsId,
                Bb027bNatBcCredCofins = Bb027bNatBcCredCofins,
                Bb027bInformacoesnf = Bb027bInformacoesnf,
                Bb027bInformacoesipi = Bb027bInformacoesipi,
                Bb027bInformacoespis = Bb027bInformacoespis,
                Bb027bInformacoescofins = Bb027bInformacoescofins,
                Bb027bModbcId = Bb027bModbcId,
                Bb027bMotdesoneracaoid = Bb027bMotdesoneracaoid,
                Bb027bUfDestId = Bb027bUfDestId,
                Bb027bClassecontaId = Bb027bClassecontaId,
                Bb027bModalbcIcmsStId = Bb027bModalbcIcmsStId,
                Bb027bAliquota = Bb027bAliquota,
                Bb027bReducaobase = Bb027bReducaobase,
                Bb027bMp255Id = Bb027bMp255Id,
                Bb027bReducaobcst = Bb027bReducaobcst,
                Bb027bCfopStaticaId = Bb027bCfopStaticaId,
                Bb027bCenquadIpiId = Bb027bCenquadIpiId,
                Bb027bAliqInternauf = Bb027bAliqInternauf,
                Bb027bHashid = Bb027bHashid,
                Bb027bIsvicmsdesSubtrai = Bb027bIsvicmsdesSubtrai,
                Bb027bFcalcicmsdesId = Bb027bFcalcicmsdesId,
                Bb027bPicmsDiferido = Bb027bPicmsDiferido,
                Bb027bVicmsdesonsubId = Bb027bVicmsdesonsubId,
                Bb027cIndpres = Bb027cIndpres,
                Bb027bCbenef = Bb027bCbenef,
                Bb027bPpropocaodestino = Bb027bPpropocaodestino,
                Bb027bRfclasstribId = Bb027bRfclasstribId,
                Bb027bRflcId = Bb027bRflcId,
                Bb027bTpdebcreid = Bb027bTpdebcreid,
                Bb027bPaliqefetregIbsUf = Bb027bPaliqefetregIbsUf,
                Bb027bPaliqefetregIbsMun = Bb027bPaliqefetregIbsMun,
                Bb027bPcredpresIbsUf = Bb027bPcredpresIbsUf,
                Bb027bPcredpresIbsMun = Bb027bPcredpresIbsMun,
                Bb027bPcredpresCbs = Bb027bPcredpresCbs,
                Bb027bPdifCbs = Bb027bPdifCbs,
                Bb027bPaliqefetregCbs = Bb027bPaliqefetregCbs,
                Bb027bPdifIbs = Bb027bPdifIbs,
                Bb027bIsRfclasstribId2 = Bb027bIsRfclasstribId2,
                Bb027bPreducaoibs = Bb027bPreducaoibs,
                Bb027bPreducaocbs = Bb027bPreducaocbs,
                Bb027bCcredpreid = Bb027bCcredpreid,

            };
        }
    }
}

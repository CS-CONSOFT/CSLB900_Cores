using CSBS101._82Application.Dto.BB00X.BB027;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB02X.BB027;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB027ExtensionMethods
    {
        public static CSICP_Bb027 ToEntity(this Dto_CreateUpdateBB027 dto)
        {
            var entity = new CSICP_Bb027
            {
                Bb027Filial = dto.Bb027Filial,
                Bb027Codigo = dto.Bb027Codigo,
                Bb027Descricao = dto.Bb027Descricao,
                Bb027Baixaestoque = dto.Bb027Baixaestoque,
                Bb027Geracreceber = dto.Bb027Geracreceber,
                Bb027Atualizaprcompra = dto.Bb027Atualizaprcompra,
                Bb027Calcsubstituicao = dto.Bb027Calcsubstituicao,
                Bb027Calculaiss = dto.Bb027Calculaiss,
                Bb027Cfopdentroestado = dto.Bb027Cfopdentroestado,
                Bb027Cfopforaestado = dto.Bb027Cfopforaestado,
                Bb027Agregasubstrib = dto.Bb027Agregasubstrib,
                Bb027Difa = dto.Bb027Difa,
                Bb027Icst = dto.Bb027Icst,
                Bb027Irrf = dto.Bb027Irrf,
                Bb027Pis = dto.Bb027Pis,
                Bb027Cofins = dto.Bb027Cofins,
                Bb027Irpj = dto.Bb027Irpj,
                Bb027Icmsdiferido = dto.Bb027Icmsdiferido,
                Bb027Geraestatistica = dto.Bb027Geraestatistica,
                Bb027Codgcst = dto.Bb027Codgcst,
                Bb027Transdevolucao = dto.Bb027Transdevolucao,
                Bb027Reducaoicms = dto.Bb027Reducaoicms,
                Bb027Reducaoipi = dto.Bb027Reducaoipi,
                Bb027Reducaoicmsst = dto.Bb027Reducaoicmsst,
                Bb027Reducaoiss = dto.Bb027Reducaoiss,
                Empresaid = dto.Empresaid,
                Bb027EntsaiId = dto.Bb027EntsaiId,
                Bb027PodertercId = dto.Bb027PodertercId,
                Bb027CalcicmsId = dto.Bb027CalcicmsId,
                Bb027CalcipiId = dto.Bb027CalcipiId,
                Bb027SomaipiBaseicmsId = dto.Bb027SomaipiBaseicmsId,
                Bb027IpiBrutoId = dto.Bb027IpiBrutoId,
                Bb027BaseicmsbrutaliqId = dto.Bb027BaseicmsbrutaliqId,
                Bb027BasesubsbrutaliqId = dto.Bb027BasesubsbrutaliqId,
                Bb027CfopStaticaId = dto.Bb027CfopStaticaId,
                Bb027TdevolucaoId = dto.Bb027TdevolucaoId,
                Bb027RegimeId = dto.Bb027RegimeId,
                Bb027CfopForaestadoId = dto.Bb027CfopForaestadoId,
                Bb027Hashid = dto.Bb027Hashid,
                Bb027Descnatoper = dto.Bb027Descnatoper,
                Bb027CalcajusteicmsId = dto.Bb027CalcajusteicmsId,
                Bb027CodgajusteicmsId = dto.Bb027CodgajusteicmsId,
                //Bb027Icmsdiferidoid = dto.Bb027Icmsdiferidoid,
                Bb027PicmsDiferido = dto.Bb027PicmsDiferido
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB027 ToDtoGet(this CSICP_Bb027 entity)
        {
            return new Dto_GetBB027
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb027Filial = entity.Bb027Filial,
                Bb027Codigo = entity.Bb027Codigo,
                Bb027Descricao = entity.Bb027Descricao,
                Bb027Baixaestoque = entity.Bb027Baixaestoque,
                Bb027Geracreceber = entity.Bb027Geracreceber,
                Bb027Atualizaprcompra = entity.Bb027Atualizaprcompra,
                Bb027Calcsubstituicao = entity.Bb027Calcsubstituicao,
                Bb027Calculaiss = entity.Bb027Calculaiss,
                Bb027Cfopdentroestado = entity.Bb027Cfopdentroestado,
                Bb027Cfopforaestado = entity.Bb027Cfopforaestado,
                Bb027Agregasubstrib = entity.Bb027Agregasubstrib,
                Bb027Difa = entity.Bb027Difa,
                Bb027Icst = entity.Bb027Icst,
                Bb027Irrf = entity.Bb027Irrf,
                Bb027Pis = entity.Bb027Pis,
                Bb027Cofins = entity.Bb027Cofins,
                Bb027Irpj = entity.Bb027Irpj,
                Bb027Icmsdiferido = entity.Bb027Icmsdiferido,
                Bb027Geraestatistica = entity.Bb027Geraestatistica,
                Bb027Codgcst = entity.Bb027Codgcst,
                Bb027Transdevolucao = entity.Bb027Transdevolucao,
                Bb027Reducaoicms = entity.Bb027Reducaoicms,
                Bb027Reducaoipi = entity.Bb027Reducaoipi,
                Bb027Reducaoicmsst = entity.Bb027Reducaoicmsst,
                Bb027Reducaoiss = entity.Bb027Reducaoiss,
                Empresaid = entity.Empresaid,
                Bb027EntsaiId = entity.Bb027EntsaiId,
                Bb027PodertercId = entity.Bb027PodertercId,
                Bb027CalcicmsId = entity.Bb027CalcicmsId,
                Bb027CalcipiId = entity.Bb027CalcipiId,
                Bb027SomaipiBaseicmsId = entity.Bb027SomaipiBaseicmsId,
                Bb027IpiBrutoId = entity.Bb027IpiBrutoId,
                Bb027BaseicmsbrutaliqId = entity.Bb027BaseicmsbrutaliqId,
                Bb027BasesubsbrutaliqId = entity.Bb027BasesubsbrutaliqId,
                Bb027CfopStaticaId = entity.Bb027CfopStaticaId,
                Bb027TdevolucaoId = entity.Bb027TdevolucaoId,
                Bb027RegimeId = entity.Bb027RegimeId,
                Bb027CfopForaestadoId = entity.Bb027CfopForaestadoId,
                Bb027Hashid = entity.Bb027Hashid,
                Bb027Descnatoper = entity.Bb027Descnatoper,
                Bb027CalcajusteicmsId = entity.Bb027CalcajusteicmsId,
                Bb027CodgajusteicmsId = entity.Bb027CodgajusteicmsId,
                //Bb027Icmsdiferidoid = entity.Bb027Icmsdiferidoid,
                Bb027PicmsDiferido = entity.Bb027PicmsDiferido,
                NavBb027Tdevolucao = entity.Bb027Tdevolucao?.ToDtoGet()
            };
        }

        public static Dto_GetBB027Simples ToDtoGetSimples(this CSICP_Bb027 entity)
        {
            return new Dto_GetBB027Simples
            {

                Id = entity.Id,
                Bb027Filial = entity.Bb027Filial,
                Bb027Codigo = entity.Bb027Codigo,
                Bb027Descricao = entity.Bb027Descricao,
                Bb027Descnatoper = entity.Bb027Descnatoper
            };
        }

        public static DtoGetBB027Imp ToDtoGetBB027ImpSemNavs(this CSICP_Bb027Imp entity)
        {
            return new DtoGetBB027Imp
            {
                TenantId = entity.TenantId,
                Bb027bId = entity.Bb027bId,
                Bb027Id = entity.Bb027Id,
                Bb027bImpostosId = entity.Bb027bImpostosId,
                Bb027bCodgfilial = entity.Bb027bCodgfilial,
                Bb027bCodgtransacao = entity.Bb027bCodgtransacao,
                Bb027bCodgcst = entity.Bb027bCodgcst,
                Bb027bRegimeId = entity.Bb027bRegimeId,
                Bb027bOrigemId = entity.Bb027bOrigemId,
                Bb027bCstIcmsId = entity.Bb027bCstIcmsId,
                Bb027bCstIpiId = entity.Bb027bCstIpiId,
                Bb027bCstPisId = entity.Bb027bCstPisId,
                Bb027bNatBcCredPis = entity.Bb027bNatBcCredPis,
                Bb027bCstCofinsId = entity.Bb027bCstCofinsId,
                Bb027bNatBcCredCofins = entity.Bb027bNatBcCredCofins,
                Bb027bInformacoesnf = entity.Bb027bInformacoesnf,
                Bb027bInformacoesipi = entity.Bb027bInformacoesipi,
                Bb027bInformacoespis = entity.Bb027bInformacoespis,
                Bb027bInformacoescofins = entity.Bb027bInformacoescofins,
                Bb027bModbcId = entity.Bb027bModbcId,
                Bb027bMotdesoneracaoid = entity.Bb027bMotdesoneracaoid,
                Bb027bUfDestId = entity.Bb027bUfDestId,
                Bb027bClassecontaId = entity.Bb027bClassecontaId,
                Bb027bModalbcIcmsStId = entity.Bb027bModalbcIcmsStId,
                Bb027bAliquota = entity.Bb027bAliquota,
                Bb027bReducaobase = entity.Bb027bReducaobase,
                Bb027bMp255Id = entity.Bb027bMp255Id,
                Bb027bReducaobcst = entity.Bb027bReducaobcst,
                Bb027bCfopStaticaId = entity.Bb027bCfopStaticaId,
                Bb027bCenquadIpiId = entity.Bb027bCenquadIpiId,
                Bb027bAliqInternauf = entity.Bb027bAliqInternauf,
                Bb027bHashid = entity.Bb027bHashid,
                Bb027bIsvicmsdesSubtrai = entity.Bb027bIsvicmsdesSubtrai,
                Bb027bFcalcicmsdesId = entity.Bb027bFcalcicmsdesId,
                Bb027bPicmsDiferido = entity.Bb027bPicmsDiferido,
                Bb027bVicmsdesonsubId = entity.Bb027bVicmsdesonsubId,
                Bb027cIndpres = entity.Bb027cIndpres,
                Bb027bCbenef = entity.Bb027bCbenef,
                Bb027bPpropocaodestino = entity.Bb027bPpropocaodestino,
                Bb027bRfclasstribId = entity.Bb027bRfclasstribId,
                Bb027bRflcId = entity.Bb027bRflcId,
                Bb027bTpdebcreid = entity.Bb027bTpdebcreid,
                Bb027bPaliqefetregIbsUf = entity.Bb027bPaliqefetregIbsUf,
                Bb027bPaliqefetregIbsMun = entity.Bb027bPaliqefetregIbsMun,
                Bb027bPcredpresIbsUf = entity.Bb027bPcredpresIbsUf,
                Bb027bPcredpresIbsMun = entity.Bb027bPcredpresIbsMun,
                Bb027bPcredpresCbs = entity.Bb027bPcredpresCbs,
                Bb027bPdifCbs = entity.Bb027bPdifCbs,
                Bb027bPaliqefetregCbs = entity.Bb027bPaliqefetregCbs,
                Bb027bPdifIbs = entity.Bb027bPdifIbs,
                Bb027bIsRfclasstribId2 = entity.Bb027bIsRfclasstribId2,
                Bb027bPreducaoibs = entity.Bb027bPreducaoibs,
                Bb027bPreducaocbs = entity.Bb027bPreducaocbs,
                Bb027bCcredpreid = entity.Bb027bCcredpreid,
            };
        }
    }
}

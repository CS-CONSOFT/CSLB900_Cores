using CSBS101._82Application.Dto.BB00X.BB002;
using CSBS101._82Application.Dto.BB00X.BB002.CSC;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.BB00X.BB002
{
    public static class BB002ExtensionMethods
    {
        public static CSICP_BB002 ToEntity(this Dto_BB002CreateUpdate dto)
        {
            var entity = new CSICP_BB002
            {
                Bb002Codigo = dto.Bb002Codigo,
                Bb002Grupoempresa = dto.Bb002Grupoempresa,
                CixUsacix = dto.CixUsacix,
                CixToken = dto.CixToken,
                CixNrodominio = dto.CixNrodominio,
                CixUrlWebservicecix = dto.CixUrlWebservicecix,
                Bb003AwsBucket = dto.Bb003AwsBucket,
                Bb003Awsregion = dto.Bb003Awsregion,
                Bb003Awsaccesskeyid = dto.Bb003Awsaccesskeyid,
                Bb003Awssecretaccesskey = dto.Bb003Awssecretaccesskey,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB002 ToDtoGet(this CSICP_BB002 entity)
        {
            return new Dto_GetBB002
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb002Codigo = entity.Bb002Codigo,
                Bb002Grupoempresa = entity.Bb002Grupoempresa,
                CixUsacix = entity.CixUsacix,
                CixToken = entity.CixToken,
                CixNrodominio = entity.CixNrodominio,
                CixUrlWebservicecix = entity.CixUrlWebservicecix,
                Bb003AwsBucket = entity.Bb003AwsBucket,
                Bb003Awsregion = entity.Bb003Awsregion,
                Bb003Awsaccesskeyid = entity.Bb003Awsaccesskeyid,
                Bb003Awssecretaccesskey = entity.Bb003Awssecretaccesskey,
            };
        }


        //CSC
        public static CSICP_BB002CSC ToEntity(this Dto_BB002CSC_CreateUpdate dto)
        {
            return new CSICP_BB002CSC
            {
                Bb002Id = dto.Bb002Id,
                Bb002Cidtoken = dto.Bb002Cidtoken,
                Bb002Csc = dto.Bb002Csc,
                Bb002Dataativacao = dto.Bb002Dataativacao.ConverteStringVaziaParaDataNula(),
                Bb002Datarevogacao = dto.Bb002Datarevogacao.ConverteStringVaziaParaDataNula(),
                Bb002Motivorevogacao = dto.Bb002Motivorevogacao,
                Bb002Isrevogado = dto.Bb002Isrevogado,
                Bb001Estabid = dto.Bb001Estabid
            };
        }

        public static Dto_GetBB002CSC ToDtoGet(this CSICP_BB002CSC entity)
        {
            return new Dto_GetBB002CSC
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb002Id = entity.Bb002Id,
                Bb002Cidtoken = entity.Bb002Cidtoken,
                Bb002Csc = entity.Bb002Csc,
                Bb002Dataativacao = entity.Bb002Dataativacao,
                Bb002Datarevogacao = entity.Bb002Datarevogacao,
                Bb002Motivorevogacao = entity.Bb002Motivorevogacao,
                Bb002Isrevogado = entity.Bb002Isrevogado,
                Bb001Estabid = entity.Bb001Estabid
            };
        }
    }
}

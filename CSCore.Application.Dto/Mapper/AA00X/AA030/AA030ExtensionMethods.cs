using CSBS101._82Application.Dto.AA00X;
using CSBS101.C82Application.Dto.AA00X.AA030;
using CSCore.Application.Dto.Dtos.Basico_AA.AA00X;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.MapperAA00X.AA030
{
    public static class AA030ExtensionMethods
    {
        public static Dto_GetAA030 ToDtoGet(this CSICP_AA030 entity)
        {
            return new Dto_GetAA030
            {
                TenantId = entity.TenantId,
                Aa030Id = entity.Aa030Id,
                Aa030Descricao = entity.Aa030Descricao,
                Aa030Tptokenid = entity.Aa030Tptokenid,
                Aa030Estabid = entity.Aa030Estabid,
                Aa030AwsBucket = entity.Aa030AwsBucket,
                Aa030Awsregion = entity.Aa030Awsregion,
                Aa030Awsaccesskeyid = entity.Aa030Awsaccesskeyid,
                Aa030Awssecretaccesske = entity.Aa030Awssecretaccesske,
                Aa030Ospushtoken = entity.Aa030Ospushtoken,
                Aa030User = entity.Aa030User,
                Aa030Senha = entity.Aa030Senha,
                Aa030_PathCertificado = entity.Aa030_PathCertificado,
                NavAa030Tptoken = entity.Aa030Tptoken,

            };
        }


        public static DtoGetAA037Imp ToDtoGetAA037Imp(this CSICP_AA037Imp entity)
        {
            return new DtoGetAA037Imp
            {
                Id = entity.Id,
                Label = entity.Label,
            };
        }
    


        //Dto Create to Entity
        //Aqui o tenant e o ID nao vao por conta de serem setados na classe de serviço
        public static CSICP_AA030 ToEntity(this Dto_CreateUpdateAA030 dto)
        {
            var entity = new CSICP_AA030()
            {

                Aa030Descricao = dto.Aa030Descricao,
                Aa030Tptokenid = dto.Aa030Tptokenid,
                Aa030Estabid = dto.Aa030Estabid,
                Aa030AwsBucket = dto.Aa030AwsBucket,
                Aa030Awsregion = dto.Aa030Awsregion,
                Aa030Awsaccesskeyid = dto.Aa030Awsaccesskeyid,
                Aa030Awssecretaccesske = dto.Aa030Awssecretaccesske,
                Aa030Ospushtoken = dto.Aa030Ospushtoken,
                Aa030User = dto.Aa030User,
                Aa030Senha = dto.Aa030Senha,
                Aa030_PathCertificado = dto.Aa030_PathCertificado,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

    }
}



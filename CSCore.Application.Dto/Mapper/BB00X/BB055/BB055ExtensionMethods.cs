
using CSBS101._82Application.Dto.BB00X.BB05X.BB055;
using CSCore.Application.Dto.Dtos.Consumidor.Profissional;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB05X.BB055
{
    public static class BB055ExtensionMethods
    {
        public static CSICP_Bb055 ToEntity(this Dto_CreateUpdateBB055 dto)
        {
            var entity = new CSICP_Bb055
            {
                Bb055Nome = dto.Bb055Nome,
                Bb055Email = dto.Bb055Email,
                Bb055Telefone = dto.Bb055Telefone,
                Bb055IsActive = true,
                Bb055Logradouro = dto.Bb055Logradouro,
                Bb055Numero = dto.Bb055Numero,
                Bb055Complemento = dto.Bb055Complemento,
                Bb055Perimetro = dto.Bb055Perimetro,
                Bb055Bairro = dto.Bb055Bairro,
                Bb055Cidadeid = dto.Bb055Cidadeid,
                Bb055UfId = dto.Bb055UfId,
                Bb055Cep = dto.Bb055Cep,
                Bb055Paisid = dto.Bb055Paisid,
                Bb055Nomecontato = dto.Bb055Nomecontato,
                Bb055CelularContato = dto.Bb055CelularContato,
                Bb055EmailContato = dto.Bb055EmailContato,
                Bb055UrlLogo = dto.Bb055UrlLogo,
                Bb055UrlAvatar = dto.Bb055UrlAvatar,
                Bb055Desespecialidade = dto.Bb055Desespecialidade,
                Bb055UrlSeloqld = dto.Bb055UrlSeloqld,
                Bb055Ratemedia = dto.Bb055Ratemedia,
                Bb055Tags = dto.Bb055Tags
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }


        public static DtoGetProfissional ToDtoGetProf(this CSICP_Bb055 entity)
        {
            return new DtoGetProfissional
            {
                bb055_Id = entity.Bb055Id,
                BB055_Nome = entity.Bb055Nome,
                BB055_EMail = entity.Bb055Email,
                BB055_Telefone = entity.Bb055Telefone,
                BB055_Is_Active = entity.Bb055IsActive,
                BB055_Logradouro = entity.Bb055Logradouro,
                BB055_Numero = entity.Bb055Numero,
                BB055_Complemento = entity.Bb055Complemento,
                BB055_Perimetro = entity.Bb055Perimetro,
                BB055_Bairro = entity.Bb055Bairro,
                BB055_CidadeID = entity.Bb055Cidadeid,
                BB055_UF_ID = entity.Bb055UfId,
                BB055_CEP = entity.Bb055Cep,
                BB055_PaisID = entity.Bb055Paisid,
                BB055_NomeContato = entity.Bb055Nomecontato,
                BB055_Celular_Contato = entity.Bb055CelularContato,
                BB055_EMail_Contato = entity.Bb055EmailContato,
                BB055_URL_Logo = entity.Bb055UrlLogo,
                BB055_URL_Avatar = entity.Bb055UrlAvatar,
                BB055_DesEspecialidade = entity.Bb055Desespecialidade,
                BB055_URL_SeloQld = entity.Bb055UrlSeloqld,
                bb055_RateMedia = entity.Bb055Ratemedia,
                Cidade = entity.Nav_CSICP_AA028 != null ? entity.Nav_CSICP_AA028.Aa028Cidade! : string.Empty,
                UF = entity.Nav_CSICP_AA027 != null ? entity.Nav_CSICP_AA027.Aa027Sigla! : string.Empty,
            };
        }

        public static Dto_GetBB055 ToDtoGet(this CSICP_Bb055 entity)
        {
            return new Dto_GetBB055
            {
                TenantId = entity.TenantId,
                Bb055Id = entity.Bb055Id,
                Bb055Nome = entity.Bb055Nome,
                Bb055Email = entity.Bb055Email,
                Bb055Telefone = entity.Bb055Telefone,
                Bb055IsActive = entity.Bb055IsActive,
                Bb055Logradouro = entity.Bb055Logradouro,
                Bb055Numero = entity.Bb055Numero,
                Bb055Complemento = entity.Bb055Complemento,
                Bb055Perimetro = entity.Bb055Perimetro,
                Bb055Bairro = entity.Bb055Bairro,
                Bb055Cidadeid = entity.Bb055Cidadeid,
                Bb055UfId = entity.Bb055UfId,
                Bb055Cep = entity.Bb055Cep,
                Bb055Paisid = entity.Bb055Paisid,
                Bb055Nomecontato = entity.Bb055Nomecontato,
                Bb055CelularContato = entity.Bb055CelularContato,
                Bb055EmailContato = entity.Bb055EmailContato,
                Bb055UrlLogo = entity.Bb055UrlLogo,
                Bb055UrlAvatar = entity.Bb055UrlAvatar,
                Bb055Desespecialidade = entity.Bb055Desespecialidade,
                Bb055UrlSeloqld = entity.Bb055UrlSeloqld,
                Bb055Ratemedia = entity.Bb055Ratemedia,
                Bb055Tags = entity.Bb055Tags
            };
        }
    }
}

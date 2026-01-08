using CSCore.Application.Dto.Dtos.DD.DD00X.DD000W;
using CSCore.Domain.CS_Models.CSICP_DD;

namespace CSCore.Application.Dto.Mapper.DD00X.DD000W;

public static class DD000WExtensionMethods
{
    public static DtoGetDD000W ToDtoGetDD000W(this CSICP_DD000W entity)
    {
        return new DtoGetDD000W
        {
            TenantId = entity.TenantId,
            Dd000Id = entity.Dd000Id,
            Dd000ConfigId = entity.Dd000ConfigId,
            Dd000NfcfId = entity.Dd000NfcfId,
            Dd000ServnfeId = entity.Dd000ServnfeId,
            Dd000Url = entity.Dd000Url,
            Dd000Isactive = entity.Dd000Isactive,
            Dd000UrlHomologacao = entity.Dd000UrlHomologacao,
            Dd000UfOrgaoId = entity.Dd000UfOrgaoId,
            NavDD000Config = entity.NavDD000Config,
            NavDD000Nfcf = entity.NavDD000Nfcf,
            NavDD000Servnfe = entity.NavDD000Servnfe
        };
    }

    public static DtoGetDD000WSimples ToDtoGetDD000WSimples(this CSICP_DD000W entity)
    {
        return new DtoGetDD000WSimples
        {
            TenantId = entity.TenantId,
            Dd000Id = entity.Dd000Id,
            Dd000ConfigId = entity.Dd000ConfigId,
            Dd000NfcfId = entity.Dd000NfcfId,
            Dd000ServnfeId = entity.Dd000ServnfeId,
            Dd000Url = entity.Dd000Url,
            Dd000Isactive = entity.Dd000Isactive,
            Dd000UrlHomologacao = entity.Dd000UrlHomologacao,
            Dd000UfOrgaoId = entity.Dd000UfOrgaoId
        };
    }
}
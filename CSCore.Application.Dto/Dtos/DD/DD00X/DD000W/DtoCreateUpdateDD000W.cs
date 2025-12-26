using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD00X.DD000W;

public class DtoCreateUpdateDD000W : IConverteParaEntidade<CSICP_DD000W>
{
    public string? Dd000ConfigId { get; set; }

    public int? Dd000NfcfId { get; set; }

    public int? Dd000ServnfeId { get; set; }

    public string? Dd000Url { get; set; }

    public bool? Dd000Isactive { get; set; }

    public string? Dd000UrlHomologacao { get; set; }

    public string? Dd000UfOrgaoId { get; set; }

    public CSICP_DD000W ToEntity(int tenant, string? id)
    {
        return new CSICP_DD000W
        {
            TenantId = tenant,
            Dd000Id = id!,
            Dd000ConfigId = Dd000ConfigId,
            Dd000NfcfId = Dd000NfcfId,
            Dd000ServnfeId = Dd000ServnfeId,
            Dd000Url = Dd000Url,
            Dd000Isactive = Dd000Isactive,
            Dd000UrlHomologacao = Dd000UrlHomologacao,
            Dd000UfOrgaoId = Dd000UfOrgaoId
        };
    }
}
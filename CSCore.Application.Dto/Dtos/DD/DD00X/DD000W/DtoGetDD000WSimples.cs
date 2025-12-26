using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.DD.DD00X.DD000W;

public class DtoGetDD000WSimples
{
    public int TenantId { get; set; }

    public string Dd000Id { get; set; } = null!;

    public string? Dd000ConfigId { get; set; }

    public int? Dd000NfcfId { get; set; }

    public int? Dd000ServnfeId { get; set; }

    public string? Dd000Url { get; set; }

    public bool? Dd000Isactive { get; set; }

    public string? Dd000UrlHomologacao { get; set; }

    public string? Dd000UfOrgaoId { get; set; }
}
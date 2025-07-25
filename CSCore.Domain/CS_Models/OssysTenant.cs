namespace CSCore.Domain.CS_Models;

public partial class OssysTenant
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? EspaceId { get; set; }

    public bool IsActive { get; set; }
}

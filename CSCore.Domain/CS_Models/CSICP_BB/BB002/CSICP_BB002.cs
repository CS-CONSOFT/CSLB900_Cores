namespace CSCore.Domain;

public partial class CSICP_BB002
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb002Codigo { get; set; }

    public string? Bb002Grupoempresa { get; set; }

    public bool? CixUsacix { get; set; } = default;

    public string? CixToken { get; set; }

    public int? CixNrodominio { get; set; }

    public string? CixUrlWebservicecix { get; set; }

    public string? Bb003AwsBucket { get; set; }

    public string? Bb003Awsregion { get; set; }

    public string? Bb003Awsaccesskeyid { get; set; }

    public string? Bb003Awssecretaccesskey { get; set; }

    //  public ICollection<CSICP_BB002CSC> OsusrE9aCsicpBb002Cscs { get; set; } = new List<CSICP_BB002CSC>();
}

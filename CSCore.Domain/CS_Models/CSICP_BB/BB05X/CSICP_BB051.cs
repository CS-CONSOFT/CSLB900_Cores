
using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain;

public partial class CSICP_Bb051
{
    public int TenantId { get; set; }

    [Key]
    public string Bb051Id { get; set; } = null!;

    public string? Bb050Id { get; set; }

    public string? Bb051Formapagtoid { get; set; }

    public int? Bb051Maxparcela { get; set; }

    public CSICP_Bb050? Bb050 { get; set; }

    public CSICP_Bb026? Bb051Formapagto { get; set; }
}

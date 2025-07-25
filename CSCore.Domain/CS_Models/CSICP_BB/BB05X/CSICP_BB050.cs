using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain;

public partial class CSICP_Bb050
{
    public int TenantId { get; set; }

    [Key]
    public string Bb050Id { get; set; } = null!;

    public string? Bb050Empresaid { get; set; }

    public string? Bb050Grupoprodutoid { get; set; }

    public DateTime? Bb050Datainicio { get; set; }

    public DateTime? Bb050Datafinal { get; set; }

    public decimal? Bb050Valorminimo { get; set; }

    //public ICollection<CSICP_Bb051> OsusrE9aCsicpBb051s { get; set; } = new List<CSICP_Bb051>();
}

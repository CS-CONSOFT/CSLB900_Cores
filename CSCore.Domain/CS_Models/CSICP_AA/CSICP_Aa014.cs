

using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Aa014
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Aa014Id { get; set; }

    public string? Aa014Serienfid { get; set; }

    public string? Aa014Usuarioid { get; set; }

    public DateTime? Aa014Dregistro { get; set; }

    public string? Aa014Usuariopropid { get; set; }

    //public CSICP_Aa013? Aa014Serienf { get; set; }
}

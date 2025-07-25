using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG060
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Gg060Id { get; set; }

    public string? Gg060EstabId { get; set; }

    public string? Gg060Grupoid { get; set; }

    public string? Gg060Subgrupoid { get; set; }

    public decimal? Gg060Plucro { get; set; }

    public bool? Gg060Isactive { get; set; }

    public DateTime? Gg060Dregistro { get; set; }

    public decimal? Gg060Pmaxdesconto { get; set; }

    public bool? Gg060Ispadrao { get; set; }

    public CSICP_GG003? NavGg003Grupo { get; set; } = null!;

    public CSICP_GG015? NavGg015Subgrupo { get; set; } = null!;
    public CSICP_BB001? NavBB001Filial { get; set; } = null!;
}

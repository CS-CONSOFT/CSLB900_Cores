using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class Csicp_Sy002
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy002Grupo { get; set; }

    public string? Sy002Descricao { get; set; }

    [Column("sy002_erpid")]
    public int? sy002_erpid { get; set; }

    }

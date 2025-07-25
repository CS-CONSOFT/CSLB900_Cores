using System.ComponentModel.DataAnnotations.Schema;


namespace CSCore.Domain;

public partial class CSICP_Aa041
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Aa041Id { get; set; }

    public int? Aa041TabspedId { get; set; }

    public string? Aa041Codigo { get; set; }

    public string? Aa041Descricao { get; set; }

    public DateTime? Aa041Dinicio { get; set; }

    public DateTime? Aa041Dfinal { get; set; }

    public OsusrNnxSpedInTabela? Aa041Tabsped { get; set; }
}

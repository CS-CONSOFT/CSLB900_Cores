using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Aa007
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string? Aa007Descricao { get; set; }

    public string? Aa007Modeloemail { get; set; }

    public int? Aa007Tipo { get; set; }

    public int? Aa007Uso { get; set; }

    public bool? Isactive { get; set; }
}

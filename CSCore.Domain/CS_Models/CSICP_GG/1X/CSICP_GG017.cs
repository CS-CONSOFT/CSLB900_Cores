using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG017
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Gg017Id { get; set; }

    public string? Gg017Desccategoria { get; set; }

    public int? Gg017Nivel { get; set; }

    public long? Gg017CategoriapaiId { get; set; }

    public CSICP_GG017? NavGg017Categoriapai { get; set; }
}

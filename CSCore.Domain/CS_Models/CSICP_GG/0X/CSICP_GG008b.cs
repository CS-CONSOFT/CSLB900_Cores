using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG008b
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg008bFilialid { get; set; }

    public string? Gg008bProdutoid { get; set; }

    public int? Gg008bFilial { get; set; }

    public int? Gg008bCodgproduto { get; set; }

    public int? Gg008bSeq { get; set; }

    public string? Gg008bRefsimilar { get; set; }

    public DateTime? Gg008bDatavigor { get; set; }

    public int? Gg008bCodgmarca { get; set; }

    public string? Gg008bMarcaid { get; set; }

    [NotMapped]
    public CSICP_GG006? NavGg006Marca { get; set; }

    //public CSICP_GG008? Gg008bProduto { get; set; }
}

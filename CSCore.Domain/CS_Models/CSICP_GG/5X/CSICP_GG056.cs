using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG056
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Gg056Id { get; set; }

    public string? Gg056Protocolnumber { get; set; }

    public string? Gg056Produtoid { get; set; }

    public int? Gg056Codgproduto { get; set; }

    public string? Gg056Codgbarras { get; set; }

    public string? Gg056Saldoid { get; set; }

    public string? Gg056Unidade { get; set; }

    public string? Gg056UsuarioId { get; set; }

    public DateTime? Gg056DataInc { get; set; }

    public DateTime? Gg056HoraInc { get; set; }

    public string? Gg056UsuarioAlt { get; set; }


    public DateTime? Gg056DataAlt { get; set; }

    public DateTime? Gg056HoraAlt { get; set; }

    public long? Gg056IdCol01 { get; set; } = null;

    public long? Gg056IdCol02 { get; set; } = null;

    public decimal? Gg056QtdeCol01 { get; set; } = null;

    public decimal? Gg056QtdeCol02 { get; set; } = null;



    public CSICP_GG056(int tenantId, string? gg056Protocolnumber, string? gg056Produtoid, int? gg056Codgproduto,
        string? gg056Codgbarras, string? gg056Saldoid, string? gg056Unidade, string? gg056UsuarioId)
    {
        TenantId = tenantId;
        Gg056Protocolnumber = gg056Protocolnumber;
        Gg056Produtoid = gg056Produtoid;
        Gg056Codgproduto = gg056Codgproduto;
        Gg056Codgbarras = gg056Codgbarras;
        Gg056Saldoid = gg056Saldoid;
        Gg056Unidade = gg056Unidade;
        Gg056UsuarioId = gg056UsuarioId;
        Gg056DataInc = DateTime.UtcNow.ToLocalTime();
        Gg056HoraInc = DateTime.UtcNow.ToLocalTime();
        Gg056DataAlt = DateTime.UtcNow.ToLocalTime();
    }

    public CSICP_GG056()
    {
    }
}

using System.ComponentModel.DataAnnotations.Schema;


namespace CSCore.Domain.CS_Models.CSICP_AA;

public partial class CSICP_AA030
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Aa030Id { get; set; }

    public string? Aa030Descricao { get; set; }

    public int? Aa030Tptokenid { get; set; }

    public string? Aa030Estabid { get; set; }

    public string? Aa030AwsBucket { get; set; }

    public string? Aa030Awsregion { get; set; }

    public string? Aa030Awsaccesskeyid { get; set; }

    public string? Aa030Awssecretaccesske { get; set; }

    public string? Aa030Ospushtoken { get; set; }

    public string? Aa030User { get; set; }

    public string? Aa030Senha { get; set; }

    public string? Aa030_PathCertificado { get; set; }

    public CSICP_Aa030Tptoken? Aa030Tptoken { get; set; }
}

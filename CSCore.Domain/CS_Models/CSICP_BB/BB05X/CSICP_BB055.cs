using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain;

public partial class CSICP_Bb055
{
    public int TenantId { get; set; }

    [Key]
    public string Bb055Id { get; set; } = null!;

    public string? Bb055Nome { get; set; }

    public string? Bb055Email { get; set; }

    public string? Bb055Telefone { get; set; }

    public bool? Bb055IsActive { get; set; }

    public string? Bb055Logradouro { get; set; }

    public string? Bb055Numero { get; set; }

    public string? Bb055Complemento { get; set; }

    public string? Bb055Perimetro { get; set; }

    public string? Bb055Bairro { get; set; }

    public string? Bb055Cidadeid { get; set; }

    public string? Bb055UfId { get; set; }

    public int? Bb055Cep { get; set; }

    public string? Bb055Paisid { get; set; }

    public string? Bb055Nomecontato { get; set; }

    public string? Bb055CelularContato { get; set; }

    public string? Bb055EmailContato { get; set; }

    public string? Bb055UrlLogo { get; set; }

    public string? Bb055UrlAvatar { get; set; }

    public string? Bb055Desespecialidade { get; set; }

    public string? Bb055UrlSeloqld { get; set; }

    public decimal? Bb055Ratemedia { get; set; }

    public string? Bb055Tags { get; set; }

    public CSICP_Aa027? Nav_CSICP_AA027 { get; set; }
    public CSICP_Aa028? Nav_CSICP_AA028 { get; set; }
}

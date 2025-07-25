using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain;

public partial class CSICP_Bb036Ender
{
    public int TenantId { get; set; }

    [Key]
    public string Bb036Id { get; set; } = null!;

    public string? Bb036Candidatoid { get; set; }

    public string? Bb036Logradouro { get; set; }

    public string? Bb036Numero { get; set; }

    public string? Bb036Complemento { get; set; }

    public string? Bb036Bairro { get; set; }

    public string? Bb036CodigoCidade { get; set; }

    public string? Bb036Uf { get; set; }

    public string? Bb036Cep { get; set; }

    public string? Bb036CodigoPais { get; set; }
    public CSICP_Bb036? Bb036Candidato { get; set; }
}

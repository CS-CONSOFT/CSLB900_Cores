using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain;

public partial class CSICP_Bb035End
{
    public int TenantId { get; set; }

    [Key]
    public string Bb035Id { get; set; } = null!;

    public string? Bb035Contatoid { get; set; }

    public string? Bb035Logradouro { get; set; }

    public string? Bb035Numero { get; set; }

    public string? Bb035Complemento { get; set; }

    public string? Bb035Bairro { get; set; }

    public string? Bb035CodigoCidade { get; set; }

    public string? Bb035Uf { get; set; }

    public string? Bb035Cep { get; set; }

    public string? Bb035CodigoPais { get; set; }
}

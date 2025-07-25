
namespace CSCore.Domain;

public partial class CSICP_AA001
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public decimal? Aa001Filial { get; set; }

    public string? Aa001Identificacao { get; set; }

    public string? Aa001Tipo { get; set; }

    public string? Aa001Conteudo { get; set; }

    public string? Aa001Descricao { get; set; }

    public string? Aa001Filialid { get; set; }

    public string? Aa001Json { get; set; }

    public CSICP_BB001? FilialBB001 { get; set; }


}

using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF000
{
    public int TenantId { get; set; }

    public string Ff000Id { get; set; } = null!;

    public string? Ff000EstabId { get; set; }

    public decimal? Ff000N1Vacimade { get; set; }

    public string? Ff000N1AutorizadorId { get; set; }

    public string? Ff000N1AusenciaId { get; set; }

    public decimal? Ff000N2Vacimade { get; set; }

    public string? Ff000N2AutorizadorId { get; set; }

    public string? Ff000N2AusenciaId { get; set; }

    public decimal? Ff000N3Vacimade { get; set; }

    public string? Ff000N3AutorizadorId { get; set; }

    public string? Ff000N3AusenciaId { get; set; }

    public decimal? Ff000N4Vacimade { get; set; }

    public string? Ff000N4AutorizadorId { get; set; }

    public string? Ff000N4AusenciaId { get; set; }

    public decimal? Ff000N5Vacimade { get; set; }

    public string? Ff000N5AutorizadorId { get; set; }

    public string? Ff000N5AusenciaId { get; set; }

    public int? Ff000BasecalcId { get; set; }

    public decimal? Ff000PercJuros { get; set; }

    public decimal? Ff000PercMulta { get; set; }

    public int? Ff000Diascarjuros { get; set; }

    public int? Ff000Diascarmulta { get; set; }

    public int? Ff000Diasbloqueio { get; set; }

    public int? Ff000Diasbloqmovto { get; set; }

    public int? Ff000Diasretroagirvencto { get; set; }

    public int? Ff000Diasavancarvencto { get; set; }

    public bool? Ff000Isdesabfcconfaut { get; set; }

    public decimal? Ff000PercCorrmonetaria { get; set; }

    public decimal? Ff000PercHonorarios { get; set; }

    public string? Ff000Renccustoid { get; set; }

    public string? Ff000Renagcobradorid { get; set; }

    public string? Ff000Rentpcobrancaid { get; set; }

    public decimal? Ff000Pminentrenegociacao { get; set; }

    public bool? Ff000Isrensomentetodos { get; set; }

    public string? Ff000Renespecieid { get; set; }

    public bool? Ff000Isrensempregerarvc { get; set; }

    public int? Ff00Formabxtesid { get; set; }

    public int? F000Formaenvapi { get; set; }

    public string? Ff000AgcobradoridApi { get; set; }

    public string? Ff000TpcobrancaidApi { get; set; }

    public bool? Ff000Ispermitecpfcnpjdup { get; set; }

    public string? Ff000PixcobFpagtoid { get; set; }

    public CSICP_FF000Basecalc? NavFF000BaseCalculo { get; set; }
    public CSICP_BB001? NavBB001 { get; set; }
    public Csicp_Sy001? NavSy001 { get; set; }
    public Csicp_Sy001? NavSy001_2 { get; set; }

}

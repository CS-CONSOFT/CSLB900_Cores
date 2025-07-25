using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG030
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg030Usuarioid { get; set; }

    public int? Gg030Filial { get; set; }

    public string? Gg030Filialid { get; set; }

    public DateTime? Gg030DataMovimento { get; set; }

    public string? Gg030Observacao { get; set; }

    public int? Gg030CodgCCusto { get; set; }

    public string? Gg030Ccustoid { get; set; }

    public int? Gg030NoDocto { get; set; }

    public decimal? Gg030Percajuste { get; set; }

    public int? Gg030Responsavel { get; set; }

    public string? Gg030Responsavelid { get; set; }

    public decimal? Gg030TotalMovimento { get; set; }

    public int? Gg030Status { get; set; }

    public int? Gg030PrecoajusteId { get; set; }

    public string? Gg030Protocolnumber { get; set; }

    public CSICP_GG031? NavGG031 { get; set; }
    public CSICP_Bb005? NavBB005 { get; set; }
    public CSICP_BB001? NavBB001 { get; set; }
    public CSICP_BB007? NavBB007 { get; set; }
    public CSICP_GG030Sta? NavGG030Sta { get; set; }
    public CSICP_GG023Val? NavGG023Val { get; set; }
    public Csicp_Sy001? NavSY001 { get; set; }
}

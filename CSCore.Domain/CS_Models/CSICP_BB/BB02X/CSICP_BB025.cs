using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb025
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb025Filial { get; set; }

    public string? Bb025Codigo { get; set; }

    public string? Bb025Descricao { get; set; }

    public int? Bb025GeraDuplicata { get; set; }

    public int? Bb025UsaTabelaPreco { get; set; }

    public int? Bb025Codtptransacao { get; set; }

    public string? Bb025Transacaoid { get; set; }

    public int? Bb025GrupoContabil { get; set; }

    public string? Bb025Moddoctofiscal { get; set; }

    public string? Bb025Cfopdentroestado { get; set; }

    public string? Bb025Cfopforaestado { get; set; }

    public int? Bb025Baixaestoque { get; set; }

    public string? Empresaid { get; set; }

    public bool? Bb025Isactive { get; set; }

    [ForeignKey("NavBb025ModdoctofiscalId")]
    public int? Bb025ModdoctofiscalId { get; set; }

    public int? Bb025Valorizarprecoid { get; set; }

    public CSICP_Bb027? Bb025Transacao { get; set; }
    public OsusrNnxSpedInDocIcm? NavBb025ModdoctofiscalId { get; set; }
    public Osusr66cSpedInAjIcm? osusr66CSpedInAjIcm { get; set; }

    //public ICollection<CSICP_Bb024> OsusrE9aCsicpBb024s { get; set; } = new List<CSICP_Bb024>();
}

namespace CSCore.Domain;

public partial class Csicp_Sy001
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy001Usuario { get; set; }

    public string? Sy001Nome { get; set; }

    public string? Sy001Senha { get; set; }

    public bool? Sy001Bloqueado { get; set; }

    public DateTime? Sy001DataValidade { get; set; }

    public int? Sy001Autalterarsenha { get; set; }

    public CSICP_Statica? NavSY001_AlterarSenha { get; set; }

    public int? Sy001Altsenhapxlogin { get; set; }
    public CSICP_Statica? NavSy001Altsenhapxlogin { get; set; }

    public int? Sy001ExpiraSenha { get; set; }
    public CSICP_Statica? NavSy001ExpiraSenha { get; set; }
    public decimal? Sy001Senhexpaposndias { get; set; }

    public DateTime? Sy001Dtexpiracaologin { get; set; }

    public string? Sy001Deptolotado { get; set; }

    public string? Sy001Cargo { get; set; }

    public string? Sy001Email { get; set; }

    public string? Sy001Imagem { get; set; }

    public DateTime? Sy001Dataultimoacesso { get; set; }

    public int? Userid { get; set; }

    public int? Sy001IdiomaId { get; set; }
    public Csicp_Sy809Idioma? NavSy001IdiomaId { get; set; }

    public string? Sy001Senhacs { get; set; }

    public string? Sy001Celular { get; set; }


    public ICollection<Csicp_Sy001Img> OsusrE9aCsicpSy001Imgs { get; set; } = new List<Csicp_Sy001Img>();



}

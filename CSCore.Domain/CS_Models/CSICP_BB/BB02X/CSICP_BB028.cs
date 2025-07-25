namespace CSCore.Domain;

public partial class CSICP_Bb028
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb028Codigo { get; set; }

    public string? Bb028Nomeresponsavel { get; set; }

    public string? Bb028Nomereduzido { get; set; }

    public string? Bb028Telefone { get; set; }

    public string? Bb028Fax { get; set; }

    public string? Bb028Celular { get; set; }

    public string? Bb028Homepage { get; set; }

    public string? Bb028Email { get; set; }

    public string? Bb028Cnpj { get; set; }

    public decimal? Bb028Inscestadual { get; set; }

    public decimal? Bb028Inscmunicipal { get; set; }

    public string? Bb028Geracpagar { get; set; }

    public decimal? Bb028Coms1 { get; set; }

    public decimal? Bb028Coms2 { get; set; }

    public decimal? Bb028Coms3 { get; set; }

    public decimal? Bb028Coms4 { get; set; }

    public decimal? Bb028Coms5 { get; set; }

    public string? Bb028Nomebanco { get; set; }

    public string? Bb028Agencia { get; set; }

    public string? Bb028Conta { get; set; }

    public string? Bb028Observacao { get; set; }

    public DateTime? Bb028Datanasc { get; set; }

    public bool? Bb028Isactive { get; set; }

    public string? Bb028Contafornid { get; set; }

    public int? Bb028TipoId { get; set; }

    public CSICP_Bb028Tp? NavBB028Tp { get; set; }
    public CSICP_BB012? NavBB012 { get; set; }

}

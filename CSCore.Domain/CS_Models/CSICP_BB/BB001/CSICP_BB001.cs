

using CSCore.Domain;
using System.ComponentModel.DataAnnotations;

//namespace CSCore.Domain;

public partial class CSICP_BB001
{
    public int TenantId { get; set; }

    [Key]
    public string Id { get; set; } = null!;

    public int? Bb001Codigoempresa { get; set; }

    public string? Bb001Razaosocial { get; set; }

    public string? Bb001Endereco { get; set; }

    public string? Bb001Complemento { get; set; }

    public string? Bb001Numresidencial { get; set; }

    public string? Bb001Bairro { get; set; }

    public int? Bb001Cep { get; set; }

    public string? Bb001Cnpj { get; set; }

    public string? Bb001Inscestadual { get; set; }

    public decimal? Bb001Inscjunta { get; set; }

    public DateTime? Bb001Datainscricao { get; set; }

    public string? Bb001Nomefantasia { get; set; }

    public string? Bb001Telefone { get; set; }

    public string? Bb001Fax { get; set; }

    public string? Bb001Slogamempresa1 { get; set; }

    public string? Bb001Slogamempresa2 { get; set; }

    public string? Bb001Email { get; set; }

    public string? Bb001Homepage { get; set; }

    public int? Bb001Ramoempresa { get; set; }

    public string? Bb002Grupoempresa { get; set; }

    public int? Bb001Codgclienteaux { get; set; }

    public int? Bb001Almoxpadrao { get; set; }

    public int? Bb001Almoxtransfer { get; set; }

    public int? Bb001Bddistribuida { get; set; }

    public int? Bb001Cnaefiscal { get; set; }

    public string? Bb001Suframaemp { get; set; }

    public string? Bb001Inscmunicipal { get; set; }

    public string? Bb001Paisid { get; set; }

    public string? Cidadeid { get; set; }

    public string? Bb001Ufid { get; set; }

    public string? Bb001Nomeoficial { get; set; }

    public decimal? Bb001CpfOficial { get; set; }

    public decimal? Bb001Codgcartorio { get; set; }

    public string? Bb001Nomesubstituto { get; set; }

    public string? Bb001Descricaooficial { get; set; }

    public int? Bb001Capitalmunicipio { get; set; }

    public string? Bb001Cor1Hexa { get; set; }

    public string? Bb001Cor2Hexa { get; set; }

    public int? Bb001IdiomaId { get; set; }

    public bool? Bb001Isactive { get; set; }

    public string? Bb001Token { get; set; }

    public string? Bb001Usuariosirc { get; set; }

    public string? Bb001Senhasirc { get; set; }

    public int? Bb001Tenantfiscal { get; set; }

    public string? Bb001TokenEsitef { get; set; }

    public string? Bb001UrlGoogleplay { get; set; }

    public string? Bb001UrlAppstore { get; set; }

    public string? Bb001Cix { get; set; }

    public string? Bb001ChaveApl { get; set; }

    public string? Bb001AutToken { get; set; }

    public string? Bb001TokenCspix { get; set; }

    public bool? BB001_IsRegimeRegular { get; set; }

    //navegacao
    public ICollection<CSICP_BB001Img> OsusrE9aCsicpBb001Imgs { get; set; } = new List<CSICP_BB001Img>();
    public CSICP_Aa025? Bb001Pais { get; set; }

    public CSICP_Statica? Bb001RamoempresaNavigation { get; set; }

    public CSICP_Aa027? Bb001Uf { get; set; }

    public CSICP_Aa028? Cidade { get; set; }

    public ICollection<CSICP_BB001_AXML> NavBB001AXML { get; set; } = new List<CSICP_BB001_AXML>();

    public ICollection<CSICP_BB001Cfgfi> OsusrE9aCsicpBb001Cfgfis { get; set; } = new List<CSICP_BB001Cfgfi>();

    public ICollection<CSICP_BB001Cnaes> Bb001CnaesList { get; set; } = new List<CSICP_BB001Cnaes>();

    public ICollection<CSICP_BB001Spls> OsusrE9aCsicpBb001Spls { get; set; } = new List<CSICP_BB001Spls>();

}

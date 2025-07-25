
using System;
using System.Collections.Generic;

namespace CSCore.Domain;

[Obsolete]
public partial class CSICP_BB001Global
{
    public string Id { get; set; } = null!;

    public int? Bb001Codigoempresa { get; set; }

    public string? Bb001Razaosocial { get; set; }

    public string? Bb001Endereco { get; set; }

    public string? Bb001Numresidencial { get; set; }

    public string? Bb001Bairro { get; set; }

    public int? Bb001Cep { get; set; }

    public decimal? Bb001Cnpj { get; set; }

    public decimal? Bb001Inscestadual { get; set; }

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

    public decimal? Bb001Inscmunicipal { get; set; }

    public string? Bb001Paisid { get; set; }

    public string? Cidadeid { get; set; }

    public string? Bb001Ufid { get; set; }

    public string? Bb001Nomeoficial { get; set; }

    public decimal? Bb001CpfOficial { get; set; }

    public decimal? Bb001Codgcartorio { get; set; }

    public string? Bb001Nomesubstituto { get; set; }

    public string? Bb001Descricaooficial { get; set; }

    public int? Bb001Capitalmunicipio { get; set; }

    // public  OsusrE9aCsicpStatica? Bb001BddistribuidaNavigation { get; set; }

    //public  CSICP_BB001Capmun? Bb001CapitalmunicipioNavigation { get; set; }

    public CSICP_Aa025? Bb001Pais { get; set; }

    //   public  OsusrE9aCsicpStatica? Bb001RamoempresaNavigation { get; set; }

    public CSICP_Aa027? Bb001Uf { get; set; }

    public CSICP_Aa028? Cidade { get; set; }
}

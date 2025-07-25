using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF112
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff112Filialid { get; set; }

    public string? Ff112Bancoid { get; set; }

    public string? Ff112Descregistro { get; set; }

    public decimal? Ff112Ultlote { get; set; }

    public int? Ff112Carteira { get; set; }

    public string? Ff112Convenio { get; set; }

    public int? Ff112Cadastramento { get; set; }

    public int? Ff112Documento { get; set; }

    public int? Ff112Emissaobloqueto { get; set; }

    public int? Ff112Distribuicaobloqueto { get; set; }

    public decimal? Ff112Nrocontrato { get; set; }

    public string? Ff112Moedapadrao { get; set; }

    public int? Ff112Tipooperacao { get; set; }

    public int? Ff112Tiposervico { get; set; }

    public int? Ff112Tipoinscricao { get; set; }

    public int? Ff112Codgprotesto { get; set; }

    public int? Ff112Prazoprotesto { get; set; }

    public int? Ff112Codgbaixadevolucao { get; set; }

    public int? Ff112Prazodevolucao { get; set; }

    public string? Ff112Versaocnab { get; set; }

    public string? Ff112Mensagem1 { get; set; }

    public string? Ff112Mensagem2 { get; set; }

    public string? Ff112Mensagem3 { get; set; }

    public string? Ff112Mensagem4 { get; set; }

    public bool? IsActive { get; set; }

    public string? Ff112Codgmovimetoretorno { get; set; }

    public string? Ff112Nrocarteira { get; set; }

    public string? Ff112Varcarteira { get; set; }

    public int? Ff112Faixanossonro { get; set; }

    public int? Ff112CnabId { get; set; }

    public decimal? Ff112PercJuros { get; set; }

    public decimal? Ff112ValorJuros { get; set; }

    public decimal? Ff112PercMulta { get; set; }

    public decimal Ff112ValorMulta { get; set; } = 0m;

    public decimal? Ff112PercDesconto { get; set; }

    public int? Ff112CnabCodDesconto { get; set; }

    public int? Ff112CnabCodJurosMora { get; set; }

    public int? Ff112CnabCodMulta { get; set; }

    public int? Ff112Prazorecbto { get; set; }

    public string? Ff112Boletoid { get; set; }

    public string? Ff112Ccorrenteid { get; set; }

    public int? Ff112IdentAceite { get; set; }

    public bool? Ff112Ismultempresa { get; set; }

    public string? Ff112TpCobrEntrada { get; set; }

    public string? Ff112TpCobrSaida { get; set; }

    public int? Ff112Prazonegativacao { get; set; }

    public int? Ff112OrgaoNeg { get; set; }

    //Tabelas Navs
    public CSICP_BB001? NavBB001 { get; set; }
}

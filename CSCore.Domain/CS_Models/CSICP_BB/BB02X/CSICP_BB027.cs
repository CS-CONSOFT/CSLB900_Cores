using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb027
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb027Filial { get; set; }

    public int? Bb027Codigo { get; set; }

    public string? Bb027Descricao { get; set; }

    [ForeignKey("NavBB027BaixaEstoque")]
    public int? Bb027Baixaestoque { get; set; }

    [ForeignKey("NavBB027GeraCReceber")]
    public int? Bb027Geracreceber { get; set; }

    [ForeignKey("NavBB027AtualizaPrCompra")]
    public int? Bb027Atualizaprcompra { get; set; }

    [ForeignKey("NavBB027CalcSubstituicao")]
    public int? Bb027Calcsubstituicao { get; set; }

    [ForeignKey("NavBB027CalculaISS")]
    public int? Bb027Calculaiss { get; set; }

    public string? Bb027Cfopdentroestado { get; set; }

    public string? Bb027Cfopforaestado { get; set; }

    [ForeignKey("NavBB027AgregaSubsTrib")]
    public int? Bb027Agregasubstrib { get; set; }

    [ForeignKey("NavBB027DIFA")]
    public int? Bb027Difa { get; set; }

    [ForeignKey("NavBB027ICST")]
    public int? Bb027Icst { get; set; }

    [ForeignKey("NavBB027IRRF")]
    public int? Bb027Irrf { get; set; }

    [ForeignKey("NavBB027PIS")]
    public int? Bb027Pis { get; set; }

    [ForeignKey("NavBB027COFINS")]
    public int? Bb027Cofins { get; set; }

    [ForeignKey("NavBB027IRPJ")]
    public int? Bb027Irpj { get; set; }

    [ForeignKey("NavBB027ICMSDiferido")]
    public int? Bb027Icmsdiferido { get; set; }

    [ForeignKey("NavBB027GeraEstatistica")]
    public int? Bb027Geraestatistica { get; set; }

    public string? Bb027Codgcst { get; set; }

    public int? Bb027Transdevolucao { get; set; }

    public decimal? Bb027Reducaoicms { get; set; }

    public decimal? Bb027Reducaoipi { get; set; }

    public decimal? Bb027Reducaoicmsst { get; set; }

    public decimal? Bb027Reducaoiss { get; set; }

    public string? Empresaid { get; set; }

    [ForeignKey("NavBB027Entsai")]
    public int? Bb027EntsaiId { get; set; }

    public int? Bb027PodertercId { get; set; }

    [ForeignKey("NavBB027CalcICMS")]
    public int? Bb027CalcicmsId { get; set; }

    [ForeignKey("NavBB027CalcIPI")]
    public int? Bb027CalcipiId { get; set; }

    [ForeignKey("NavBB027SomaIPIBaseICMS")]
    public int? Bb027SomaipiBaseicmsId { get; set; }

    [ForeignKey("NavBB027IPIBruto")]
    public int? Bb027IpiBrutoId { get; set; }

    [ForeignKey("NavBB027BaseICMSBrutaLiq")]
    public int? Bb027BaseicmsbrutaliqId { get; set; }

    [ForeignKey("NavBB027BaseSubsBrutaLiq")]
    public int? Bb027BasesubsbrutaliqId { get; set; }

    [ForeignKey("NavBB027CFOPStatica")]
    public int? Bb027CfopStaticaId { get; set; }

    [ForeignKey("NavBB027Tdevolucao")]
    public string? Bb027TdevolucaoId { get; set; }

    [ForeignKey("NavBB027Regime")]
    public int? Bb027RegimeId { get; set; }

    [ForeignKey("NavBB027CFOPForaEstado")]
    public int? Bb027CfopForaestadoId { get; set; }

    public string? Bb027Hashid { get; set; }

    public string? Bb027Descnatoper { get; set; }

    [ForeignKey("NavBB027CalcAjusteICMS")]
    public int? Bb027CalcajusteicmsId { get; set; }

    [ForeignKey("NavBB027CodgAjusteICMS")]
    public int? Bb027CodgajusteicmsId { get; set; }

    public int? Bb027Icmsdiferidoid { get; set; }

    public decimal? Bb027PicmsDiferido { get; set; }

    // Navegações para CSICP_Statica
    public CSICP_Statica? NavBB027BaixaEstoque { get; set; }
    public CSICP_Statica? NavBB027GeraCReceber { get; set; }
    public CSICP_Statica? NavBB027AtualizaPrCompra { get; set; }
    public CSICP_Statica? NavBB027CalcSubstituicao { get; set; }
    public CSICP_Statica? NavBB027CalculaISS { get; set; }
    public CSICP_Statica? NavBB027AgregaSubsTrib { get; set; }
    public CSICP_Statica? NavBB027DIFA { get; set; }
    public CSICP_Statica? NavBB027ICST { get; set; }
    public CSICP_Statica? NavBB027IRRF { get; set; }
    public CSICP_Statica? NavBB027PIS { get; set; }
    public CSICP_Statica? NavBB027COFINS { get; set; }
    public CSICP_Statica? NavBB027IRPJ { get; set; }
    public CSICP_Statica? NavBB027ICMSDiferido { get; set; }
    public CSICP_Statica? NavBB027GeraEstatistica { get; set; }
    public CSICP_Statica? NavBB027CalcAjusteICMS { get; set; }
    public CSICP_Statica? NavBB027CalcIS { get; set; }

    // Navegações para outras tabelas BB027
    public CSICP_Bb027Entsai? NavBB027Entsai { get; set; }
    public CSICP_Bb027Cicm? NavBB027CalcICMS { get; set; }
    public CSICP_Bb027Cicm? NavBB027CalcIPI { get; set; }
    public CSICP_Bb027Sipi? NavBB027SomaIPIBaseICMS { get; set; }
    public CSICP_Bb027Bcalc? NavBB027IPIBruto { get; set; }
    public CSICP_Bb027Bcalc? NavBB027BaseICMSBrutaLiq { get; set; }
    public CSICP_Bb027Bcalc? NavBB027BaseSubsBrutaLiq { get; set; }

    // Navegações para SPED
    public Osusr66cSpedInCfop? NavBB027CFOPStatica { get; set; }
    public Osusr66cSpedInCfop? NavBB027CFOPForaEstado { get; set; }
    public Osusr66cSpedInCodAjuste? NavBB027CodgAjusteICMS { get; set; }

    // Navegação auto-relacionamento
    public CSICP_Bb027? NavBB027Tdevolucao { get; set; }

    // Navegação para Regime
    public CSICP_AA030Regime? NavAA030_BB027Regime { get; set; }
}

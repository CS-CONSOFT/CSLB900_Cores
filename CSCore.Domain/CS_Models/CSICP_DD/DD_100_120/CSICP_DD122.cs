using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD122
{
    public int TenantId { get; set; }

    public string Dd122TrocaitemId { get; set; } = null!;

    public string? Dd120TrocaId { get; set; }

    public int? Dd122Seq { get; set; }

    public string? Dd060VendaitemId { get; set; }

    public decimal? Dd122CodgBarra { get; set; }

    public string? Dd122SaldoorigemId { get; set; }

    public string? Dd122SaldodestinoId { get; set; }

    public decimal? Dd122Precotabela { get; set; }

    public decimal? Dd122QtdTroca { get; set; }

    public decimal? Dd122VbrutoTroca { get; set; }

    public decimal? Dd122Pabatimento { get; set; }

    public decimal? Dd122Vabatimento { get; set; }

    public decimal? Dd122VabatPorvalor { get; set; }

    public decimal? Dd122VliqTroca { get; set; }

    public bool? Dd122Isrecebido { get; set; }

    public int? Dd122TipodevolucaoId { get; set; }

    public DateTime? Dd122DataReaver { get; set; }

    public DateTime? Dd122DataRecbto { get; set; }

    public decimal? Dd122QtdTrocaAnt { get; set; }

    public string? Dd122VendedorId { get; set; }

    public string? Dd122UsuarioreaverId { get; set; }

    public string? Dd122UsuariorecebeuId { get; set; }

    public decimal? Dd122Vacrescimo { get; set; }

    public decimal? Dd122Pacrescimo { get; set; }

    public string? Dd122Anotacao { get; set; }

    public string? Dd122MotivoId { get; set; }

    public decimal? Dd122VlrDescSt1liq { get; set; }

    public decimal? Dd122PrcTabela2 { get; set; }

    public decimal? Dd122PercDescproduto { get; set; }

    public decimal? Dd122ValorDescproduto { get; set; }

    public decimal? Dd122PrecoUnitario { get; set; }

    public decimal? Dd122Totliqproduto { get; set; }

    public decimal? Dd122St2Liquido { get; set; }

    public decimal? Dd122TotalDesconto { get; set; }

    public decimal? Dd122Frete { get; set; }

    public decimal? Dd122Seguro { get; set; }

    public decimal? Dd122Odespesas { get; set; }

    public decimal? Dd122TotalLiquido { get; set; }

    public decimal? Dd122Vdescsuframa { get; set; }

    public decimal? Dd122BaseCalcIcms { get; set; }

    public decimal? Dd122PercIcms { get; set; }

    public decimal? Dd122ValorIcms { get; set; }

    public decimal? Dd122BaseCalcSubst { get; set; }

    public decimal? Dd122PercSubstTrib { get; set; }

    public decimal? Dd122Vlrsubsttribaux { get; set; }

    public decimal? Dd122Vlrsubsttribut { get; set; }

    public decimal? Dd122BaseCalcIpi { get; set; }

    public decimal? Dd122PercIpi { get; set; }

    public decimal? Dd122ValorIpi { get; set; }

    public decimal? Dd122Percreducaobaseicms { get; set; }

    public decimal? Dd122LucroEstimado { get; set; }

    public string? Dd122UsuariovendId { get; set; }

    public string? Dd122Codbarrasalfa { get; set; }

    public int? Dd122Entradasaida { get; set; }

    public virtual CSICP_DD060? Dd060Vendaitem { get; set; }

    public virtual CSICP_DD120? Dd120Troca { get; set; }

    public virtual CSICP_DD122Tpde? Dd122Tipodevolucao { get; set; }
}

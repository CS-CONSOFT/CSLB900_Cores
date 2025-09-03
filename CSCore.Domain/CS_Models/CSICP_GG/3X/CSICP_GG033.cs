namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG033
{
    public CSICP_GG033()
    {
    }

    public CSICP_GG033(CSICP_GG033 entidade, string id, string gg032ID)
    {
        TenantId = entidade.TenantId;
        Id = id;
        Gg033Filialid = entidade.Gg033Filialid;
        Gg032Id = gg032ID;
        Gg033Saldoid = entidade.Gg033Saldoid;
        Gg033Produto = entidade.Gg033Produto;
        Gg033Codigobarras = entidade.Gg033Codigobarras;
        Gg033Datareferente = entidade.Gg033Datareferente;
        Gg033Qtdinventario = entidade.Gg033Qtdinventario;
        Gg033Saldoestoque = entidade.Gg033Saldoestoque;
        Gg033Qtdajuste = entidade.Gg033Qtdajuste;
        Gg033Entsai = entidade.Gg033Entsai;
        Gg033Precocusto = entidade.Gg033Precocusto;
        Gg033Precocustoreal = entidade.Gg033Precocustoreal;
        Gg033Precocustomedio = entidade.Gg033Precocustomedio;
        Gg033Precovenda = entidade.Gg033Precovenda;
        Gg033Datafechanterior = entidade.Gg033Datafechanterior;
        Gg033Qtdfechanterior = entidade.Gg033Qtdfechanterior;
        Gg033Naoinventariar = entidade.Gg033Naoinventariar;
        Gg033Alterado = entidade.Gg033Alterado;
        Gg033NnGrupoId = entidade.Gg033NnGrupoId;
        Gg033NnClasseId = entidade.Gg033NnClasseId;
        Gg033NnMarcaId = entidade.Gg033NnMarcaId;
        Gg033NnArtigoId = entidade.Gg033NnArtigoId;
        Gg033NnLinhaId = entidade.Gg033NnLinhaId;
        Gg033NnSubgrupoId = entidade.Gg033NnSubgrupoId;
        Gg033QuemdigitouUserId = entidade.Gg033QuemdigitouUserId;
        Gg033QuemcontouUserid = entidade.Gg033QuemcontouUserid;
        Gg033Posicao = entidade.Gg033Posicao;
        Gg033Codbarrasalfa = entidade.Gg033Codbarrasalfa;
    }

    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg033Filialid { get; set; }

    public string? Gg032Id { get; set; }

    public string? Gg033Saldoid { get; set; }

    public int? Gg033Produto { get; set; }

    public decimal? Gg033Codigobarras { get; set; }

    public DateTime? Gg033Datareferente { get; set; }

    public decimal? Gg033Qtdinventario { get; set; }

    public decimal? Gg033Saldoestoque { get; set; }

    public decimal? Gg033Qtdajuste { get; set; }

    public string? Gg033Entsai { get; set; }

    public decimal? Gg033Precocusto { get; set; }

    public decimal? Gg033Precocustoreal { get; set; }

    public decimal? Gg033Precocustomedio { get; set; }

    public decimal? Gg033Precovenda { get; set; }

    public DateTime? Gg033Datafechanterior { get; set; }

    public decimal? Gg033Qtdfechanterior { get; set; }

    public bool? Gg033Naoinventariar { get; set; }

    public bool? Gg033Alterado { get; set; }

    public string? Gg033NnGrupoId { get; set; }

    public string? Gg033NnClasseId { get; set; }

    public string? Gg033NnMarcaId { get; set; }

    public string? Gg033NnArtigoId { get; set; }

    public string? Gg033NnLinhaId { get; set; }

    public string? Gg033NnSubgrupoId { get; set; }

    public string? Gg033QuemdigitouUserId { get; set; }

    public string? Gg033QuemcontouUserid { get; set; }

    public int? Gg033Posicao { get; set; }

    public string? Gg033Codbarrasalfa { get; set; }

    public CSICP_GG520? NavGG033_Saldo { get; set; }
    public CSICP_BB001? NavBB001Estab { get; set; }
}

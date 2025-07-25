using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public class RepoDtoExtrato
{
    public CSICP_GG028? Extrato { get; set; }
    public string? DescricaoReduzidaProduto { get; set; }
    public string? Natureza { get; set; }
    public decimal? NF_Cupom { get; set; }
    public string? Nome_Usuario { get; set; }
    public string? Almoxarifado_NS { get; set; }
    public string? TipoMovimento { get; set; }
    public int? CodigoProduto { get; set; }
}

public partial class CSICP_GG028
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg028Filialid { get; set; }

    public int? Gg028Filial { get; set; }

    public string? Gg028Protocolnumber { get; set; }

    public string? Gg028Origemprograma { get; set; }

    public string? Gg028OrigemPkid { get; set; }

    public DateTime? Gg028DataMovimento { get; set; }

    public DateTime? Gg028DataReferente { get; set; }

    public string? Gg028Almoxid { get; set; }

    public string? Gg028KardexId { get; set; }

    public string? Gg028Produtoid { get; set; }

    public string? Gg028Saldoid { get; set; }

    public string? Gg028Transacaoid { get; set; }


    public string? Gg028Contaid { get; set; }

    public string? Gg028Usuarioid { get; set; }

    public decimal? Gg028QtdMovimento { get; set; }

    public decimal? Gg028ValorUnitario { get; set; }

    public decimal? Gg028SaldoAnterior { get; set; }

    public string? Gg028DocProtocolnumber { get; set; }

    public string? Gg028DoctoId { get; set; }

    public int? Gg028NPdv { get; set; }

    public decimal? Gg028NfOuCupom { get; set; }

    public int? Gg028EntsaidaId { get; set; }

    public int? Gg028NaturezaId { get; set; }
}

public partial class RepoGetCSICP_GG028 : CSICP_GG028
{
    public CSICP_GG001? NavGG001_Almox { get; set; }
    public CSICP_BB012? NavBB012_Cliente { get; set; }
    public Csicp_Sy001? NavSY001_Usuario { get; set; }
    public CSICP_Bb027? NavBB027 { get; set; }
    public CSICP_GG028Entsai? Nav_GG028_EntSaida { get; set; }
    public OsusrE9aCsicpGg028Nat? Nav_GG028_Nat { get; set; }
    public CSICP_GG008? Nav_GG008_Produto { get; set; }
    public CSICP_GG520? Nav_GG520_Saldo { get; set; }
}
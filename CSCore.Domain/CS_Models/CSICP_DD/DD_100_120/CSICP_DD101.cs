using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD101
{
    public int TenantId { get; set; }

    public string Dd101EntregaId { get; set; } = null!;

    public string? Dd101Filialid { get; set; }

    public string? Dd101VendaId { get; set; }

    public string? Dd101ContaId { get; set; }

    public decimal? Dd101QtdVenda { get; set; }

    public decimal? Dd101QtdEntregue { get; set; }

    public string? Dd101KardexId { get; set; }

    public string? Dd101SaldoId { get; set; }

    public decimal? Dd101PercEntregue { get; set; }

    public string? Dd101UsuarioproprId { get; set; }

    public DateTime? Dd101DataGerado { get; set; }

    public string? Dd101Obs { get; set; }

    public bool? Dd101Isactive { get; set; }

    public DateTime? Dd101Datafinal { get; set; }

    public string? Dd101SaldoEntregaId { get; set; }

    public decimal? Dd101Valorvenda { get; set; }

    public string? Dd101Protocolnumber { get; set; }

    public int? Dd101Modentregaid { get; set; }

    public int? Dd101Statusid { get; set; }

    public long? Dd107Identificadorid { get; set; }

    public CSICP_DD110Mod? Dd101Modentrega { get; set; }

    public CSICP_DD101Stum? Dd101Status { get; set; }

    public CSICP_DD060? Dd101Venda { get; set; }

    public CSICP_DD107? Dd107Identificador { get; set; }

    public CSICP_DD060? NavDD060_ProdutosNF { get; set; } 
    public CSICP_BB001? NavBB001_Estab { get; set; }

    public CSICP_DD102? NavDD102Entrega { get; set; }

}

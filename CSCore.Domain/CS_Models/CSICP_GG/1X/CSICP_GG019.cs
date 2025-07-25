using CSCore.Domain.CS_Models.Staticas.GG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG019
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg019Filialid { get; set; }

    public decimal? Gg019CodigoBarras { get; set; }

    public string? Gg019Produtoid { get; set; }

    public int? Gg019Filial { get; set; }

    public int? Gg019Item { get; set; }

    public string? Gg019Unidade { get; set; }

    public string? Gg019Unid { get; set; }

    public decimal? Gg019FatorConversao { get; set; }

    public string? Gg019Lote { get; set; }

    public string? Gg019SubLote { get; set; }

    public string? Gg019CodigoLinha { get; set; }

    public string? Gg019CodigoColuna { get; set; }

    public int? Gg019TipocbarraId { get; set; }

    public int? Gg019ConversaoId { get; set; }

    public string? Gg019Codbarrasalfa { get; set; }

    public string? Gg019KeysldId { get; set; }

    public bool? Gg019Isimpetq { get; set; }

    public CSICP_GG008Con? NavGG08Conversao { get; set; }

    public CSICP_GG019Cgbar? NavGg019Tipocbarra { get; set; }

    public CSICP_GG007? NavGg007Un { get; set; }
}

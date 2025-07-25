using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF140
{
    public int TenantId { get; set; }

    public long Ff140Id { get; set; }

    public DateTime? Ff140Data { get; set; }

    public string? Ff140Contaid { get; set; }

    public string? Ff140Especieid { get; set; }

    public string? Ff140Ccustoid { get; set; }

    public string? Ff140Usuarioproprieid { get; set; }

    public string? Ff140Agcobradorid { get; set; }

    public string? Ff140FpagtoId { get; set; }

    public string? Ff140Condicaoid { get; set; }

    public string? Ff140Tipocobrancaid { get; set; }

    public string? Ff140Descricao { get; set; }

    public string? Ff140Protocolnumber { get; set; }

    public decimal? Ff140Vrequisicao { get; set; }

    public string? Ff140Projetoid { get; set; }

    public int? Ff140Statusid { get; set; }

    public int? Ff140Execucaoid { get; set; }

    public int? Ff140Tpvinculoid { get; set; }

    public int? Ff140QtdeParcelas { get; set; }

    public string? Ff140Estabid { get; set; }

    public int? Ff140AdtoId { get; set; }

    public virtual CSICP_FF003? Ff140Especie { get; set; }
}

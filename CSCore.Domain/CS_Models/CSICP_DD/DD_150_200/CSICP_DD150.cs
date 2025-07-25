using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD150
{
    public int TenantId { get; set; }

    public int Dd150Id { get; set; }

    public string? Dd150Estabid { get; set; }

    public string? Dd040Id { get; set; }

    public string? Dd150Protocolnumber { get; set; }

    public string? Dd150Usuariopropid { get; set; }

    public DateTime? Dd150Dregistro { get; set; }

    public DateTime? Dd150Dhregistro { get; set; }

    public DateTime? Dd150Dhprevisao { get; set; }

    public DateTime? Dd150Dagenda { get; set; }

    public DateTime? Dd150Hagenda { get; set; }

    public string? Dd150Montadorrespid { get; set; }

    public DateTime? Dd150Diniciomontagem { get; set; }

    public DateTime? Dd150Dfinalmontagem { get; set; }

    public decimal? Dd150Thorasmontg { get; set; }

    public decimal? Dd150Thoraspadrao { get; set; }

    public string? Bb012Contaid { get; set; }

    public string? Dd150Sms { get; set; }

    public string? Dd150Email { get; set; }

    public int? Dd150Statusid { get; set; }

    public bool? Dd150Isactive { get; set; }

    public int? Dd150Confirmaid { get; set; }

    public string? Dd150Msgcliente { get; set; }

    public DateTime? Dd150Dconfirmacliente { get; set; }

    public int? Dd150Satisfacaocliente { get; set; }

    public string? Dd150Observacao { get; set; }

    public bool? Dd150Isentregue { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD150Conf? Dd150Confirma { get; set; }

    public virtual CSICP_DD158? Dd150Montadorresp { get; set; }

    public virtual CSICP_DD150St? Dd150Status { get; set; }
}

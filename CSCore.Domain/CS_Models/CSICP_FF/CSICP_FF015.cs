using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF015
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff015Filialid { get; set; }

    public DateTime? Ff015DataRegistro { get; set; }

    public DateTime? Ff015DataPrevisao { get; set; }

    public string? Ff102Id { get; set; }

    public string? Ff015Observacao { get; set; }

    public int? Ff015Diasatraso { get; set; }

    public bool? Ff015Acaosistema { get; set; }

    public bool? Ff015Acaohumana { get; set; }

    public string? Ff015Usuarioid { get; set; }

    public string? Ff015Categoriaid { get; set; }

    public string? Ff015Contaid { get; set; }

    public string? Ff015Ccustoid { get; set; }

    public string? Ff015Grupocobrancaid { get; set; }

    public string? Ff015Zonaid { get; set; }

    public string? Ff015Cobradorrespid { get; set; }

    public int? Ff015SituacaoentId { get; set; }

    public int? Ff015SitcobrancaEntId { get; set; }

    public int? Ff015SituacaosaiId { get; set; }

    public virtual CSICP_FF998? Ff015SitcobrancaEnt { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }
}

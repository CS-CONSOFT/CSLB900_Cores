using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD120
{
    public int TenantId { get; set; }

    public string Dd120TrocaId { get; set; } = null!;

    public string? Dd120FilialId { get; set; }

    public string? Dd120UsuariopropId { get; set; }

    public DateTime? Dd120DataTroca { get; set; }

    public string? Dd120ContaId { get; set; }

    public int? Dd120NoImpressoes { get; set; }

    public decimal? Dd120Vtotalbruto { get; set; }

    public decimal? Dd120Pdesconto { get; set; }

    public decimal? Dd120Vdesconto { get; set; }

    public decimal? Dd120Vacrescimo { get; set; }

    public decimal? Dd120Vtotalliquido { get; set; }

    public decimal? Dd120VsaldoCartacred { get; set; }

    public string? Dd120Observacao { get; set; }

    public int? Dd120StatusId { get; set; }

    public int? Dd120PossuicartaId { get; set; }

    public string? Dd120Protocolnumber { get; set; }

    public string? CsicpFf002Id { get; set; }

    public int? Dd120Tpdevid { get; set; }

    public virtual CSICP_DD120Pcartum? Dd120Possuicarta { get; set; }

    public virtual CSICP_DD120Status? Dd120Status { get; set; }

    public virtual CSICP_DD120tp? Dd120Tpdev { get; set; }
}

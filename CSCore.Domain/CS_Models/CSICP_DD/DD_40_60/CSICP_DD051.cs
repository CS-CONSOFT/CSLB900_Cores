using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD051
{
    public int TenantId { get; set; }

    public string Dd051Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public int? Dd051ServicoId { get; set; }

    public int? Dd051SenvioId { get; set; }

    public DateTime? Dd051Datahora { get; set; }

    public string? Dd051UsuarioId { get; set; }

    public string? NfeXmotivoLongo { get; set; }

    public byte[]? NfeXmlEnvio { get; set; }

    public string? NfeXmlRetorno { get; set; }

    public decimal? NfeNrec { get; set; }

    public decimal? NfeNprot { get; set; }

    public string? NfeCstat { get; set; }

    public string? NfeXmotivo { get; set; }

    public int? Dd051TipoenvioId { get; set; }

    public string? Dd051Serie { get; set; }

    public int? Dd051NronfeInicio { get; set; }

    public int? Dd051NronfeFinal { get; set; }

    public int? Processid { get; set; }

    public string? Dd051SerieId { get; set; }

    public int? Dd051ModId { get; set; }

    public int? Dd051Sequencia { get; set; }

    public string? NfeInutJustificativ { get; set; }

    public string? Dd051EstabId { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD906? Dd051Senvio { get; set; }

    public virtual CSICP_DD904Snfe? Dd051Servico { get; set; }

    public virtual CSICP_DD908? Dd051Tipoenvio { get; set; }
}

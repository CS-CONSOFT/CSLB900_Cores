using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD116
{
    public int TenantId { get; set; }

    public string Dd116Id { get; set; } = null!;

    public string? Dd110Id { get; set; }

    public int? Dd116ServicoId { get; set; }

    public int? Dd116SenvioId { get; set; }

    public DateTime? Dd116Datahora { get; set; }

    public string? Dd116UsuarioId { get; set; }

    public string? NfeXmotivoLongo { get; set; }

    public byte[]? NfeXmlEnvio { get; set; }

    public string? NfeXmlRetorno { get; set; }

    public decimal? NfeNrec { get; set; }

    public decimal? NfeNprot { get; set; }

    public string? NfeCstat { get; set; }

    public string? NfeXmotivo { get; set; }

    public int? Dd116TipoenvioId { get; set; }

    public int? Dd116Sequencia { get; set; }

    public string? Dd116EstabId { get; set; }

    public string? NfeXmlEnvio2 { get; set; }

    public virtual CSICP_DD110? Dd110 { get; set; }

    public virtual CSICP_DD906? Dd116Senvio { get; set; }

    public virtual CSICP_DD904Snfe? Dd116Servico { get; set; }

    public virtual CSICP_DD908? Dd116Tipoenvio { get; set; }
}

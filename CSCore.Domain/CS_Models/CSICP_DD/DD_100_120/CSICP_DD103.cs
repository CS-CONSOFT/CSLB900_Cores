using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD103
{
    public int TenantId { get; set; }

    public string Dd103SeparacaoId { get; set; } = null!;

    public string? Dd103Filialid { get; set; }

    public string? Dd103ExecEntregaId { get; set; }

    public string? Dd103KardexId { get; set; }

    public string? Dd103SeparadoKardexId { get; set; }

    public decimal? Dd103QtdSeparada { get; set; }

    public string? Dd103UsuarioproprId { get; set; }

    public DateTime? Dd103DataSeparacao { get; set; }

    public bool? Dd103Processado { get; set; }

    public string? Dd103Obs { get; set; }

    public bool? Dd103Isactive { get; set; }

    public decimal? Dd103Cbarra { get; set; }

    public string? Dd103PnExecent { get; set; }

    public string? Dd103Codbarrasalfa { get; set; }

    public virtual CSICP_DD102? Dd103ExecEntrega { get; set; }
}

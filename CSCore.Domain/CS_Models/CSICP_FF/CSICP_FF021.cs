using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF021
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff021Filialid { get; set; }

    public string? Ff021Chequeid { get; set; }

    public DateTime? Ff021DataMovimento { get; set; }

    public DateTime? Ff021DataCompensacao { get; set; }

    public string? Ff021Observacao { get; set; }

    public int? Ff021Situacao { get; set; }

    public string? Ff021Motivoid { get; set; }

    public int? Ff021Codmotivodevol { get; set; }

    public bool? Ff025Isactive { get; set; }

    public DateTime? Ff021Dtmovimentoant { get; set; }

    public string? Ff021SituacaoAnt { get; set; }

    public DateTime? Ff021DataCompensAnt { get; set; }

    public int? Ff021Filial { get; set; }

    public int? Ff021SeqMovimento { get; set; }

    public string? Ff021Protocolnumber { get; set; }

    public string? Ff021Usuariopropid { get; set; }

    public virtual CSICP_FF020? Ff021Cheque { get; set; }

    public virtual CSICP_FF002? Ff021Motivo { get; set; }
}

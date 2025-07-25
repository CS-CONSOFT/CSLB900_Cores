using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD085
{
    public int TenantId { get; set; }

    public string Dd085Id { get; set; } = null!;

    public string? Dd085FilialId { get; set; }

    public string? Dd085AtendimentoId { get; set; }

    public int? Dd085Filial { get; set; }

    public decimal? Dd085CiOrigem { get; set; }

    public decimal? Dd085CiD04 { get; set; }

    public string? Dd085Observacao { get; set; }

    public int? Dd085StatuscontaId { get; set; }

    public int? Dd085SituacaocontaId { get; set; }

    public decimal? Dd085Limitecredito { get; set; }

    public decimal? Dd085Limiteparcela { get; set; }

    public decimal? Dd085Saldodevedor { get; set; }

    public decimal? Dd085Valorcotacao { get; set; }

    public decimal? Dd085Saldodisponivel { get; set; }

    public int? Dd085StatusId { get; set; }

    public decimal? Dd085Novolimcredito { get; set; }

    public decimal? Dd085Novolimporparcela { get; set; }

    public decimal? Dd085LimitecreAnt { get; set; }

    public decimal? Dd085Limporparcelaant { get; set; }

    public string? Dd085Protocolnumber { get; set; }

    public virtual CSICP_DD070? Dd085Atendimento { get; set; }

    public virtual CSICP_DD085Status? Dd085Status { get; set; }
}

using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD123
{
    public int TenantId { get; set; }

    public string Dd123MovtoNdId { get; set; } = null!;

    public string? Dd123FilialId { get; set; }

    public string? Dd123UsuariopropId { get; set; }

    public DateTime? Dd123DataMovto { get; set; }

    public DateTime? Dd123DataEmissaoIni { get; set; }

    public DateTime? Dd123DataEmissaoFinal { get; set; }

    public string? Dd123ContaId { get; set; }

    public string? Dd123CcustoId { get; set; }

    public string? Dd123AgcobradorId { get; set; }

    public string? Dd123ResponsavelId { get; set; }

    public string? Dd123FormapagtoId { get; set; }

    public string? Dd123NatoperacaoId { get; set; }

    public string? Dd123StatusId { get; set; }

    public string? Dd040VendaId { get; set; }

    public string? Dd070AtendimentoId { get; set; }

    public string? Dd123Protocolnumber { get; set; }

    public virtual CSICP_DD040? Dd040Venda { get; set; }

    public virtual CSICP_DD070? Dd070Atendimento { get; set; }
}

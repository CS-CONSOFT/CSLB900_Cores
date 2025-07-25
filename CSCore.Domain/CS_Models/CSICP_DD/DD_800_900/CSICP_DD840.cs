using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD840
{
    public int TenantId { get; set; }

    public long Dd840Id { get; set; }

    public string? Dd840EmpresaId { get; set; }

    public string? Dd840LinkorigemNotaid { get; set; }

    public string? Dd840Contaid { get; set; }

    public DateTime? Dd840Datarascunho { get; set; }

    public string? Dd840UsuarioId { get; set; }

    public string? Dd840Formapagamentoid { get; set; }

    public string? Dd840AtId { get; set; }

    public string? Dd840NotaId { get; set; }

    public virtual CSICP_DD070? Dd840At { get; set; }

    public virtual CSICP_DD040? Dd840LinkorigemNota { get; set; }

    public virtual CSICP_DD040? Dd840Nota { get; set; }

}

using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF119
{
    public int TenantId { get; set; }

    public long Ff119Id { get; set; }

    public string? Ff112Id { get; set; }

    public int? Ff119Regid { get; set; }

    public int? Ff119Posicaode { get; set; }

    public int? Ff119Posicaoate { get; set; }

    public string? Ff119Conteudo { get; set; }

    public string? Ff119Descricao { get; set; }

    public virtual CSICP_FF112? Ff112 { get; set; }

    // Propriedades de navegação movidas do RepoDtoCSICP_FF119
    public OsusrE9aCsicpFf112Reg? NavFF112Reg { get; set; }
}

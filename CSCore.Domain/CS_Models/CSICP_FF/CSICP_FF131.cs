using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF131
{
    public int TenantId { get; set; }

    public long Ff131Id { get; set; }

    public string? Ff131Filialid { get; set; }

    public DateTime? Ff131Dregistro { get; set; }

    public string? Ff131Contaid { get; set; }

    public string? Ff131TomadorContaid { get; set; }

    public string? Ff131Usuarioid { get; set; }

    public string? Ff131Observacao { get; set; }

    public bool? Ff131Isefetivado { get; set; }

    public string? Ff131Protocolo { get; set; }

    // Propriedades de navegação movidas do RepoDtoCSICP_FF131
    public CSICP_BB001? NavBB001Filial { get; set; }
    public CSICP_BB012? NavBB012Conta { get; set; }
    public CSICP_BB012? NavBB012TomadorConta { get; set; }
    public Csicp_Sy001? NavSy001Usuario { get; set; }
}

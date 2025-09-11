using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF012
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff012Filialid { get; set; }

    public int? Ff012CodigoGrupo { get; set; }

    public string? Ff012DescricaoGrupo { get; set; }

    public string? Ff012Usuariosuperid { get; set; }

    public string? Ff014Comissaosuperid { get; set; }

    public string? Ff014Comissaocobradorid { get; set; }

    public string? Ff012Grupopaiid { get; set; }

    public virtual CSICP_FF012? Ff012Grupopai { get; set; }

    public virtual CSICP_FF014? Ff014Comissaocobrador { get; set; }

    public virtual CSICP_FF014? Ff014Comissaosuper { get; set; }

    // Navegações movidas do RepoDtoCSICP_FF012
    public CSICP_BB001? NavBB001 { get; set; }
    public Csicp_Sy001? NavSY001 { get; set; }
    public CSICP_FF014? NavFF014ComissaoSuper { get; set; }
    public CSICP_FF014? NavFF014ComissaoCobrador { get; set; }
    public CSICP_FF012? NavFF012GrupoPai { get; set; }
}

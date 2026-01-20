using CSCore.Domain.CS_Models.CSICP_GG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD016
{
    public int TenantId { get; set; }

    public string Dd016Id { get; set; } = null!;

    [ForeignKey("NavBB001FilalID_DD016")]
    public string? Dd016FilialId { get; set; }

    public string? Dd016FormapagtoId { get; set; }

    [ForeignKey("NavBB008CondicaoID_DD016")]
    public string? Dd016CondicaoId { get; set; }

    [ForeignKey("NavGG003GrupoID_DD016")]
    public string? Dd016GrupoId { get; set; }

    [ForeignKey("NavGG004ClasseID_DD016")]
    public string? Dd016ClasseId { get; set; }

    [ForeignKey("NavGG006MarcaID_DD016")]
    public string? Dd016MarcaId { get; set; }

    [ForeignKey("NavGG005ArtigoID_DD016")]
    public string? Dd016ArtigoId { get; set; }

    public decimal? Dd016PercentPvenda { get; set; }

    public decimal? Dd016PercentPedido { get; set; }

    [ForeignKey("NavDD016Aplicacao_DD016")]
    public int? Dd016Aplicacao { get; set; }

    public bool? Dd016Isactive { get; set; }

    public string? Dd016Protocolnumber { get; set; }

    [ForeignKey("NavDD001RComercializ_DD016")]
    public string? Dd001Rcomercializid { get; set; }

    public CSICP_BB001? NavBB001FilialID_DD016 { get; set; }
    public CSICP_Bb008? NavBB008CondicaoID_DD016 { get; set; }
    public CSICP_GG003? NavGG003GrupoID_DD016 { get; set; }
    public CSICP_GG004? NavGG004ClasseID_DD016 { get; set; }
    public CSICP_GG005? NavGG005ArtigoID_DD016 { get; set; }
    public CSICP_GG006? NavGG006MarcaID_DD016 { get; set; }
    public CSICP_DD016Apl? NavDD016Aplicacao_DD016 { get; set; }
    public CSICP_DD001? NavDD001RComercializ_DD016 { get; set; }
}

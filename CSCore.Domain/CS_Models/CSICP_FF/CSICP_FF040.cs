using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class    CSICP_FF040
{
    public int TenantId { get; set; }

    public long Ff040Id { get; set; }

    public string? Ff040Empresaid { get; set; }

    public int? Ff040Tiporegistro { get; set; }

    public DateTime? Ff040DataMovimento { get; set; }

    public string? Ff040ContaId { get; set; }

    public string? Ff040CcustoId { get; set; }

    public string? Ff040EspecieId { get; set; }

    public string? Ff040AgcobradorId { get; set; }

    public string? Ff040ResponsavelId { get; set; }

    public string? Ff040Tipocobrancaid { get; set; }

    public decimal? Ff040Vtransacao { get; set; }

    public string? Ff040Texto { get; set; }

    public string? Ff040UsuarioProprId { get; set; }

    public int? Ff040Situacaoid { get; set; }

    public string? Ff040Protocolnumber { get; set; }

    public DateTime? Ff040Dbasevencto { get; set; }

    public bool? Ff040Isprovisao { get; set; }

    public int? Ff040CtbIscontabilizadoid { get; set; }

    public string? Ff040CtbUsuarioid { get; set; }

    public DateTime? Ff040CtbDtregistro { get; set; }

    public int? Ff040CtbIsestornadoid { get; set; }

    public string? Ff040CtbEstusuarioid { get; set; }

    public DateTime? Ff040CtbEstdtreg { get; set; }

    public long? Ff040CtbIdlancto { get; set; }

    public string? Ff040CtbMsg { get; set; }

    public bool? Ff040CtlIscontabilizadoid { get; set; }

    public string? Ff040CtlUsuarioid { get; set; }

    public DateTime? Ff040CtlDtregistro { get; set; }

    public bool? Ff040CtlIsestornadoid { get; set; }

    public string? Ff040CtlEstusuarioid { get; set; }

    public DateTime? Ff040CtlEstdtreg { get; set; }

    public long? Ff040CtlIdlancto { get; set; }

    public string? Ff040CtlMsg { get; set; }
    public CSICP_Bb005? NavBB005CCustoID { get; set; }

    public CSICP_BB012? NavBB012ContaID { get; set; }

    public CSICP_Bb006? NavBB006AgCobradorID { get; set; }

    public CSICP_BB007? NavBB007ResponsavelID { get; set; }

    public CSICP_FF003? NavFF003EspecieID { get; set; }

    public CSICP_Bb009? NavBB009TipoCobrancaID { get; set; }

    public Csicp_Sy001? NavSY001UsuarioPropID { get; set; }

    public OsusrE9aCsicpFf040Sit? NavFF040SituacaoID { get; set; }

    public virtual CSICP_FF003? Ff040Especie { get; set; }
}

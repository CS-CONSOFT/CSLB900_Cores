using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF140
{
    public int TenantId { get; set; }

    public long Ff140Id { get; set; }

    public DateTime? Ff140Data { get; set; }

    public string? Ff140Contaid { get; set; }

    public string? Ff140Especieid { get; set; }

    public string? Ff140Ccustoid { get; set; }

    public string? Ff140Usuarioproprieid { get; set; }

    public string? Ff140Agcobradorid { get; set; }

    public string? Ff140FpagtoId { get; set; }

    public string? Ff140Condicaoid { get; set; }

    public string? Ff140Tipocobrancaid { get; set; }

    public string? Ff140Descricao { get; set; }

    public string? Ff140Protocolnumber { get; set; }

    public decimal? Ff140Vrequisicao { get; set; }

    public string? Ff140Projetoid { get; set; }

    public int? Ff140Statusid { get; set; }

    public int? Ff140Execucaoid { get; set; }

    public int? Ff140Tpvinculoid { get; set; }

    public int? Ff140QtdeParcelas { get; set; }

    public string? Ff140Estabid { get; set; }

    public int? Ff140AdtoId { get; set; }

    //NavsGetList
    public CSICP_BB001? NavBB001EstabID { get; set; }
    public CSICP_Bb005? NavBB005CCustoID { get; set; }
    public CSICP_Bb006? NavBB006AgCobradorID { get; set; }
    public CSICP_Bb008? NavBB008CondicaoID { get; set; }
    public CSICP_Bb009? NavBB009TpCobrancaID { get; set; }
    public CSICP_BB012? NavBB012ContaID { get; set; }
    public CSICP_Bb026? NavBB026FPagto { get; set; }
    public CSICP_FF003? NavFF003EspecieID { get; set; }
    public Csicp_Sy001? NavSY001UsuarioPropID { get; set; }
    public OsusrE9aCsicpFf140Stum? NavFF140Status { get; set; }
    public OsusrE9aCsicpFf140Exe? NavFF140Exe { get; set; }
    public OsusrE9aCsicpFf140Vin? NavFF140Vinculo { get; set; }

    //NavsListGetByID
    public IEnumerable<CSICP_FF141>? NavListFF141 { get; set; } = [];
    public IEnumerable<CSICP_FF143>? NavListFF143 { get; set; } = [];
    public IEnumerable<CSICP_FF144>? NavListFF144 { get; set; } = [];
}

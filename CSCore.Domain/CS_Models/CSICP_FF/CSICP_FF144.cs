using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF144
{
    private CSICP_FF144() { }
    public int TenantId { get; set; }

    public long Ff144Id { get; set; }

    public long? Ff144RdId { get; set; }

    public DateTime? Ff144Dhregistro { get; set; }

    public string? Ff144Usuarioproprieid { get; set; }

    public int? Ff144Statusid { get; set; }

    public int? Ff144Execucaoid { get; set; }

    public string? F144Observacao { get; set; }

    public CSICP_FF140? NavFF140 { get; set; }
    public CSICP_FF140Sta? NavFF140StatusFF144 { get; set; }
    public OsusrE9aCsicpFf140Exe? NavFF140ExecucaoFF144 { get; set; }
    public Csicp_Sy001? NavSY001UsuarioFF144 { get; set; }

    public static CSICP_FF144 CreateInstance(
         int tenantId,
         long? ff144RdId = null,
         DateTime? ff144Dhregistro = null,
         string? ff144Usuarioproprieid = null,
         int? ff144Statusid = null,
         int? ff144Execucaoid = null,
         string? f144Observacao = null)
    {
        return new CSICP_FF144
        {
            TenantId = tenantId,
            Ff144RdId = ff144RdId,
            Ff144Dhregistro = ff144Dhregistro,
            Ff144Usuarioproprieid = ff144Usuarioproprieid,
            Ff144Statusid = ff144Statusid,
            Ff144Execucaoid = ff144Execucaoid,
            F144Observacao = f144Observacao
        };
    }

    

}

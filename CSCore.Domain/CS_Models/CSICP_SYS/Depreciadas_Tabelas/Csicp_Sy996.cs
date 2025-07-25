using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;

public partial class Csicp_Sy996
{
    public int TenantId { get; set; }

    public string Sy996Id { get; set; } = null!;

    public string? Sy996EmpresaId { get; set; }

    public string? Sy996Objeto { get; set; }

    public string? Sy996Objid { get; set; }

    public string? Sy996Descricao { get; set; }

    public DateTime? Sy996Datahora { get; set; }

    public string? Sy996Usuarioid { get; set; }

    public string? Sy996Nomeusuario { get; set; }

    public string? Sy996Nometimer { get; set; }
}

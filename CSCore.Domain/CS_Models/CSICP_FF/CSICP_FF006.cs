using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF006
{
    public int TenantId { get; set; }

    public long Ff006Id { get; set; }

    public string? Ff102Id { get; set; }

    public decimal? Ff006Vdescjuros { get; set; }

    public decimal? Ff006Pdescjuros { get; set; }

    public DateTime? Ff006Dsolicitacao { get; set; }

    public string? Ff006Usuariosolicid { get; set; }

    public DateTime? Ff006Dresgate { get; set; }

    public string? Ff006Usuarioresgid { get; set; }

    public string? Ff006Chaveautoriz { get; set; }

    public decimal? Ff006Vabertotit { get; set; }

    public decimal? Ff006Vjurostit { get; set; }

    public int? Ff006Datrasotit { get; set; }

    public int? Ff006Statusid { get; set; }

    public string? Ff006Chave { get; set; }

    public string? Ff006Tabela { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }

    public class RepoDtoCSICP_FF006 : CSICP_FF006
    {
        public Csicp_Sy001? NavSy001Solicitante {  get; set; }
        public Csicp_Sy001? NavSy001Resgate {  get; set; }
        public OsusrE9aCsicpFf006Stum? NavFF006Sta { get; set; }
    }
}

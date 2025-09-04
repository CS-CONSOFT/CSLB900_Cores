using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF107
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Ff107Tpregistro { get; set; }

    public string? Ff107Filialid { get; set; }

    public int? Ff107Filial { get; set; }

    public string? Ff102Tituloid { get; set; }

    public string? Ff107Pfx { get; set; }

    public decimal? Ff107Titulo { get; set; }

    public string? Ff107Sfx { get; set; }

    public int? Ff107Codgcliforn { get; set; }

    public string? Ff107Tipolctocontabil { get; set; }

    public string? Ff107Tipomovto { get; set; }

    public DateTime? Ff107Datamovto { get; set; }

    public string? Ff107Usuarioproprid { get; set; }

    public int? Ff107Responsavel { get; set; }

    public string? Ff107Motivoid { get; set; }

    public int? Ff107Codgmotivo { get; set; }

    public string? Ff107Descmotivo { get; set; }

    public decimal? Ff107Valor { get; set; }

    public string? Ff107Observacao { get; set; }

    public string? Ff107Protocolnumber { get; set; }

    public virtual CSICP_FF102? Ff102Titulo { get; set; }

    public virtual CSICP_FF002? Ff107Motivo { get; set; }

    public class RepoDtoCSICP_FF107 : CSICP_FF107
    {
        public CSICP_BB001? NavBB001 { get; set; }
        public Csicp_Sy001? NavSY001 { get; set; }
        public CSICP_FF002? NavFF002 { get; set; }
    }
}

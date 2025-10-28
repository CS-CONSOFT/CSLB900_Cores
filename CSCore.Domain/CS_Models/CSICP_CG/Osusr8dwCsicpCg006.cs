using CSCore.Domain.CS_Models.Staticas.CG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg006
{
    public int TenantId { get; set; }

    public string Cg006Id { get; set; } = null!;

    public string? Cg006FilialId { get; set; }

    public string? Cg006Codigoplano { get; set; }

    public string? Cg006Descricao { get; set; }

    public string? Cg006Descresumida { get; set; }

    public int? Cg006ClassificacaoId { get; set; }

    public int? Cg006NaturezaId { get; set; }

    public int? Cg006TipocontaId { get; set; }

    public int? Cg006Grau { get; set; }

    public string? Cg006CtasuperiorId { get; set; }

    public int? Cg006Codgreduzido { get; set; }

    public string? Cg006GrupoId { get; set; }

    public string? Cg006HistoricoId { get; set; }

    public DateTime? Cg006Dtiniexistencia { get; set; }

    public string? Cg006AmarracaoNivel2 { get; set; }

    public string? Cg006AmarracaoNivel3 { get; set; }

    public string? Cg006AmarracaoNivel4 { get; set; }

    public bool? Cg006Isactive { get; set; }

    public int? Cg006LanctoN2obrig { get; set; }

    public int? Cg006LanctoN3obrig { get; set; }

    public int? Cg006LanctoN4obrig { get; set; }

    public int? Cg006ConsolidaLancto { get; set; }

    public virtual Osusr8dwCsicpCg004? Cg006AmarracaoNivel2Navigation { get; set; }

    public virtual Osusr8dwCsicpCg004? Cg006AmarracaoNivel3Navigation { get; set; }

    public virtual Osusr8dwCsicpCg004? Cg006AmarracaoNivel4Navigation { get; set; }

    public virtual Osusr8dwCsicpCg997? Cg006Classificacao { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg006Ctasuperior { get; set; }

    public virtual Osusr8dwCsicpCg003? Cg006Grupo { get; set; }

    public virtual Osusr8dwCsicpCg005? Cg006Historico { get; set; }

    public virtual Osusr8dwCsicpCg999? Cg006Natureza { get; set; }

    public virtual Osusr8dwCsicpCg996? Cg006Tipoconta { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg006> InverseCg006Ctasuperior { get; set; } = new List<Osusr8dwCsicpCg006>();

    //public virtual ICollection<Osusr8dwCsicpCg009> Osusr8dwCsicpCg009s { get; set; } = new List<Osusr8dwCsicpCg009>();

    //public virtual ICollection<Osusr8dwCsicpCg010> Osusr8dwCsicpCg010s { get; set; } = new List<Osusr8dwCsicpCg010>();

    //public virtual ICollection<Osusr8dwCsicpCg016> Osusr8dwCsicpCg016s { get; set; } = new List<Osusr8dwCsicpCg016>();

    //public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021s { get; set; } = new List<Osusr8dwCsicpCg021>();

    //public virtual ICollection<Osusr8dwCsicpCg033> Osusr8dwCsicpCg033s { get; set; } = new List<Osusr8dwCsicpCg033>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062Contacreds { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062Contadebs { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg074> Osusr8dwCsicpCg074s { get; set; } = new List<Osusr8dwCsicpCg074>();

    //public virtual ICollection<Osusr8dwCsicpCg082> Osusr8dwCsicpCg082s { get; set; } = new List<Osusr8dwCsicpCg082>();

    //public virtual ICollection<Osusr8dwCsicpCg093tmp> Osusr8dwCsicpCg093tmps { get; set; } = new List<Osusr8dwCsicpCg093tmp>();

    //public virtual ICollection<Osusr8dwCsicpCg096tmp> Osusr8dwCsicpCg096tmps { get; set; } = new List<Osusr8dwCsicpCg096tmp>();
}

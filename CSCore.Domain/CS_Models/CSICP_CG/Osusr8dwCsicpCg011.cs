using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg011
{
    public int TenantId { get; set; }

    public string Cg011Id { get; set; } = null!;

    public string? Cg011NivelctagerId { get; set; }

    public string? Cg011FilialId { get; set; }

    public string? Cg011Codigoplano { get; set; }

    public string? Cg011Descricao { get; set; }

    public string? Cg011Descresumida { get; set; }

    public int? Cg011ClassificacaoId { get; set; }

    public int? Cg011NaturezaId { get; set; }

    public int? Cg011TipocontaId { get; set; }

    public int? Cg011Grau { get; set; }

    public string? Cg011CtasuperiorId { get; set; }

    public string? Cg011Codgreduzido { get; set; }

    public string? Cg011GrupoId { get; set; }

    public DateTime? Cg011Dtiniexistencia { get; set; }

    public string? Cg011AmarracaoNivel2 { get; set; }

    public string? Cg011AmarracaoNivel3 { get; set; }

    public string? Cg011AmarracaoNivel4 { get; set; }

    public bool? Cg011Isactive { get; set; }

    public int? Cg011LanctoN2obrig { get; set; }

    public int? Cg011LanctoN3obrig { get; set; }

    public int? Cg011LanctoN4obrig { get; set; }

    public int? Cg011ConsolidaLancto { get; set; }

    //public virtual Osusr8dwCsicpCg004? Cg011AmarracaoNivel2Navigation { get; set; }

    //public virtual Osusr8dwCsicpCg004? Cg011AmarracaoNivel3Navigation { get; set; }

    //public virtual Osusr8dwCsicpCg004? Cg011AmarracaoNivel4Navigation { get; set; }

    //public virtual Osusr8dwCsicpCg997? Cg011Classificacao { get; set; }

    //public virtual Osusr8dwCsicpCg011? Cg011Ctasuperior { get; set; }

    //public virtual Osusr8dwCsicpCg003? Cg011Grupo { get; set; }

    //public virtual Osusr8dwCsicpCg999? Cg011Natureza { get; set; }

    //public virtual Osusr8dwCsicpCg002? Cg011Nivelctager { get; set; }

    //public virtual Osusr8dwCsicpCg996? Cg011Tipoconta { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg011> InverseCg011Ctasuperior { get; set; } = new List<Osusr8dwCsicpCg011>();

    //public virtual ICollection<Osusr8dwCsicpCg012> Osusr8dwCsicpCg012s { get; set; } = new List<Osusr8dwCsicpCg012>();

    //public virtual ICollection<Osusr8dwCsicpCg013> Osusr8dwCsicpCg013s { get; set; } = new List<Osusr8dwCsicpCg013>();

    //public virtual ICollection<Osusr8dwCsicpCg016> Osusr8dwCsicpCg016Cg016ContagerN2Navigations { get; set; } = new List<Osusr8dwCsicpCg016>();

    //public virtual ICollection<Osusr8dwCsicpCg016> Osusr8dwCsicpCg016Cg016ContagerN3Navigations { get; set; } = new List<Osusr8dwCsicpCg016>();

    //public virtual ICollection<Osusr8dwCsicpCg016> Osusr8dwCsicpCg016Cg016ContagerN4Navigations { get; set; } = new List<Osusr8dwCsicpCg016>();

    //public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021Cg021CtagerencialN2s { get; set; } = new List<Osusr8dwCsicpCg021>();

    //public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021Cg021CtagerencialN3s { get; set; } = new List<Osusr8dwCsicpCg021>();

    //public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021Cg021CtagerencialN4s { get; set; } = new List<Osusr8dwCsicpCg021>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062CtagerencialCren2s { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062CtagerencialCren3s { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062CtagerencialCren4s { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062CtagerencialDebn2s { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062CtagerencialDebn3s { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062CtagerencialDebn4s { get; set; } = new List<Osusr8dwCsicpCg062>();

    //public virtual ICollection<Osusr8dwCsicpCg074> Osusr8dwCsicpCg074Cg074CtagerencialN2s { get; set; } = new List<Osusr8dwCsicpCg074>();

    //public virtual ICollection<Osusr8dwCsicpCg074> Osusr8dwCsicpCg074Cg074CtagerencialN3s { get; set; } = new List<Osusr8dwCsicpCg074>();

    //public virtual ICollection<Osusr8dwCsicpCg074> Osusr8dwCsicpCg074Cg074CtagerencialN4s { get; set; } = new List<Osusr8dwCsicpCg074>();
}

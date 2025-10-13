using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class OsusrTo3CsicpRr001
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr001Serie { get; set; }

    public int? Rr001Nrorgn { get; set; }

    public string? Rr001Nomeanimal { get; set; }

    public string? Rr001Apelido { get; set; }

    public DateTime? Rr001Dtnascimento { get; set; }

    public decimal? Rr001Pesonasc { get; set; }

    public int? Rr001Sexoid { get; set; }

    public string? Rr001Fazendaid { get; set; }

    public long? Rr001Catid { get; set; }

    public long? Rr001Racaid { get; set; }

    public string? Rr001PaiId { get; set; }

    public string? Rr001MaeId { get; set; }

    public int? Rr001Ativoid { get; set; }

    public long? Rr001Situacaoid { get; set; }

    public DateTime? Rr001Dtregistro { get; set; }

    public string? Rr001Usuariopropid { get; set; }

    public string? Rr001Observacao { get; set; }

    public int? Rr001Categoriaid { get; set; }

    public DateTime? Rr001Dtcategoria { get; set; }

    public long? Rr001Ocorrenciaid { get; set; }

    public DateTime? Rr001Dtocorrencia { get; set; }

    public DateTime? Rr001Dtultpeso { get; set; }

    public decimal? Rr001Ultpeso { get; set; }

    public int? Rr001Ultidadediaspeso { get; set; }

    public long? Rr001Proprietarioid { get; set; }

    //public virtual ICollection<OsusrTo3CsicpRr001> InverseRr001Mae { get; set; } = new List<OsusrTo3CsicpRr001>();

    //public virtual ICollection<OsusrTo3CsicpRr001> InverseRr001Pai { get; set; } = new List<OsusrTo3CsicpRr001>();

    //public virtual ICollection<OsusrTo3CsicpRr021> OsusrTo3CsicpRr021s { get; set; } = new List<OsusrTo3CsicpRr021>();

    //public virtual ICollection<OsusrTo3CsicpRr022> OsusrTo3CsicpRr022s { get; set; } = new List<OsusrTo3CsicpRr022>();

    //public virtual ICollection<OsusrTo3CsicpRr031> OsusrTo3CsicpRr031Rr031Animals { get; set; } = new List<OsusrTo3CsicpRr031>();

    //public virtual ICollection<OsusrTo3CsicpRr031> OsusrTo3CsicpRr031Rr031Montaanimals { get; set; } = new List<OsusrTo3CsicpRr031>();

    public virtual OsusrTo3CsicpRr001Ativo? Rr001Ativo { get; set; }

    public virtual OsusrTo3CsicpRr003? Rr001Cat { get; set; }

    public virtual OsusrTo3CsicpRr001Cat? Rr001Categoria { get; set; }

    public virtual OsusrTo3CsicpRr002? Rr001Fazenda { get; set; }

    public virtual OsusrTo3CsicpRr001? Rr001Mae { get; set; }

    public virtual OsusrTo3CsicpRr006? Rr001Ocorrencia { get; set; }

    public virtual OsusrTo3CsicpRr001? Rr001Pai { get; set; }

    public virtual OsusrTo3CsicpRr007? Rr001Proprietario { get; set; }

    public virtual OsusrTo3CsicpRr004? Rr001Raca { get; set; }

    public virtual OsusrTo3CsicpRr001Sexo? Rr001Sexo { get; set; }

    public virtual OsusrTo3CsicpRr005? Rr001Situacao { get; set; }
}

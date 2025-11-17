using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_RR;

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

    [ForeignKey("NavRR001Sexo_RR001")]
    public int? Rr001Sexoid { get; set; }

    [ForeignKey("NavRR002Fazenda_RR001")]
    public string? Rr001Fazendaid { get; set; }

    [ForeignKey("NavRR003CadastroCat_RR001")]
    public long? Rr001Catid { get; set; }

    [ForeignKey("NavRR004Raca_RR001")]
    public long? Rr001Racaid { get; set; }

    [ForeignKey("NavRR001Pai")]
    public string? Rr001PaiId { get; set; }

    [ForeignKey("NavRR001Mae")]
    public string? Rr001MaeId { get; set; }

    [ForeignKey("NavRR001Ativo_RR001")]
    public int? Rr001Ativoid { get; set; }

    [ForeignKey("NavRR005Situacao_RR001")]
    public long? Rr001Situacaoid { get; set; }

    public DateTime? Rr001Dtregistro { get; set; }

    [ForeignKey("NavSy001_RR001")]
    public string? Rr001Usuariopropid { get; set; }

    public string? Rr001Observacao { get; set; }

    [ForeignKey("NavRR001Categoria_RR001")]
    public int? Rr001Categoriaid { get; set; }

    public DateTime? Rr001Dtcategoria { get; set; }

    [ForeignKey("NavRR006Ocorrencia_RR001")]
    public long? Rr001Ocorrenciaid { get; set; }

    public DateTime? Rr001Dtocorrencia { get; set; }

    public DateTime? Rr001Dtultpeso { get; set; }

    public decimal? Rr001Ultpeso { get; set; }

    public int? Rr001Ultidadediaspeso { get; set; }

    [ForeignKey("NavRR007Proprietario_RR001")]
    public long? Rr001Proprietarioid { get; set; }

    public OsusrTo3CsicpRr001? NavRR001Pai { get; set; }
    public OsusrTo3CsicpRr001? NavRR001Mae { get; set; }
    public OsusrTo3CsicpRr002? NavRR002Fazenda_RR001 { get; set; }
    public OsusrTo3CsicpRr003? NavRR003CadastroCat_RR001 { get; set; }
    public OsusrTo3CsicpRr004? NavRR004Raca_RR001 { get; set; }
    public OsusrTo3CsicpRr005? NavRR005Situacao_RR001 { get; set; }
    public OsusrTo3CsicpRr006? NavRR006Ocorrencia_RR001 { get; set; }
    public OsusrTo3CsicpRr007? NavRR007Proprietario_RR001 { get; set; }
    public OsusrTo3CsicpRr001Ativo? NavRR001Ativo_RR001 { get; set; }
    public OsusrTo3CsicpRr001Cat? NavRR001Categoria_RR001 { get; set; }
    public OsusrTo3CsicpRr001Sexo? NavRR001Sexo_RR001 { get; set; }
    public Csicp_Sy001? NavSy001_RR001 { get; set; }
}
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

    // ===== PROPRIEDADES DE BANCO - MANTIDAS PARA O EF =====
    public DateTime? Rr001Dtultpeso { get; set; }

    public decimal? Rr001Ultpeso { get; set; }

    public int? Rr001Ultidadediaspeso { get; set; }
    // ========================================================

    [ForeignKey("NavRR007Proprietario_RR001")]
    public long? Rr001Proprietarioid { get; set; }

    // Novos campos adicionados posteriormente

    [ForeignKey("NavRR007Proprietario2id_RR001")]
    public long? Rr001Proprietario2id { get; set; }

    [ForeignKey("NavRR001Criadorid_RR001")]
    public long? Rr001Criadorid { get; set; }

    // Navegação
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

    // Novos navs adicionados posteriormente
    public OsusrTo3CsicpRr007? NavRR007Proprietario2id_RR001 { get; set; }

    public OsusrTo3CsicpRr007? NavRR001Criadorid_RR001 { get; set; }

    //-----//

    // ===== VALUE OBJECT - NÃO MAPEADO NO BANCO =====
    /// <summary>
    /// Value Object com validações para última pesagem.
    /// Não mapeado no banco - use para lógica de negócio com validações.
    /// </summary>
    [NotMapped]
    public UltimoPesoAnimal UltimoPeso
    {
        get => new(Rr001Dtultpeso, Rr001Ultpeso);
        set
        {
            Rr001Dtultpeso = value.DataUltimoPeso;
            Rr001Ultpeso = value.Peso;
            Rr001Ultidadediaspeso = value.DiasDesdeUltimoPeso;
        }
    }

    /// <summary>
    /// Define o último peso COM VALIDAÇÕES usando o Value Object
    /// </summary>
    public void DefinirUltimoPesoQuandoOPesoENull(DateTime? InDataUltPeso, decimal? InUltPeso)
    {
        // Isso dispara as validações do value object
        if (this.Rr001Dtultpeso != null)
        {
            return;
        }

        UltimoPeso = new UltimoPesoAnimal(InDataUltPeso, InUltPeso);
    }

    /// <summary>
    /// Define o último peso SEM VALIDAÇÕES (uso direto - para Entity Framework)
    /// </summary>
    public void DefinirUltimoPesoSemValidacao(DateTime? data, decimal? peso, int? diasDesdeUltimoPeso)
    {
        Rr001Dtultpeso = data;
        Rr001Ultpeso = peso;
        Rr001Ultidadediaspeso = diasDesdeUltimoPeso;
    }
}

/// <summary>
/// Value Object que representa a data e o peso do último registro de pesagem do animal
/// </summary>
public readonly record struct UltimoPesoAnimal
{
    public DateTime? DataUltimoPeso { get; }
    public decimal? Peso { get; }

    public UltimoPesoAnimal(DateTime? InDataUltPeso, decimal? InUltPeso)
    {
        ValidarDados(InDataUltPeso, InUltPeso);

        DataUltimoPeso = InDataUltPeso;
        Peso = InUltPeso;
    }

    private static void ValidarDados(DateTime? InDataUltPeso, decimal? InUltPeso)
    {
        // Se ambos forem nulos, é válido (sem registro de peso)
        if (!InDataUltPeso.HasValue && !InUltPeso.HasValue)
            return;

        // Se um tem valor e o outro não, é inconsistente
        if (InDataUltPeso.HasValue && !InUltPeso.HasValue)
            throw new ArgumentException("Quando há data de último peso, o peso deve ser informado.");

        if (!InDataUltPeso.HasValue && InUltPeso.HasValue)
            throw new ArgumentException("Quando há peso informado, a data deve ser fornecida.");

        // Validações quando ambos têm valor
        if (InDataUltPeso.HasValue && InUltPeso.HasValue)
        {
            if (InDataUltPeso.Value > DateTime.Now)
                throw new ArgumentException("A data do último peso não pode ser futura.");

            if (InUltPeso.Value <= 0)
                throw new ArgumentException("O peso deve ser maior que zero.");

            if (InUltPeso.Value > 9999.99m)
                throw new ArgumentException("O peso não pode exceder 9999.99 kg.");
        }
    }

    /// <summary>
    /// Indica se há registro de peso
    /// </summary>
    public bool TemRegistroPeso => DataUltimoPeso.HasValue && Peso.HasValue;

    /// <summary>
    /// Calcula quantos dias se passaram desde o último registro de peso
    /// </summary>
    public int? DiasDesdeUltimoPeso
    {
        get
        {
            if (!DataUltimoPeso.HasValue)
                return null;

            return (int)(DateTime.Now.Date - DataUltimoPeso.Value.Date).TotalDays;
        }
    }

    public override string ToString()
    {
        if (!TemRegistroPeso)
            return "Sem registro de peso";

        return $"Peso: {Peso:N2} kg em {DataUltimoPeso:dd/MM/yyyy} ({DiasDesdeUltimoPeso} dias atrás)";
    }
}
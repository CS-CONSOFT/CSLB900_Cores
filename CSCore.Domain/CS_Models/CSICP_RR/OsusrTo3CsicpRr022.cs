using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr022
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    [ForeignKey("NavRR021LoteXAnimal_RR022")]
    public string? Rr022Loteid { get; set; }

    [ForeignKey("NavRR001Animal_RR022")]
    public string? Rr022Animalid { get; set; }

    public DateTime? Rr022Dtpeso { get; set; }

    public int? Rr022Idadediasatual { get; set; }

    public decimal? Rr022Peso { get; set; }

    public DateTime? Rr001Dtultpeso { get; set; }

    public decimal? Rr001Ultpeso { get; set; }

    public int? Rr022Idadediasult { get; set; }

    public decimal? Rr022Gmd { get; set; }

    public decimal? Rr022Gpd { get; set; }

    public DateTime? Rr022Dthrregistro { get; set; }

    public string? Rr022Usuarioid { get; set; }

    public bool? Rr022IsProcessado { get; set; }

    public OsusrTo3CsicpRr001? NavRR001Animal_RR022 { get; set; } = null;

    public OsusrTo3CsicpRr021? NavRR021LoteXAnimal_RR022 { get; set; } = null;

    public void CalcularIdadeDiasAtual()
    {
        if (this.NavRR001Animal_RR022 == null)
        {
            throw new InvalidOperationException("A navegação NavRR001Animal_RR022 não está carregada.");
        }
        if (this.NavRR001Animal_RR022.Rr001Dtnascimento == null)
        {
            throw new InvalidOperationException("A data de nascimento do animal não está definida.");
        }

        // Idade em dias atual = data atual - data nascimento
        this.Rr022Idadediasatual = (int)(DateTime.UtcNow.ToLocalTime() - this.NavRR001Animal_RR022.Rr001Dtnascimento.Value)
            .TotalDays;
    }

    public void CalcularIdadeDiasUlt()
    {
        if (this.NavRR001Animal_RR022 == null)
            throw new InvalidOperationException("A navegação NavRR001Animal_RR022 não está carregada.");

        if (this.NavRR001Animal_RR022.Rr001Dtnascimento == null)
            throw new InvalidOperationException("A data de nascimento do animal não está definida.");

        if (this.NavRR001Animal_RR022.Rr001Dtultpeso == null)
            throw new InvalidOperationException("A data do último peso do animal não está definida.");

        // Idade em dias do ultimo peso = data ultimo peso - data nascimento
        this.Rr022Idadediasult = (int?)(NavRR001Animal_RR022.Rr001Dtultpeso.Value - NavRR001Animal_RR022.Rr001Dtnascimento.Value).TotalDays;
    }

    public void CalcularGmd()
    {
        if (this.NavRR001Animal_RR022 == null)
            throw new InvalidOperationException("A navegação NavRR001Animal_RR022 não está carregada.");

        if (!this.Rr022Peso.HasValue)
            throw new InvalidOperationException("O peso atual do animal não está definido.");

        if (!this.Rr022Dtpeso.HasValue)
            throw new InvalidOperationException("A data do peso atual não está definida.");

        decimal pesoAnterior = this.Rr001Ultpeso
                              ?? this.NavRR001Animal_RR022.Rr001Pesonasc
                              ?? throw new InvalidOperationException("Não há peso anterior disponível (último peso ou peso de nascimento).");

        DateTime dataAnterior = this.Rr001Dtultpeso
                               ?? this.NavRR001Animal_RR022.Rr001Dtnascimento
                               ?? throw new InvalidOperationException("Não há data anterior disponível (data do último peso ou data de nascimento).");

        int diasDecorridos = (int)(this.Rr022Dtpeso.Value - dataAnterior).TotalDays;

        if (diasDecorridos <= 0)
            throw new InvalidOperationException("A diferença entre as datas deve ser maior que zero.");

        this.Rr022Gmd = (this.Rr022Peso.Value - pesoAnterior) / diasDecorridos;
    }

    public void CalcularGpd()
    {
        // Validações da navegação
        if (this.NavRR001Animal_RR022 == null)
            throw new InvalidOperationException("A navegação NavRR001Animal_RR022 não está carregada.");

        // Validação do peso atual
        if (!this.Rr022Peso.HasValue)
            throw new InvalidOperationException("O peso atual do animal não está definido.");

        // Validação da data atual do peso
        if (!this.Rr022Dtpeso.HasValue)
            throw new InvalidOperationException("A data do peso atual não está definida.");

        // Validação da data da última pesagem
        if (!this.Rr001Dtultpeso.HasValue)
            throw new InvalidOperationException("A data da última pesagem não está definida.");

        // Obter peso de nascimento ou usar peso padrão baseado no sexo
        // Sexo: 1 = Macho (30 kg), 2 = Fêmea (28 kg)
        decimal pesoNascimento;
        if (this.NavRR001Animal_RR022.Rr001Pesonasc.HasValue)
        {
            pesoNascimento = this.NavRR001Animal_RR022.Rr001Pesonasc.Value;
        }
        else
        {
            // Se não houver peso de nascimento, usar peso padrão baseado no sexo
            if (!this.NavRR001Animal_RR022.Rr001Sexoid.HasValue)
                throw new InvalidOperationException("O sexo do animal não está definido para calcular o peso padrão de nascimento.");

            pesoNascimento = this.NavRR001Animal_RR022.Rr001Sexoid.Value == 1 ? 30m : 28m;
        }

        // Calcular diferença de dias
        int diasDecorridos = (int)(this.Rr022Dtpeso.Value - this.Rr001Dtultpeso.Value).TotalDays;

        // Validar que há dias decorridos para evitar divisão por zero
        if (diasDecorridos <= 0)
            throw new InvalidOperationException("A diferença entre as datas deve ser maior que zero.");

        // Calcular GPD: (Peso Atual - Peso Nascimento) / Dias Decorridos
        this.Rr022Gpd = (this.Rr022Peso.Value - pesoNascimento) / diasDecorridos;
    }
}

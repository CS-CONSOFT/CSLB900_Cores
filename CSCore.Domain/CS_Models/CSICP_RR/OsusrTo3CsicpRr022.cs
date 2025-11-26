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

    public CSResult<string> CalcularIdadeDiasAtual()
    {

        if (this.NavRR001Animal_RR022 == null)
            return CSResult<string>.Failure("Os dados do animal não estão disponíveis.");


        if (this.NavRR001Animal_RR022.Rr001Dtnascimento == null)
            return CSResult<string>.Failure("A data de nascimento do animal não está definida.");

        // Idade em dias atual = data atual - data nascimento
        var idadeDiasAtualSub = (this.Rr022Dtpeso - this.NavRR001Animal_RR022.Rr001Dtnascimento.Value);
        this.Rr022Idadediasatual = (int?)idadeDiasAtualSub?.TotalDays;

        return CSResult<string>.Success("Idade em dias atual calculada com sucesso.");
    }

    public CSResult<string> CalcularIdadeDiasUlt()
    {
        if (this.NavRR001Animal_RR022 == null)
            return CSResult<string>.Failure("Os dados do animal não estão disponíveis.");

        if (this.NavRR001Animal_RR022.Rr001Dtnascimento == null)
            return CSResult<string>.Failure("A data de nascimento do animal não está definida.");

        // Idade em dias do ultimo peso = data ultimo peso - data nascimento
        this.Rr022Idadediasult = (int?)(NavRR001Animal_RR022.Rr001Dtultpeso.Value - NavRR001Animal_RR022.Rr001Dtnascimento.Value).TotalDays;
        
        return CSResult<string>.Success("Idade em dias do último peso calculada com sucesso.");
    }

    /// <summary>
    /// Calcular GMD (Ganho Médio Diário)
    /// Métrica GMD (Ganho Médio Diário)
    /// GMD = (peso atual – último peso) / (data peso atual – última data peso)
    /// Se não houver último peso, considera peso de nascimento.
    /// Se não houver valor de nascimento, considera zero.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>

    public CSResult<string> CalcularGmd()
    {
        if (this.NavRR001Animal_RR022 == null)
            return CSResult<string>.Failure("Os dados do animal não estão disponíveis.");

        if (!this.Rr022Peso.HasValue)
            return CSResult<string>.Failure("O peso atual do animal não está definido.");

        if (!this.Rr022Dtpeso.HasValue)
            return CSResult<string>.Failure("A data do peso atual não está definida.");

        // Validar último peso
        decimal ultimoPeso = this.Rr001Ultpeso
                              ?? this.NavRR001Animal_RR022.Rr001Pesonasc
                              ?? 0m;

        if (ultimoPeso == 0m)
            return CSResult<string>.Failure("Não há último peso disponível (último peso ou peso de nascimento).");

        // Validar última data de peso
        DateTime? ultimaDataPeso = this.Rr001Dtultpeso
                                   ?? this.NavRR001Animal_RR022.Rr001Dtnascimento;

        if (ultimaDataPeso == null)
            return CSResult<string>.Failure("Não há última data disponível (data do último peso ou data de nascimento).");

        int diasDecorridos = (int)(this.Rr022Dtpeso.Value - ultimaDataPeso.Value).TotalDays;

        if (diasDecorridos <= 0)
            return CSResult<string>.Failure("A diferença entre as datas deve ser maior que zero.");

        this.Rr022Gmd = (this.Rr022Peso.Value - ultimoPeso) / diasDecorridos;
        return CSResult<string>.Success("GMD calculado com sucesso.");
    }

    /// <summary>
    /// Métrica GPD
    /// GPD = (peso atual – peso nascimento, caso não exista é 30 para macho ou 28 para fêmea) / (data peso atual – última data pesagem)
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public CSResult<string> CalcularGpd()
    {
        // Validações da navegação
        if (this.NavRR001Animal_RR022 == null)
            return CSResult<string>.Failure("A navegação NavRR001Animal_RR022 não está carregada.");

        // Validação do peso atual
        if (!this.Rr022Peso.HasValue)
            return CSResult<string>.Failure("O peso atual do animal não está definido.");

        // Validação da data atual do peso
        if (!this.Rr022Dtpeso.HasValue)
            return CSResult<string>.Failure("A data do peso atual não está definida.");

        // Obter peso de nascimento ou usar peso padrão baseado no sexo
        // Sexo: 1 = Macho (30 kg), 2 = Fêmea (28 kg)
        #warning @colocar essa regra de peso nascimento lá na classe DEFINIR PADRÕES feito pelo Valter
        decimal pesoNascimento;
        if (this.NavRR001Animal_RR022.Rr001Pesonasc.HasValue)
        {
            pesoNascimento = this.NavRR001Animal_RR022.Rr001Pesonasc.Value;
        }
        else
        {
            // Se não houver peso de nascimento, usar peso padrão baseado no sexo
            if (!this.NavRR001Animal_RR022.Rr001Sexoid.HasValue)
                return CSResult<string>.Failure("O sexo do animal não está definido para calcular o peso padrão de nascimento.");

            pesoNascimento = this.NavRR001Animal_RR022.Rr001Sexoid.Value == 1 ? 30m : 28m;
        }
        // Calcular diferença de dias
        int diasDecorridos = (int)(this.Rr022Dtpeso.Value - this.Rr001Dtultpeso.Value).TotalDays;

        // Validar que há dias decorridos para evitar divisão por zero
        if (diasDecorridos <= 0)
            return CSResult<string>.Failure("A diferença entre as datas deve ser maior que zero.");

        // Calcular GPD: (Peso Atual - Peso Nascimento) / Dias Decorridos
        this.Rr022Gpd = (this.Rr022Peso.Value - pesoNascimento) / diasDecorridos;
        
        return CSResult<string>.Success("GPD calculado com sucesso.");
    }
}

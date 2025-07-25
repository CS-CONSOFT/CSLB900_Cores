

namespace CSCore.Domain;

public partial class CSICP_BB01202
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Bb012Cnpj { get; set; } = string.Empty!;

    public decimal? Bb012Inscestadual { get; set; }

    public string? Bb012Suframa { get; set; }

    public int? Bb012Regsuframavalido { get; set; }

    public string? Bb012Regjuntacomercial { get; set; }

    public DateTime? Bb012Dataregjunta { get; set; }

    public decimal? Bb012Patrimonio { get; set; }

    public decimal? Bb012CapitalSocial { get; set; }

    public decimal? Bb012Cpf { get; set; }

    public decimal? Bb012Rg { get; set; }

    public string? Bb012Complementorg { get; set; }

    public DateTime? Bb012Emissaorg { get; set; }

    public decimal? Bb012Pis { get; set; }

    public DateTime? Bb012Residedesde { get; set; }

    public decimal? Bb012Nrodependentes { get; set; }

    public DateTime? Bb012Empadmissao { get; set; }

    public string? Bb012EmpProfissao { get; set; }

    public decimal? Bb012Valorremuneracao { get; set; }

    public decimal? Bb012Outrosrendimentos { get; set; }

    public string? Bb012Origemoutrosrend { get; set; }

    public int? Bb012InscEstSniId { get; set; }

    public int? Bb012SexoId { get; set; }

    public int? Bb012EstadocivilId { get; set; }

    public int? Bb012TipodomicilioId { get; set; }

    public int? Bb012Compresid01Id { get; set; }

    public int? Bb012Compresid02Id { get; set; }

    public int? Bb012GescolaridadeId { get; set; }

    public int? Bb012OcupacaoId { get; set; }

    public string? Bb012NaturaldeId { get; set; }

    public int? Bb012TptributacaoId { get; set; }

    public string? Bb012IdentEstrangeiro { get; set; }

    public string? Bb012Empresa { get; set; }

    public string? Bb012EmpEndereco { get; set; }

    public int? Bb012EmpGrupoId { get; set; }

    public int? Bb012Motdesoneracaoid { get; set; }

    public CSICP_Bb012Stacta? BB012_RegSUFRAMAValido { get; set; }
    public CSICP_Bb01202Ins? BB012_Insc_Est_SNI { get; set; }
    public CSICP_Bb01202Sex? BB012_Sexo { get; set; }
    public CSICP_Bb01202Eciv? BB012_EstadoCivil { get; set; }
    public CSICP_Bb01202Dom? BB012_Domicilio { get; set; }
    public CSICP_Bb01202Res? BB012_ComprovanteResidencia1 { get; set; }
    public CSICP_Bb01202Res? BB012_ComprovanteResidencia2 { get; set; }
    public CSICP_Bb01202Esc? BB012_Escolaridade { get; set; }
    public CSICP_Bb01202Ocu? BB012_Ocupacao { get; set; }
    public CSICP_Aa028? AA028_NatualDe { get; set; }
    public CSICP_BB001TpTri? BB001_Tributacao { get; set; }
    public CSICP_Bb012Gructa? BB012_TipoDaEmpresaTrabalho { get; set; }
    public CSICP_Bb027Motivo? BB027_MotivoDesoneracao { get; set; }
}

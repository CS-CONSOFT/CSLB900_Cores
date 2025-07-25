

using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;


namespace CSBS101._82Application.Dto.BB00X.BB012.Get
{
    public class Dto_GetBB01202
    {
        public string Id { get; set; } = null!;

        public string? Bb012Cnpj { get; set; }

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
        public CSICP_Bb012Stacta? NavBB012_RegSUFRAMAValido { get; set; } = null;
        public CSICP_Bb01202Ins? NavBB012_Insc_Est_SNI { get; set; } = null;
        public CSICP_Bb01202Sex? NavBB012_Sexo { get; set; } = null;
        public CSICP_Bb01202Eciv? NavBB012_EstadoCivil { get; set; } = null;
        public CSICP_Bb01202Dom? NavBB012_Domicilio { get; set; } = null;
        public CSICP_Bb01202Res? NavBB012_ComprovanteResidencia1 { get; set; } = null;
        public CSICP_Bb01202Res? NavBB012_ComprovanteResidencia2 { get; set; } = null;
        public CSICP_Bb01202Esc? NavBB012_Escolaridade { get; set; } = null;
        public CSICP_Bb01202Ocu? NavBB012_Ocupacao { get; set; } = null;
        public Dto_GetAA028_Exibicao? NavAA028_NatualDe { get; set; } = null;
        public CSICP_BB001TpTri? NavBB001_Tributacao { get; set; } = null;
        public CSICP_Bb012Gructa? NavBB012_TipoDaEmpresaTrabalho { get; set; } = null;
        public CSICP_Bb027Motivo? NavBB027_MotivoDesoneracao { get; set; } = null;
    }
}


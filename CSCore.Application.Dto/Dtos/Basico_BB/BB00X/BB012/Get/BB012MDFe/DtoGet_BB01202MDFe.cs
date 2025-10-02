using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get.BB012MDFe
{
    public class DtoGet_BB01202MDFe
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

        public CSICP_Bb01202Ins? NavBB01202Ins { get; set; }

    }
}

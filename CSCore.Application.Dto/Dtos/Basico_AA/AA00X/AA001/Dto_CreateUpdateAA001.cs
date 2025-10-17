using CSCore.Domain;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X.AA001
{
    public class Dto_CreateUpdateAA001 : IConverteParaEntidade<CSICP_AA001>
    {
        [Range(0, double.MaxValue, ErrorMessage = "Aa001Filial deve ser um valor decimal válido.")]
        public decimal? Aa001Filial { get; set; }

        [StringLength(50, ErrorMessage = "Aa001Identificacao não pode ter mais de 50 caracteres.")]
        public string? Aa001Identificacao { get; set; }

        [StringLength(50, ErrorMessage = "Aa001Tipo não pode ter mais de 50 caracteres.")]
        public string? Aa001Tipo { get; set; }

        [StringLength(250, ErrorMessage = "Aa001Conteudo não pode ter mais de 250 caracteres.")]
        public string? Aa001Conteudo { get; set; }

        [StringLength(250, ErrorMessage = "Aa001Descricao não pode ter mais de 250 caracteres.")]
        public string? Aa001Descricao { get; set; }

        [StringLength(36, ErrorMessage = "Aa001Filialid não pode ter mais de 36 caracteres.")]
        public string? Aa001Filialid { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "Aa001Json não pode ter mais de 250 caracteres.")]
        public string? Aa001Json { get; set; }

        public CSICP_AA001 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_AA001()
            {
                Id = id!,
                TenantId = tenant,
                Aa001Filial = this.Aa001Filial,
                Aa001Identificacao = this.Aa001Identificacao,
                Aa001Tipo = this.Aa001Tipo,
                Aa001Conteudo = this.Aa001Conteudo,
                Aa001Descricao = this.Aa001Descricao,
                Aa001Filialid = this.Aa001Filialid,
                Aa001Json = this.Aa001Json
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

    }
}

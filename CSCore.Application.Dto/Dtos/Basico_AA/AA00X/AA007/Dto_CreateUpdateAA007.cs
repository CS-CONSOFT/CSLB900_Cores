using CSCore.Domain;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X.AA007
{
    public class Dto_CreateUpdateAA007 : IConverteParaEntidade<CSICP_Aa007>
    {
        [MaxLength(50, ErrorMessage = "A descrição não pode ter mais que 50 caracteres.")]
        [DefaultValue("")]
        public string? Aa007Descricao { get; set; }

        [DefaultValue("")]
        [Required(ErrorMessage = "O modelo de e-mail é obrigatório.")]
        public string? Aa007Modeloemail { get; set; }

        [DefaultValue(0)]
        [Range(0, int.MaxValue, ErrorMessage = "O tipo deve ser um número positivo.")]
        public int? Aa007Tipo { get; set; }

        [DefaultValue(0)]
        [Range(0, int.MaxValue, ErrorMessage = "O uso deve ser um número positivo.")]
        public int? Aa007Uso { get; set; }

        public CSICP_Aa007 ToEntity(int tenant, string? _)
        {
            var entity = new CSICP_Aa007()
            {
                TenantId = tenant,
                Aa007Descricao = this.Aa007Descricao,
                Aa007Modeloemail = this.Aa007Modeloemail,
                Aa007Tipo = this.Aa007Tipo,
                Aa007Uso = this.Aa007Uso,
                Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

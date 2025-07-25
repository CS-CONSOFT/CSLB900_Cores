using CSCore.Domain;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Consumidor.Profissional
{
    /// <summary>
    /// DTO para avaliação de profissionais
    /// </summary>
    public class DtoPostAvaliacao
    {
        /// <summary>
        /// ID do profissional sendo avaliado
        /// </summary>
        [Required(ErrorMessage = "ProfissionalID é obrigatório")]
        [StringLength(36, ErrorMessage = "ProfissionalID deve ter 36 caracteres")]
        public string ProfissionalID { get; set; } = string.Empty;

        /// <summary>
        /// ID da conta que está avaliando
        /// </summary>
        [Required(ErrorMessage = "ContaID é obrigatório")]
        [StringLength(36, ErrorMessage = "ContaID deve ter 36 caracteres")]
        public string ContaID { get; set; } = string.Empty;

        /// <summary>
        /// Nota da avaliação (1-5)
        /// </summary>
        [Required(ErrorMessage = "Rate é obrigatório")]
        [Range(1, 5, ErrorMessage = "Rate deve ser entre 1 e 5")]
        public int Rate { get; set; }

        /// <summary>
        /// Mensagem/Comentário da avaliação
        /// </summary>
        [StringLength(500, ErrorMessage = "Mensagem não pode exceder 500 caracteres")]
        public string Mensagem { get; set; } = string.Empty;

        public CSICP_Bb056 ToEntity(int tenant)
        {
            return new CSICP_Bb056
            {
                TenantId = tenant,
                Bb056Profid = this.ProfissionalID,
                Bb056Contaid = this.ContaID,
                Bb056Rate = this.Rate,
                Bb056Mensagem = this.Mensagem,
                Bb056Datahora = DateTime.UtcNow.ToLocalTime(),
                Bb056Isactive = false
            };
        }
    }
}

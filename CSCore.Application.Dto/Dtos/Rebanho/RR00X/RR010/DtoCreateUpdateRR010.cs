using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR010
{
    /// <summary>
    /// DTO para criação e atualização de Condição de Criação (RR010)
    /// </summary>
    public class DtoCreateUpdateRR010 : IConverteParaEntidade<OsusrTo3CsicpRr010>
    {
        /// <summary>
        /// Condição de Criação (Obrigatório, máx 50 caracteres)
        /// </summary>
        [Required(ErrorMessage = "O campo RR010_CONDCRIACAO é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo RR010_CONDCRIACAO deve ter no máximo 50 caracteres")]
        public string Rr010Condcriacao { get; set; } = null!;

        /// <summary>
        /// Descrição detalhada (Obrigatório, máx 500 caracteres)
        /// </summary>
        [Required(ErrorMessage = "O campo RR010_DESCRITIVO é obrigatório")]
        [StringLength(500, ErrorMessage = "O campo RR010_DESCRITIVO deve ter no máximo 500 caracteres")]
        public string Rr010Descritivo { get; set; } = null!;

        public OsusrTo3CsicpRr010 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr010
            {
                TenantId = tenant,
                Rr010Condcriacao = this.Rr010Condcriacao,
                Rr010Descritivo = this.Rr010Descritivo
            };
        }
    }
}
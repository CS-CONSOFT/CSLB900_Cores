using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR009
{
    /// <summary>
    /// DTO para criação e atualização de relacionamento Animal x Animal Virtual (RR009)
    /// </summary>
    public class DtoCreateUpdateRR009 : IConverteParaEntidade<OsusrTo3CsicpRr009>
    {
        /// <summary>
        /// ID do Animal Real (Obrigatório)
        /// </summary>
        [Required(ErrorMessage = "O campo RR001_ID é obrigatório")]
        [StringLength(36, ErrorMessage = "O campo RR001_ID deve ter no máximo 36 caracteres")]
        public string Rr001Id { get; set; } = null!;

        /// <summary>
        /// ID do Animal Virtual (Obrigatório)
        /// </summary>
        [Required(ErrorMessage = "O campo RR001_VIRTUALID é obrigatório")]
        [StringLength(36, ErrorMessage = "O campo RR001_VIRTUALID deve ter no máximo 36 caracteres")]
        public string Rr001Virtualid { get; set; } = null!;

        public OsusrTo3CsicpRr009 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr009
            {
                TenantId = tenant,
                Id = id!,
                Rr001Id = this.Rr001Id,
                Rr001Virtualid = this.Rr001Virtualid
            };
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR011
{
    /// <summary>
    /// DTO para criação e atualização de Série/RGN (RR011)
    /// </summary>
    public class DtoCreateUpdateRR011 : IConverteParaEntidade<OsusrTo3CsicpRr011>
    {
        /// <summary>
        /// Série (Obrigatório, máx 10 caracteres)
        /// </summary>
        [Required(ErrorMessage = "O campo RR011_SERIE é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo RR011_SERIE deve ter no máximo 10 caracteres")]
        public string Rr011Serie { get; set; } = null!;

        /// <summary>
        /// Último RGN (Obrigatório)
        /// </summary>
        [Required(ErrorMessage = "O campo RR011_ULTRGN é obrigatório")]
        public int Rr011Ultrgn { get; set; }

        public OsusrTo3CsicpRr011 ToEntity(int tenant, string? id)
        {
            return new OsusrTo3CsicpRr011
            {
                TenantId = tenant,
                Rr011Serie = this.Rr011Serie,
                Rr011Ultrgn = this.Rr011Ultrgn
            };
        }
    }
}
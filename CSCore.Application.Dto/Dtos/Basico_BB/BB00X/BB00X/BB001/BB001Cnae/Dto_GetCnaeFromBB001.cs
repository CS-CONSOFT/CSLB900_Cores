
using CSCore.Domain;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB001.BB001Cnae
{
    public class Dto_GetCnaeFromBB001
    {
        [Required(ErrorMessage = "TenantId é obrigatório.")]
        public int TenantId { get; set; }

        [Required(ErrorMessage = "Bb001PkId é obrigatório.")]
        public string Bb001PkId { get; set; } = "";

        public string? Bb001Id { get; set; }

        public string? Bb001CnaeId { get; set; }

        public bool? Bb001Isactive { get; set; }

        public bool? Bb001IscnaeFiscal { get; set; }

        public CSICP_AA029 NavCnae { get; set; } = null!;
    }
}

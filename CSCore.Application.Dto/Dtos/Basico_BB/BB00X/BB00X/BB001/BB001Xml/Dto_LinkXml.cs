using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB001.BB001Xml
{
    public class Dto_LinkXml
    {

        [Required(ErrorMessage = "Bb001aEstabid é obrigatório.")]
        public string Bb001aEstabid { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bb001aNome é obrigatório.")]
        public string Bb001aNome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bb001aEmail é obrigatório.")]
        public string Bb001aEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bb001aTelefone é obrigatório.")]
        public string Bb001aTelefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bb001aCpfcnpj é obrigatório.")]
        public string Bb001aCpfcnpj { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bb001aIscpf é obrigatório.")]
        public bool Bb001aIscpf { get; set; }
    }
}

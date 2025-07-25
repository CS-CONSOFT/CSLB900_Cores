using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CSBS101._82Application.Dto.BB00X.BB020
{
    public class Dto_CreateUpdateBB020
    {
        [MaxLength(36, ErrorMessage = "O campo 'Empresaid' pode ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Empresaid { get; set; }

        [MaxLength(36, ErrorMessage = "O campo 'Bb019Id' pode ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Bb019Id { get; set; }

        [MaxLength(36, ErrorMessage = "O campo 'Bb008Condicaodepagamentoid' pode ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Bb008Condicaodepagamentoid { get; set; }

        [DefaultValue(0.0)]
        [Range(0, 999.99, ErrorMessage = "O campo 'Bb020Tcobcartao' deve estar entre 0 e 999.99.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo 'Bb020Tcobcartao' deve ter até duas casas decimais.")]
        public decimal? Bb020Tcobcartao { get; set; }

        [MaxLength(36, ErrorMessage = "O campo 'Bb020Fpagtoid' pode ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Bb020Fpagtoid { get; set; }
    }
}

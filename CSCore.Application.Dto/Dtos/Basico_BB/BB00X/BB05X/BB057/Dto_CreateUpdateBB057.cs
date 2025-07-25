using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB057
{
    public class Dto_CreateUpdateBB057
    {
        [MaxLength(36, ErrorMessage = "O ID BB055 deve ter no máximo 36 caracteres.")]
        public string? Bb055Id { get; set; }

        [MaxLength(36, ErrorMessage = "O ID BB012 deve ter no máximo 36 caracteres.")]
        public string? Bb012Id { get; set; }

        public DateTime? Bb057Datahora { get; set; }

        public bool? Bb057Issmsenvprof { get; set; }

        public bool? Bb057Issmsenvcliente { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "A data e hora do SMS do profissional são inválidas.")]
        public DateTime? Bb057Dtsmsprof { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "A data e hora do SMS do cliente são inválidas.")]
        public DateTime? Bb057Dtsmscliente { get; set; }
    }
}

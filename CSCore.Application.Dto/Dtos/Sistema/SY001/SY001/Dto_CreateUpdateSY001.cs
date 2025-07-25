using System.ComponentModel.DataAnnotations;

namespace CSSY103.C82Application.Dto.SY001.SY001
{
    public class Dto_CreateUpdateSY001
    {
        [Required(ErrorMessage = "o usuário precisa ser informado")]
        public string Sy001Usuario { get; set; } = null!;

        public string? Sy001Nome { get; set; }

        //public string? Sy001Senha { get; set; }

        public bool? Sy001Bloqueado { get; set; }

        public string? Sy001DataValidade { get; set; }

        public int? Sy001Autalterarsenha { get; set; }

        public int? Sy001Altsenhapxlogin { get; set; }

        public int? Sy001ExpiraSenha { get; set; }

        public decimal? Sy001Senhexpaposndias { get; set; }

        public string? Sy001Dtexpiracaologin { get; set; }

        public string? Sy001Deptolotado { get; set; }

        public string? Sy001Cargo { get; set; }

        public string? Sy001Email { get; set; }

        public string? Sy001Imagem { get; set; }

        public string? Sy001Dataultimoacesso { get; set; }

        public int? Userid { get; set; }

        public int? Sy001IdiomaId { get; set; }

        [Required(ErrorMessage = "A senha precisa ser informada")]
        public string Sy001Senhacs { get; set; } = null!;

        public string? Sy001Celular { get; set; }

        //public Csicp_Sy809Idioma? Sy001Idioma { get; set; }
    }
}

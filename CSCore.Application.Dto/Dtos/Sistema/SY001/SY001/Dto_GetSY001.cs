using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSSY103.C82Application.Dto.SY001.SY013;

namespace CSCore.Application.Dto.Dtos.Sistema.SY001.SY001
{
    public class Dto_GetSy001
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Sy001Usuario { get; set; }

        public string? Sy001Nome { get; set; }

        public string? Sy001Senha { get; set; }

        public bool? Sy001Bloqueado { get; set; }

        public DateTime? Sy001DataValidade { get; set; }

        public int? Sy001Autalterarsenha { get; set; }
        public CSICP_Statica? NavSY001_AlterarSenha { get; set; }

        public int? Sy001Altsenhapxlogin { get; set; }
        public CSICP_Statica? NavSy001Altsenhapxlogin { get; set; }

        public int? Sy001ExpiraSenha { get; set; }
        public CSICP_Statica? NavSy001ExpiraSenha { get; set; }

        public decimal? Sy001Senhexpaposndias { get; set; }

        public DateTime? Sy001Dtexpiracaologin { get; set; }

        public string? Sy001Deptolotado { get; set; }

        public string? Sy001Cargo { get; set; }

        public string? Sy001Email { get; set; }

        public string? Sy001Imagem { get; set; }

        public DateTime? Sy001Dataultimoacesso { get; set; }

        public int? Userid { get; set; }

        public int? Sy001IdiomaId { get; set; }
        public Csicp_Sy809Idioma? NavSy001IdiomaId { get; set; }

        public string? Sy001Senhacs { get; set; }

        public string? Sy001Celular { get; set; }

        public List<Csicp_Sy001Img> NavListImagens { get; set; } = new List<Csicp_Sy001Img>();
        //public ICollection<Csicp_Sy005> GruposUsuario { get; set; } = new List<Csicp_Sy005>();
        public List<Csicp_Sy005> NavListGruposUsuario { get; set; } = new List<Csicp_Sy005>();
        public List<Csicp_Sy006> NavListRegrasUsuario { get; set; } = new List<Csicp_Sy006>();
        //public List<Csicp_Sy013> NavListEstabelecimentos { get; set; } = new List<Csicp_Sy013>();
        public List<Dto_LinkGetSy013> NavListEstabelecimentos { get; set; } = new List<Dto_LinkGetSy013>();
        public List<Csicp_Sy021> NavListAcessoRapido { get; set; } = new List<Csicp_Sy021>();
    }
}

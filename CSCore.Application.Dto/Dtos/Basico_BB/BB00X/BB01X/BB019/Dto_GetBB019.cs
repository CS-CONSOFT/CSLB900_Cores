using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB019
{
    public class Dto_GetBB019
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Empresaid { get; set; }

        public int? Bb019Filial { get; set; }

        public int? Bb019Codigo { get; set; }

        public string? Bb019Administradora { get; set; }

        public decimal? Bb019TaxaDeCobranca { get; set; }

        public decimal? Bb019Venctopadrao { get; set; }

        public string? Bb019Contaid { get; set; }

        public int? Bb019Usafatoracresc { get; set; }

        public int? Bb019Finanproprio { get; set; }

        public decimal? Bb019Tac { get; set; }

        public string? Bb019Email { get; set; }

        public string? Bb019Homepage { get; set; }

        public int? Bb019TipofinancId { get; set; }

        public bool? Bb019Isactive { get; set; }

        public int? Bb019Dialimitevenctopadrao { get; set; }

        public string? Bb019Codigocredenciadora { get; set; }

        public byte[]? Bb019LogoAdm { get; set; }

        public string? Bb019Filename { get; set; }

        public string? Bb019Path { get; set; }
        public CSICP_Bb019Tipo? NavCSICP_Bb019Tipo { get; set; }
    }
    public class Dto_GetBB019_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb019Codigo { get; set; }

        public string? Bb019Administradora { get; set; }
    }

}

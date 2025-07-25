using CSSY103.C82Application.Dto.SY001.SY016;

namespace CSSY103.C82Application.Dto.SY001.SY013
{
    public class Dto_LinkGetSy013
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Sy013Usuarioid { get; set; }

        public string? Sy013Filialid { get; set; }
        public string? CodigoFilial { get; set; }
        public string? NomeFilial { get; set; }
        public Dto_LinkGetSy016? NavCodigoAcessoRapido { get; set; }
    }
}



using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB001.BB001Images
{
    public class Dto_GetImageFromBB001
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Empresaid { get; set; }

        public int? Status { get; set; }

        public string? Nome { get; set; }

        public string? Tipo { get; set; }

        public byte[]? Imagem { get; set; }

        public bool? ExibirEmformapagto { get; set; }

        public bool? Isactive { get; set; }

        public string? Filename { get; set; }

        public string? Path { get; set; }

        public CSICP_BB001Staimg? NavStatusNavigation { get; set; }
    }
}

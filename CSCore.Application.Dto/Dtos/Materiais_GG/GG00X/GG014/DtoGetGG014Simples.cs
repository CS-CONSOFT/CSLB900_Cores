using CSCore.Domain.CS_Models.CSICP_GG;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG014
{
    public class DtoGetGG014Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg014Filialid { get; set; }

        public string? Gg014Linha { get; set; }

        public bool? Gg014IsActive { get; set; }
    }
}

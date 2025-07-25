using CSCore.Domain.CS_Models.CSICP_GG;

namespace GG104Materiais.C82Application.Dto.GG00X.GG009
{
    public class DtoGetGG009Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg009Filial { get; set; }

        public string? Gg009Filiald { get; set; }

        public string? Gg009Codigopadrao { get; set; }

        public string? Gg009Descpadrao { get; set; }

        public bool? Gg009IsActive { get; set; }
    }
}

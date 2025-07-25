using CSCore.Domain.CS_Models.CSICP_GG;

namespace GG104Materiais.C82Application.Dto.GG00X.GG017
{
    public class DtoGetGG017
    {
        public int TenantId { get; set; }

        public long Gg017Id { get; set; }

        public string? Gg017Desccategoria { get; set; }

        public int? Gg017Nivel { get; set; }

        public long? Gg017CategoriapaiId { get; set; }

        public CSICP_GG017? NavGg017Categoriapai { get; set; }
    }
}

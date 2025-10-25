using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Domain.CS_Models.Staticas.GG;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG007
{
    public class DtoGetGG007
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg007Filial { get; set; }

        public string? Gg007Filialid { get; set; }

        public string? Gg007Unidade { get; set; }

        public string? Gg007Descricao { get; set; }

        public bool? Gg007IsActive { get; set; }

        public int? Gg007FormavendaId { get; set; }

        public string? Gg007Qdecimais { get; set; }

        public OsusrE9aCsicpGg007Fra? NavGg007Formavenda { get; set; }
        public Dto_GetBB001Simples? NavGg007Filial { get; set; }
    }
}

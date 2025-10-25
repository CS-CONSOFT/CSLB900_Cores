using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG010
{
    public class DtoGetGG010
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg010Filial { get; set; }

        public string? Gg010Filialid { get; set; }

        public string? Gg010CodigoTipopadrao { get; set; }

        public string? Gg010Descricaotipopadrao { get; set; }

        public bool? Gg010IsActive { get; set; }

        public Dto_GetBB001Simples? NavFilial { get; set; }

    }
}

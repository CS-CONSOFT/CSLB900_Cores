using CSCore.Domain.CS_Models.Staticas.StaticaSped;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG002
{
    public class DtoGetGG002
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg002Filial { get; set; }

        public string? Gg002Filialid { get; set; }

        public string? Gg002Desctipoproduto { get; set; }

        public int? Gg002PermiteVendas { get; set; }

        public int? Gg002PermiteCompras { get; set; }

        public bool? Gg002Isactive { get; set; }

        public int? Gg002TipoprodId { get; set; }

        public SpedInTipoItem? NavSpedTipoItem { get; set; }
    }
}

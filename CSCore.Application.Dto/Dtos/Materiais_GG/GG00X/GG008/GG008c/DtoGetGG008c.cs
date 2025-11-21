using CSCore.Domain.CS_Models.Staticas.GG;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008c
{
    public class DtoGetGG008c
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg008cFilialid { get; set; }

        public string? Gg008cProdutoid { get; set; }

        public int? Gg008cFilial { get; set; }

        public int? Gg008cCodgproduto { get; set; }

        public string? Gg008cDescricao { get; set; }

        public int? Gg008cOrdem { get; set; }

        public string? Gg008cTiporegistro { get; set; }

        public byte[]? Gg008cObjeto { get; set; }

        public string? Gg008cFiletype { get; set; }

        public string? Gg008cTexto { get; set; }

        public string? Filename { get; set; }

        public bool? Gg008cIspadrao { get; set; }

        public string? Gg008cPath { get; set; }

        public int? Gg008cSize { get; set; }

        public int? Gg008cCdnid { get; set; }

        public OsusrE9aCsicpGg008Cdn? Gg008cCdn { get; set; }

        public static DtoGetGG008c Create(
          int tenantId,
          string id,
          string gg008cFilialid,
          string gg008cProdutoid,
          string gg008cTiporegistro,
          string gg008cTexto)
        {
            return new DtoGetGG008c
            {
                TenantId = tenantId,
                Id = id,
                Gg008cFilialid = gg008cFilialid,
                Gg008cProdutoid = gg008cProdutoid,
                Gg008cTiporegistro = gg008cTiporegistro,
                Gg008cTexto = gg008cTexto
            };
        }

    }
}

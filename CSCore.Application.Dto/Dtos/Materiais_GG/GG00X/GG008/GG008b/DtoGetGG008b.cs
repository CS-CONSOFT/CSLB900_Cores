using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG006;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008b
{
    public class DtoGetGG008b
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg008bSeq { get; set; }

        public string? Gg008bRefsimilar { get; set; }

        public DateTime? Gg008bDatavigor { get; set; }

        public string? Gg008bMarcaid { get; set; }

        public DtoGetGG006Simples? NavGg006Marca { get; set; }
    }
}




using CSBS101.C82Application.Dto.BB00X.BB012.Get.BB1207;

namespace CSBS101._82Application.Dto.BB00X.BB012.Get.Membros
{
    public class Dto_GetBB1207Membro
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb012TipoRegMembroconveni { get; set; }

        public string? Bb012Id { get; set; }

        public string? Bb012Membroid { get; set; }

        public bool? Bb01207IsActive { get; set; }

        public DtoGetBB012MembroBB1207? NavBb012Membro { get; set; }
    }
}

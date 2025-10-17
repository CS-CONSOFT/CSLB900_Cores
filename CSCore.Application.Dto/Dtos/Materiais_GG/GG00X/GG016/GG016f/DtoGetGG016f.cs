using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG016.GG016f
{
    public class DtoGetGG016f
    {
        public int TenantId { get; set; }

        public long Gg016fId { get; set; }

        public long? Gg016eId { get; set; }

        public string? Gg016fGradelinhaid { get; set; }

        public string? Gg016fGradecolunaid { get; set; }
        public DtoGetGG016Simples? Nav_GG016_VariacaoProduto_C1 { get; set; }
        public DtoGetGG016Simples? Nav_GG016_VariacaoProduto_C2 { get; set; }
        public Dto_GetBB001Simples? NavDtoGetBB001 { get; set; }

    }
}

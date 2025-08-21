using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF016
{
    public class DtoGetFF016
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public string? Ff016DescricaoCarta { get; set; }
        public byte[]? Ff016Texto { get; set; }
        public int? Ff016EmailsdestId { get; set; }
        public string? Ff016Textocarta { get; set; }

        // Navegação
        public OsusrE9aCsicpFf016Email? NavFF016Email { get; set; }
    }
}
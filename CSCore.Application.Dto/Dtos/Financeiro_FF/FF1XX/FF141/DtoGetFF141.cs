
namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF141
{
    public class DtoGetFF141
    {
        public int TenantId { get; set; }

        public long Ff141Id { get; set; }

        public long? Ff140RdId { get; set; }

        public string? Ff141Descricao { get; set; }

        public decimal? Ff141Vunitario { get; set; }

        public decimal? Ff141Qtd { get; set; }

        public decimal? Ff141Total { get; set; }
    }
}

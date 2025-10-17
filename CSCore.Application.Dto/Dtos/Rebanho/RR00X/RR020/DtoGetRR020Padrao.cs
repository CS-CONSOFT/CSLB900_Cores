namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR020
{
    public class DtoGetRR020Padrao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr020Identificador { get; set; }

        public string? Rr020Descricao { get; set; }

        public DateTime? Rr020Dtinicio { get; set; }

        public DateTime? Rr020Dtfinal { get; set; }

        public long? Rr020Regalimentarid { get; set; }
    }
}
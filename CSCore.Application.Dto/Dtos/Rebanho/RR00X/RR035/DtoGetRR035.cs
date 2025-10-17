using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR004;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR035
{
    public class DtoGetRR035
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr035Descricao { get; set; }

        public string? Rr035Nrosemem { get; set; }

        public string? Rr035Lote { get; set; }

        public string? Rr035Nomefornecedor { get; set; }

        public string? Rr035Identtouro { get; set; }

        public long? Rr035Racaid { get; set; }

        public string? Rr035Nroregtouro { get; set; }

        public DateTime? Rr035Dtcongelamento { get; set; }

        public string? Rr035Volume { get; set; }

        public string? Rr035Concespermatica { get; set; }

        public string? Rr035Observacao { get; set; }

        // Navegação
        public DtoGetRR004? NavRR004Raca { get; set; }
    }
}
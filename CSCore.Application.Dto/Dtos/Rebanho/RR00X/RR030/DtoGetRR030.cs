namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR030
{
    public class DtoGetRR030
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr030Descricao { get; set; }

        public DateTime? Rr030IaData { get; set; }

        public int? Rr030IaNrodias { get; set; }

        public DateTime? Rr030IaDatadg { get; set; }

        public DateTime? Rr030Datamontainicial { get; set; }

        public int? Rr030Montainicialdias { get; set; }

        public DateTime? Rr030Datamontafinal { get; set; }

        public int? Rr030Montafinaldias { get; set; }

        public DateTime? Rr030Dataprovontainicial { get; set; }

        public DateTime? Rr030Dataprovontafinal { get; set; }
    }
}
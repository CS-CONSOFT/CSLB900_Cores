namespace CSCore.Domain.Interfaces.Dashboard
{
    public class RepoDtoResponseCountMateriaisDashboard
    {
        public IEnumerable<RepoDtoResponseLabelCount> contadorPizzaAlmox { get; set; } = [];
        public RepoDtoResponseCount contadorAlmoxarifado { get; set; }
        public RepoDtoResponseCount contadorGrupo { get; set; }
        public RepoDtoResponseCount contadorClasse { get; set; }
        public RepoDtoResponseCount contadorArtigo { get; set; }
        public RepoDtoResponseCount contadorMarca { get; set; }
        public RepoDtoResponseCount contadorUnidade { get; set; }
        public RepoDtoResponseCount contadorPadrao { get; set; }
        public RepoDtoResponseCount contadorTipoPadrao { get; set; }
        public RepoDtoResponseCount contadorQualidadeProduto { get; set; }
        public RepoDtoResponseCount contadorLinha { get; set; }
        public RepoDtoResponseCount contadorSubGrupo { get; set; }
        public RepoDtoResponseCount contadorCategoria { get; set; }
        public RepoDtoResponseCount contadorNCM { get; set; }
        public RepoDtoResponseCount contadorAnp { get; set; }
        public RepoDtoResponseCount contadorQuantidadeProdutos { get; set; }
        public RepoDtoResponseCount contadorQuantidadeTotalNS { get; set; }
        public RepoDtoResponseCount contadorEstabelecimento { get; set; }
        public IEnumerable<RepoDtoResponseLabelCount> contadorPizzaKardexProduto { get; set; } = [];
        public IEnumerable<RepoDtoResponseLabelCount> contadorQuantidadeNSPorAlmox { get; set; } = [];

    }

    public class RepoDtoResponseLabelCount
    {
        public string? Texto { get; set; }
        public int Contagem { get; set; }
    }

    public class RepoDtoResponseCount
    {
        public string Entidade { get; set; } = string.Empty;
        public int TotalRegistro { get; set; }
        public int NumeroAtivos { get; set; }
        public int NumeroInativos { get; set; }
    }



    public interface ICountDashboardMateriaisRepository
    {
        Task<RepoDtoResponseCountMateriaisDashboard> GetTotalizadoresAsync(int tenantId);
    }
}

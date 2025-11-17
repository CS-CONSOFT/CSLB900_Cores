using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro
{
        public interface ITitulosAgrupadosAnoeMesRepository
        {
        Task<(List<DtoTitulosAgrupadosAnoMes>, int)> GetTitulosAgrupadosAnoMesAsync(DtoTitulosAgrupadosAnoMesRequest request);
        }
        public class DtoTitulosAgrupadosAnoMes
        {
            public int Ano { get; set; }
            public int Mes { get; set; }
            public string AnoMes { get; set; } = string.Empty;
            public string? IdEstabelecimento { get; set; }
            public string? NomeEmpresa { get; set; }
            public int? CodigoEmpresa { get; set; }

            // Contas a Receber (tipo 1 e 2)
            public int QuantidadeContasReceber { get; set; }
            public decimal ValorContasReceber { get; set; }

            // Contas a Pagar (tipo 3)
            public int QuantidadeContasPagar { get; set; }
            public decimal ValorContasPagar { get; set; }

            // Totais
            public int QuantidadeTotal { get; set; }
            public decimal ValorTotal { get; set; }
        }

        public class DtoTitulosAgrupadosAnoMesRequest : ParametrosBaseFiltroSemExcederOMaxPageSize
        {
            public int TenantId { get; set; }
            public DateTime? DataVencimentoInicio { get; set; }
            public DateTime? DataVencimentoFim { get; set; }
            public List<int>? TiposRegistro { get; set; } // 1, 2, 3
            public List<string>? FiltroEstabelecimentos { get; set; }
        }
}

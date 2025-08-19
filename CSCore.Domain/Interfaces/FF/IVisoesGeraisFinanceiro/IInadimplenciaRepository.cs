using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro
{
    public interface IInadimplenciaRepository
    {
        Task<List<DtoInadimplenciaResponse>> GetInadimplenciaAsync(DtoInadimplenciaRequest request);
    }

    public class DtoInadimplenciaRequest
    {
        public int TenantId { get; set; }
        public List<string>? FiltroEstabelecimentos { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }

    public class DtoInadimplenciaResponse
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string AnoMes { get; set; } = string.Empty;
        public int QuantidadeTitulosTotal { get; set; }
        public decimal ValorTitulosTotal { get; set; }
        public int QuantidadeTitulosLiquidados { get; set; }
        public decimal ValorTitulosLiquidados { get; set; }
        public int QuantidadeTitulosInadimplentes { get; set; }
        public decimal ValorTitulosInadimplentes { get; set; }
        public decimal PercentualInadimplencia { get; set; }
    }
}

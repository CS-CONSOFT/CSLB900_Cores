using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro
{
    public interface IFluxoDeCaixaRepository
    {
        Task<List<FluxoDeCaixaDiarioDto>> GetFluxoDeCaixaDiarioAsync(
           int in_tenant,
           DateTime? in_dataVencimentoInicio = null,
           DateTime? in_dataVencimentoFim = null,
           decimal in_saldoAnterior = 0);

        Task<List<FluxoDeCaixaMensalDto>> GetFluxoDeCaixaMensalAsync(
            int in_tenant,
            DateTime? in_dataVencimentoInicio = null,
            DateTime? in_dataVencimentoFim = null,
            decimal in_saldoAnterior = 0);
    }

    public class FluxoDeCaixaDiarioDto
    {
        public DateTime Data { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal ValorTitulo { get; set; }
        public decimal TotalDia { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoAcumulado { get; set; }
        public string IdentificadorTitulo { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
    }

    public class FluxoDeCaixaMensalDto
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public decimal TotalMes { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoAcumulado { get; set; }
        public decimal AReceber { get; set; }
        public decimal APagar { get; set; }
        public decimal ReceitaProvisao { get; set; }
        public decimal ProvisaoAPagar { get; set; }
    }
}

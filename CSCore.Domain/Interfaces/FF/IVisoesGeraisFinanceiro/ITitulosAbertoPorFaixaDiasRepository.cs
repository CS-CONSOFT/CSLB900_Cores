using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro
{
    public interface ITitulosAbertoPorFaixaDiasRepository
    {
        Task<List<DtoAnaliseIdadeContasReceber>> GetAnaliseIdadeContasReceberAsync(
            int in_tenant,
            bool in_agruparPorEstabelecimento = false,
            List<string>? in_filtroEstabelecimentos = null);

        Task<List<DtoTotalizadorEstabelecimento>> GetTotalizadorPorEstabelecimentoAsync(
            int in_tenant,
            List<string>? in_filtroEstabelecimentos = null);
    }

    public class DtoAnaliseIdadeContasReceber
    {
        public string FaixaIdade { get; set; } = string.Empty;
        public int QuantidadeTitulos { get; set; }
        public decimal TotalEmAberto { get; set; }
        public string? NomeEmpresa { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string? IdEstabelecimento { get; set; }
    }

    public class DtoTotalizadorEstabelecimento
    {
        public string? IdEstabelecimento { get; set; }
        public string? NomeEmpresa { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int QuantidadeTitulos { get; set; }
        public decimal TotalValor { get; set; }
        public List<DtoAnaliseIdadeContasReceber> FaixasIdade { get; set; } = new List<DtoAnaliseIdadeContasReceber>();
    }
}

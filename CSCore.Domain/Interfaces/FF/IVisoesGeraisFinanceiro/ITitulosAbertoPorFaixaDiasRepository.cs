using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro
{
    public interface ITitulosAbertoPorFaixaDiasRepository
    {
        Task<List<AnaliseIdadeContasReceberDto>> GetAnaliseIdadeContasReceberAsync(
            int tenant,
            bool agruparPorEstabelecimento = false,
            List<string>? filtroEstabelecimentos = null);

        Task<List<TotalizadorEstabelecimentoDto>> GetTotalizadorPorEstabelecimentoAsync(
            int tenant,
            List<string>? filtroEstabelecimentos = null);
    }

    public class AnaliseIdadeContasReceberDto
    {
        public string FaixaIdade { get; set; } = string.Empty;
        public int QuantidadeTitulos { get; set; }
        public decimal TotalEmAberto { get; set; }
        public string? NomeEmpresa { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string? IdEstabelecimento { get; set; }
    }

    public class TotalizadorEstabelecimentoDto
    {
        public string? IdEstabelecimento { get; set; }
        public string? NomeEmpresa { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int QuantidadeTitulos { get; set; }
        public decimal TotalValor { get; set; }
        public List<AnaliseIdadeContasReceberDto> FaixasIdade { get; set; } = new List<AnaliseIdadeContasReceberDto>();
    }
    
}

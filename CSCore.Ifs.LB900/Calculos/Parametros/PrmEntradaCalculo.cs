using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.Calculos.Parametros
{
    public class PrmEntradaCalculo
    {
        public int InTenantID { get; set; }
        public DateTime InDataVencimento { get; set; }
        public int? InDiasLiberacao { get; set; }
        public decimal InValorTitulo { get; set; }
        public decimal? InPercentualCorrecaoMonetaria { get; set; }
        public decimal? InPercentualMulta{ get; set; }
        public decimal? InPercentualJuros { get; set; }
        public decimal? InPercentualHonorarios { get; set; }
        public string InEstabID { get; set; } = string.Empty;
        public bool InFinacEspJurosMulta { get; set; } = false;
    }
}

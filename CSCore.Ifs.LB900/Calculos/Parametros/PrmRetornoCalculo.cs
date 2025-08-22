using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.Calculos.Parametros
{
    public class PrmRetornoCalculo
    {
        public decimal OutValorJuros { get; set; }
        public decimal? OutPercentualJurosTitulo { get; set; }
        public decimal? OutPercentualJurosConfig { get; set; }
        public int OutDiasAtrasoJuros { get; set; }


        public decimal OutValorMulta { get; set; }
        public int OutDiasAtrasoMulta { get; set; }

        public decimal? OutPercentualMultaTitulo { get; set; }
        public decimal? OutPercentualMultaConfig { get; set; }

        public decimal OutValorCorrecaoMonetaria { get; set; }
        public int OutDiasAtrasoCorrecaoMonetaria { get; set; }
        public decimal? OutPercentualCorrecaoMonetariaTitulo { get; set; }
        public decimal? OutPercentualCorrecaoMonetariaConfig { get; set; }

        public decimal OutValorHonorario { get; set; }
        public int OutDiasAtrasoHonorario { get; set; }
        public decimal? OutPercentualHonorarioTitulo { get; set; }
        public decimal? OutPercentualHonorarioConfig { get; set; }
    }
}

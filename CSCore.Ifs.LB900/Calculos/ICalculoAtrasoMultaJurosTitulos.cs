using CSCore.Ifs.LB900.Calculos.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.Calculos
{
    public interface ICalculoAtrasoMultaJurosTitulos
    {
        Task<PrmRetornoCalculo> CalcularContasAReceber(PrmEntradaCalculo InEntradaCalculo);
        PrmRetornoCalculo CalcularContasAPagar(PrmEntradaCalculo InEntradaCalculo);
    }
}

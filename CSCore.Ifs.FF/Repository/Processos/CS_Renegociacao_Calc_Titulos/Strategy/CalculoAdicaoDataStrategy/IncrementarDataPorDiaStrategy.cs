using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.CalculoAdicaoDataStrategy
{
    public class IncrementarDataPorDiaStrategy : IIncrementarDataStrategy
    {
        public DateTime IncrementarData(DateTime Data, int intervaloParaAdicao)
        {
            return Data.AddDays(intervaloParaAdicao);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.CalculoAdicaoDataStrategy
{
    public class IncrementarDataTipoParcelaMesStrategy : IIncrementarDataStrategy
    {
        public DateTime IncrementarData(DateTime Data, int intervaloParaAdicao)
        {
            return Data.AddMonths(intervaloParaAdicao);
        }
    }
}

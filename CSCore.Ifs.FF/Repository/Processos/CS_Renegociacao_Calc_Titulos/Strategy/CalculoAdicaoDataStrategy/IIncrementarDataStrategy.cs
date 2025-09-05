using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.CalculoAdicaoDataStrategy
{
    public interface IIncrementarDataStrategy
    {
        DateTime IncrementarData(DateTime Data, int intervaloParaAdicao);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento
{
    public class TipoDiasCondicaoPgtoStrategy : IAvaliarCondicaoPgtoStrategy
    {
       public int AvaliarCondicaoPagamento(string[]? aux_condicaoPagtoDividida)
        {
            int tamanhoArrayCondicao = aux_condicaoPagtoDividida?.Length ?? 0;
            return tamanhoArrayCondicao;
        }
    }
}

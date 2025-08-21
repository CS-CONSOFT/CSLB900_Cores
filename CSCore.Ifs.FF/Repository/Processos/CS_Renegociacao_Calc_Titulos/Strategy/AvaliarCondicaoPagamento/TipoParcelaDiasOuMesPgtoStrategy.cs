using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento
{
    public class TipoParcelaDiasOuMesPgtoStrategy : IAvaliarCondicaoPgtoStrategy
    {
        public (int aux_entrada, int aux_qtdParcelas) AvaliarCondicaoPagamento(string[]? aux_condicaoPagtoDividida)
        {
            int aux_qtdParcelas = 0;
            int aux_entrada = 0;
            aux_qtdParcelas = int.Parse(aux_condicaoPagtoDividida?[0] ?? "0");
            aux_entrada = int.Parse(aux_condicaoPagtoDividida?[1] ?? "0");
            return (aux_entrada, aux_qtdParcelas);
        }
    }
}

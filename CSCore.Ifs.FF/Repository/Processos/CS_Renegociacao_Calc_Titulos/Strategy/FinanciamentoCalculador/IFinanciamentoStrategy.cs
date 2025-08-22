using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador
{
    public interface IFinanciamentoStrategy
    {
        (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) Calcular(decimal faturaTotal, int qtdParcelas, int valorEntrada);
    }
}

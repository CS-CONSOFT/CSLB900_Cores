using CSCore.Domain.Interfaces.Calculos.CalculoAtrasoMultaJurosTitulos.Parametros;

namespace CSCore.Domain.Interfaces.Calculos.CalculoAtrasoMultaJurosTitulos
{
    public interface ICalculoAtrasoMultaJurosTitulos
    {
        /// <summary>
        /// Utilizar esse método quando for calcular títulos de contas a receber, pois ele busca os parâmetros padrão na tabela FF000
        /// </summary>
        /// <param name="InEntradaCalculo"></param>
        /// <returns></returns>
        Task<PrmRetornoCalculo> CalcularContasAReceber(PrmEntradaCalculo InEntradaCalculo);


        /// <summary>
        /// Utilizar esse método quando for calcular títulos de contas a pagar, pois ele usa os parametros enviados
        /// </summary>
        /// <param name="InEntradaCalculo">ESSE PARAMETRO FAZ TAL COISA</param>
        /// <returns></returns>
        /// <exception cref="AbandonedMutexException">FAZ TAL COISA</exception>
        PrmRetornoCalculo CalcularContasAPagar(PrmEntradaCalculo InEntradaCalculo);
    }
}

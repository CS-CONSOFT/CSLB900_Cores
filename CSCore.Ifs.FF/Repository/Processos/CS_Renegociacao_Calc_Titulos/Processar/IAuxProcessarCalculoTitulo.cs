using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public interface IAuxProcessarCalculoTitulo
    {
        Task Processar(
            /// <summary>
            /// Identificador do processo em que esse método será usado
            /// Ex. Ao processar ProcessarParcelasTipoParcelaDiasOuMes no processo de 
            /// Calculo da renegociação, esse ID será o ID da renegociação
            /// Já no gerar memória de cálculo FF043, será o ID da FF042
            /// Então é importante que esse ID seja passado para que a entidade que será criada
            /// tenha a referência correta
            /// </summary>
            string InControleID,
            DateOnly InData,
            int InTenantID,
            RetornoFinanciamento ina_calculoFinanciamento,
            /// <summary>
            /// Parâmetros necessários para o cálculo das parcelas quando se tem entrada, usado em CS_Renegociacao_Calc_Titulos
            /// </summary>
            decimal? InValorEntrada = 0);
    }
}

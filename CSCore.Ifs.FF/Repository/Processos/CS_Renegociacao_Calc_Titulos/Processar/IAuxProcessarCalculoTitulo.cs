using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public interface IAuxProcessarCalculoTitulo
    {
        Task Processar(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, RetornoFinanciamento in_calculoFinanciamento);
    }
}

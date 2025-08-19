using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public interface IProcessarCalculoTitulo
    {
        Task Processar(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos,
            (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) in_calculoFinanciamento);
    }
}

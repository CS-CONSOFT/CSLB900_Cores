using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Interface
{
    public interface IRenegociacao_Calc_Titulos
    {
        Task<bool> Executar(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos);
    }
}

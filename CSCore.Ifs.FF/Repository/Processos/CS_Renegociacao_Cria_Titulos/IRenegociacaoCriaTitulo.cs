using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos
{
    public interface IRenegociacaoCriaTitulo
    {
        Task<bool> Executar(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo);
    }
}

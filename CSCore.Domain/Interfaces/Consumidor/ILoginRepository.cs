namespace CSCore.Domain.Interfaces.Consumidor
{
    public interface ILoginRepository
    {
        Task<CSICP_BB012> GetContaParaLogin(string Prm_Codigo_Conta, string Prm_Chave_Acesso, int tenant);
        Task<CSICP_BB012?> GetContaParaAtualizarDeletar(string BB012_ID, int tenant);

    }
}

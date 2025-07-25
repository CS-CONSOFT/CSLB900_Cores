namespace CSCore.Domain.Interfaces.Consumidor
{
    public interface IContaRepository
    {
        Task<CSICP_BB012> GetConta(string IDconta, int tenant);
        Task<CSICP_BB012> CriarConta(CSICP_BB012 entity, CSICP_BB01201 bb1201, CSICP_BB01202 bb1202, CSICP_BB01206 bb1206);
        Task<CSICP_BB012> AtualizarConta(CSICP_BB012 entity, CSICP_BB01201 bb1201, CSICP_BB01202 bb1202, CSICP_BB01206 bb1206);
        Task<CSICP_BB012> DeletarConta(CSICP_BB012 entity);
    }
}

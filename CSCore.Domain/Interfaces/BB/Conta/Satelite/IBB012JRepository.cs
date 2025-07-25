namespace CSCore.Domain.Interfaces.BB.Conta.Satelite
{
    public interface IBB012jRepository : ISateliteCD<CSICP_BB012j>
    {
        Task<CSICP_BB012j> UpdateAsync(CSICP_BB012j entity);
    }
}

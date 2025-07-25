namespace CSCore.Domain.Interfaces.BB.Conta.Satelite
{
    public interface IBB012CRepository : ISateliteCD<CSICP_BB012c>
    {
        Task<CSICP_BB012c> UpdateAsync(CSICP_BB012c entity);
    }
}

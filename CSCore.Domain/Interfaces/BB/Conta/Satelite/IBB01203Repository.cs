namespace CSCore.Domain.Interfaces.BB.Conta.Satelite
{
    public interface IBB01203Repository : ISateliteCD<CSICP_BB01203>
    {
        Task<CSICP_BB01203> UpdateAsync(CSICP_BB01203 entity);
    }
}

namespace CSCore.Domain.Interfaces.BB.Conta.Satelite
{
    public interface IBB012qRepository : ISateliteCD<CSICP_BB012q>
    {
        Task<CSICP_BB012q> UpdateAsync(CSICP_BB012q entity);
    }
}

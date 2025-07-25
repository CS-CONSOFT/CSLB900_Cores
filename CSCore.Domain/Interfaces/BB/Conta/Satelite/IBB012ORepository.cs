namespace CSCore.Domain.Interfaces.BB.Conta.Satelite
{
    public interface IBB012oRepository : ISateliteCD<CSICP_BB012o>
    {
        Task<CSICP_BB012o> UpdateAsync(CSICP_BB012o entity);
    }
}

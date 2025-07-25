namespace CSCore.Domain.Interfaces.BB.Conta.Satelite
{
    public interface IBB01208Repository : ISateliteCD<CSICP_BB01208>
    {
        Task<CSICP_BB01208> UpdateAsync(CSICP_BB01208 entity);
    }
}

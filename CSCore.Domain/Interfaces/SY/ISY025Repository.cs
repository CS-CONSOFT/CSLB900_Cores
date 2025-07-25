using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY
{
    public interface ISY025Repository
    {
        public Task<Csicp_Sy025?> GetSY025ByUserId(string userId);
        public Task<Csicp_Sy025> UpdateAsync(Csicp_Sy025 csicp_Sy025);
        public Task<Csicp_Sy025> CreateAsync(Csicp_Sy025 csicp_Sy025);
    }
}

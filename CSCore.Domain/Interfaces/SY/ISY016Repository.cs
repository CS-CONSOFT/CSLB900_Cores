using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY;

public interface ISY016Repository : IBaseCD<Csicp_Sy016>
{
    Task<Csicp_Sy016> GetByIdAsync(string id, int tenant);
}


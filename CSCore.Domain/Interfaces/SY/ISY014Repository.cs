using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY;

public interface ISY014Repository : IBaseCD<Csicp_Sy014>
{
    Task<Csicp_Sy014> GetByIdAsync(string id, int tenant);
}


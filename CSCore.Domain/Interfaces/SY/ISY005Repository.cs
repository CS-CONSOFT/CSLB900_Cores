using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY;

public interface ISY005Repository : IBaseCD<Csicp_Sy005>
{
    Task<Csicp_Sy005> GetByIdAsync(string id, int tenant);
}


using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY;

public interface ISY015Repository : IBaseCD<Csicp_Sy015>
{
    Task<Csicp_Sy015> GetByIdAsync(string id, int tenant);
}


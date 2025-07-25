using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY;

public interface ISY021Repository : IBaseCD<Csicp_Sy021>
{
    Task<Csicp_Sy021> GetByIdAsync(long id, int tenant);
}


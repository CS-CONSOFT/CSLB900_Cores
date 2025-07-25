using CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;

namespace CSCore.Domain.Interfaces.SY;

public interface ISY019Repository : IBaseCD<Csicp_Sy019>
{
    Task<Csicp_Sy019> GetByIdAsync(long id, int tenant);
}


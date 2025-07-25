namespace CSCore.Domain.Interfaces.SY;

public interface ISY009Repository : IBaseCD<Csicp_Sy009>
{
    Task<Csicp_Sy009> GetByIdAsync(string id, int tenant);
}


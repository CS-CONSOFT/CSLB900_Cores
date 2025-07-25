namespace CSCore.Domain.Interfaces.SY;

public interface ISY013Repository : IBaseCD<Csicp_Sy013>
{
    Task<Csicp_Sy013> GetByIdAsync(string id, int tenant);
}


namespace CSCore.Domain.Interfaces.SY;

public interface ISY006Repository : IBaseCD<Csicp_Sy006>
{
    Task<Csicp_Sy006> GetByIdAsync(string id, int tenant);
}


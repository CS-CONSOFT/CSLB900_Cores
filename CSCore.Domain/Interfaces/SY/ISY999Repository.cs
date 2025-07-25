namespace CSCore.Domain.Interfaces.SY;

public interface ISY999Repository 
{
    Task<Csicp_Sy999> GetByIdAsync(string id, int tenant);
}


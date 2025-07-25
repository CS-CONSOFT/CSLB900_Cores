namespace CSCore.Domain.Interfaces.SY;

public interface ISY020Repository : IBaseCD<Csicp_Sy020>
{
    Task<Csicp_Sy020> GetByIdAsync(long id, int tenant);
}


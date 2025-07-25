namespace CSCore.Domain.Interfaces.SY;

public interface ISY007Repository : IBaseCD<Csicp_Sy007>
{
    Task<Csicp_Sy007?> GetByIdAsync(string id, int tenant);
    Task<IEnumerable<Csicp_Sy007>> GetBySy002IdAsync(string sy002ID, int tenant);
}


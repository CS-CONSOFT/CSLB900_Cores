namespace CSCore.Domain.Interfaces.SY;

public interface ISY001ImgRepository : IBaseCrud<Csicp_Sy001Img>
{
    Task<Csicp_Sy001Img?> GetByIdAsync(string id, int tenant);
    Task<IEnumerable<Csicp_Sy001Img>> GetListAsync(int tenant, string? search);
}


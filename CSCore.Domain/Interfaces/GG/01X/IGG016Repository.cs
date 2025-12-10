using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG016Repository : IRepositorioBase<CSICP_GG016>
    {
        Task<(IEnumerable<CSICP_GG016>, int)> GetListAsync(int tenant, int? tipoGrade_LincolID, string? inGradeID, int pageSize, int page, string? search);
        Task<CSICP_GG016?> GetByIdAsync(string id, int tenant);
    }
}

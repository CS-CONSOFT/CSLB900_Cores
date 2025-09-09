using CSCore.Domain.CS_Models.CSICP_AA;

namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA144Repository
    {
        Task<(List<OsusrE9aCsicpAa144>, int)> GetListAsync(int in_pageSize, int in_pageNumber);
    }
}
namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB011Repository : IBaseCrud<CSICP_Bb011>
    {
        Task<CSICP_Bb011?> GetByIdAsync(string id, int tenant);
        Task<CSICP_Bb011> ChangeActive(CSICP_Bb011 entity);
        Task<IEnumerable<CSICP_Bb011>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
    }
}

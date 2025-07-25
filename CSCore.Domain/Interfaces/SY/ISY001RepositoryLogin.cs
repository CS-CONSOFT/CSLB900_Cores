namespace CSCore.Domain.Interfaces.SY
{
    public interface ISY001RepositoryLogin
    {
        Task<int> GetTenantByDominio(string dominio);
        Task<Csicp_Sy001?> GetByUsernameAsync(string username, int tenant);
        Task<Csicp_Sy001?> GetByIdAsync(string usuarioId, int tenant);
        Task<bool> CheckPasswordAsync(Csicp_Sy001 user, string password, int tenant);
        Task<List<Csicp_Sy003Regra?>> GetRolesAsync(string usuarioId, int tenant);
    }
}

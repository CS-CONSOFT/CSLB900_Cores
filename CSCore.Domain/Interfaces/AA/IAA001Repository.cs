using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.AA;

public interface IAA001Repository : IRepositorioBase<CSICP_AA001>
{
    Task<CSICP_AA001?> GetByIdAsync(string id, int tenant);
    Task<IEnumerable<CSICP_AA001>> GetListAsync(int tenant, string? search);
    Task<CSICP_AA001?> GetByIdentificacao(int tenant, string in_identificacao);
}


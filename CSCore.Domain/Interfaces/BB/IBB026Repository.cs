namespace CSCore.Domain.Interfaces.BB
{
    public enum TIPO_ESPECIE
    {
        AReceber = 0,
        APagar = 1
    }
    public interface IBB026Repository : IBaseCrud<CSICP_Bb026>
    {
        Task<CSICP_Bb026?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb026>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_Bb026> ChangeActive(CSICP_Bb026 entity);
        Task<IEnumerable<CSICP_Bb026>> GetListAsyncPorTipoEspecie(int tenant, string? search, int? searchCode, bool? isActive, TIPO_ESPECIE tIPO_ESPECIE);
    }
}


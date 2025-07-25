using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Domain.Interfaces.GG._06X
{
    public enum ENUM_GET_GG003_STATUS_FILIAL
    {
        NULO = 0,
        PREENCHIDO = 1
    }

    public interface IGG060Repository
    {
        Task<CSICP_GG060> CreateAsync(CSICP_GG060 entity);
        Task<CSICP_GG060> UpdateAsync(CSICP_GG060 entity);
        Task<int> CreateAsyncParaGrupo(IEnumerable<CSICP_BB001> listaTodosEstabelecimentos, int tenant, string grupoID);
        Task<int> CreateAsyncParaSubGrupo(IEnumerable<CSICP_BB001> listaTodosEstabelecimentos,
           int tenant, string subGrupoID);
        Task DeleteRange(IEnumerable<CSICP_GG060> listaGG060ParaDeletar);
        Task DeleteAsync(CSICP_GG060 GG060ParaDeletar);
        Task<IEnumerable<CSICP_GG060>> GetGG060List_ByGrupoIDAsync(int tenant, string GG003_ID);
        Task<CSICP_GG060> GetGG060ByIdAsync(int tenant, long GG060_ID);
        Task<IEnumerable<CSICP_GG060>> GetGG060List_ByGrupoID_Filial_Nulo_NaoNulo_GG003_Async
            (ENUM_GET_GG003_STATUS_FILIAL status_estabelecimento, int tenant, string GG003_ID);
    }
}

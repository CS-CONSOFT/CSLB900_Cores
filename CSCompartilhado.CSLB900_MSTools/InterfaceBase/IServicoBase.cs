namespace CSLB900.MSTools.InterfaceBase
{
    public interface IServicoBase<TDtoCreateUpdate, TEntity> 
        where TDtoCreateUpdate : class, IConverteParaEntidade<TEntity>
        where TEntity : class
    {
        [Obsolete("Usar o outro create que tem como parametros (int tenant, TDtoCreateUpdate dto)")]
        Task<string> Create(TDtoCreateUpdate dto, int tenant);
        Task<TEntity> Create(int tenant, TDtoCreateUpdate dto);
        Task<string> Update(TDtoCreateUpdate dto, string id, int tenant);
        Task<string> Update(TDtoCreateUpdate dto, long id, int tenant);
        Task Delete(string id, int tenant);
        Task Delete(long id, int tenant);
    }
}

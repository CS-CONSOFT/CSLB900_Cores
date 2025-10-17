namespace CSLB900.MSTools.InterfaceBase
{
    public interface IConverteParaEntidade<TEntity>
        where TEntity : class

    {
        TEntity ToEntity(int tenant, string? id);
    }
}

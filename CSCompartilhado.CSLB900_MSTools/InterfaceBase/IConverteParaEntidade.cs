namespace CSCore.Ifs.InterfaceBase
{
    public interface IConverteParaEntidade<TEntity>
        where TEntity : class

    {
        TEntity ToEntity(int tenant, string? id);
    }
}

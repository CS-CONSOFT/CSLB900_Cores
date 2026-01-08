namespace CSLB900.MSTools.InterfaceBase
{
    public interface IConverteParaEntidade<TEntity>
        where TEntity : class

    {
        TEntity ToEntity(int tenant, string? id);
    }

    public interface IConverteParaEntidadeV2<TEntity, TDto>
       where TEntity : class
        where TDto : class
    {
        static abstract TDto FromEntity(TEntity entity);
    }
}

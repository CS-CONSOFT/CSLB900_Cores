using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository
{
    /// <summary>
    /// Lembre-se de checar se os campos Id e Tenant seguem o padrão de nome "Id" e "TenantId". Caso não, precisa ser passado o nome de referência
    /// através do construtor. Ex: Se o tenant estiver escrito como Tenant_ID na classe, está fora do padrão, então a classe base repository deve saber qual
    /// é a assinatura pra aquele campo na entidade atual, logo, a assinatura "Tenant_ID" deve ser passado no construtor. O mesmo vale para o ID, se for 
    /// Ex: "BB001id" Deve ser passado o nome da assinatura correspondente.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="appDbContext"></param>
    /// <param name="IdIdentifierName">Identificador do ID na classe C#, não representa o identificador da coluna no banco. Isso é definido no contexto.</param>
    /// <param name="TenantIdentifierName">Identificador do Tenant na classe C#, não representa o identificador da coluna no banco. Isso é definido no contexto.</param>
    public class RepositorioBaseImpl<TEntity>(AppDbContext appDbContext,
        string IdIdentifierName = "Id",
        string TenantIdentifierName = "TenantId")
        : IRepositorioBase<TEntity> where TEntity : class
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public virtual TEntity Create(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            var addedEntity = _appDbContext.Set<TEntity>().Add(entity).Entity;
            return addedEntity;
        }

        public virtual async Task<TEntity?> RemoveAsync(string id, int tenant)
        {
            TEntity? entity = await GetEntityForUpdateAsync(id, tenant);
            if (entity != null)
            {
                _appDbContext.Set<TEntity>().Remove(entity);
            }
            return entity;
        }

        public virtual async Task<TEntity?> RemoveAsync(long id, int tenant)
        {
            TEntity? entity = await GetEntityForUpdateAsync(id, tenant);
            if (entity != null)
            {
                _appDbContext.Set<TEntity>().Remove(entity);
            }
            return entity;
        }

        public virtual async Task<TEntity?> UpdateAsync(string id, int tenant, TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await GetEntityForUpdateAsync(id, tenant);

            var entry = _appDbContext.Entry(existingEntity);
            var entityType = typeof(TEntity);

            foreach (var property in entityType.GetProperties())
            {
                // Ignora a chave primária
                if (property.Name == IdIdentifierName)
                    continue;

                var newValue = property.GetValue(entity);
                property.SetValue(existingEntity, newValue);
            }

            return existingEntity;
        }



        public virtual async Task<TEntity?> UpdateAsync(long id, int tenant, TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await GetEntityForUpdateAsync(id, tenant); 
            var entityType = typeof(TEntity);

            foreach (var property in entityType.GetProperties())
            {
                if (property.Name == IdIdentifierName)
                    continue; // Não atualiza a chave primária

                var newValue = property.GetValue(entity);
                property.SetValue(existingEntity, newValue);
            }
            return existingEntity;
        }

        public async Task<TEntity> GetEntityForUpdateAsync(string id, int tenantId)
        {
            var entityType = typeof(TEntity);
            var tenantProperty = entityType.GetProperty(TenantIdentifierName) ?? throw new InvalidOperationException($"O tipo {entityType.Name} não possui a propriedade {TenantIdentifierName}.");
            var existingEntity = await _appDbContext.Set<TEntity>()
             .FirstOrDefaultAsync(e => EF.Property<int>(e, TenantIdentifierName) == tenantId && EF.Property<string>(e, IdIdentifierName) == id);

            return existingEntity == null
                ? throw new KeyNotFoundException($"Entidade com {IdIdentifierName}: {id} e {TenantIdentifierName}: {tenantId} não encontrada.")
                : existingEntity;
        }

        public async Task<TEntity> GetEntityForUpdateAsync(long id, int tenantId)
        {
            var entityType = typeof(TEntity);
            var tenantProperty = entityType.GetProperty(TenantIdentifierName) ?? throw new InvalidOperationException($"O tipo {entityType.Name} não possui a propriedade {TenantIdentifierName}.");
            var existingEntity = await _appDbContext.Set<TEntity>()
             .FirstOrDefaultAsync(e => EF.Property<int>(e, TenantIdentifierName) == tenantId && EF.Property<long>(e, IdIdentifierName) == id);

            return existingEntity == null
                ? throw new KeyNotFoundException($"Entidade com {IdIdentifierName}: {id} e {TenantIdentifierName}: {tenantId} não encontrada.")
                : existingEntity;
        }

        public async Task CommitToDatabase()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public object GetEntityId(TEntity entity)
        {
            var idProperty = entity.GetType().GetProperty(IdIdentifierName);
            return idProperty?.GetValue(entity)!;
        }
    }
}

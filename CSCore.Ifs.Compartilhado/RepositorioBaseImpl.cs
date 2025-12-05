using CSCore.Domain.CS_QueryFilters;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository
{
    [Obsolete("Use a implementação genérica RepositorioBaseImpl<TEntity, TKey> em vez desta.")]
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

        public virtual async Task<int> BulkCreateAsync(List<TEntity> entities)
        {
            ArgumentNullException.ThrowIfNull(entities);
            await _appDbContext.Set<TEntity>().BulkInsertOptimizedAsync(entities);
            return entities.Count;
        }

        public virtual async Task<int> BulkCreateAsync(IEnumerable<TEntity> entities)
        {
            ArgumentNullException.ThrowIfNull(entities);
            await _appDbContext.Set<TEntity>().BulkInsertOptimizedAsync(entities);
            return entities.Count();
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

        public async Task SalvarLogAsync(
                int tenantId,
                string nomeUsuario,
                string severidade,
                string mensagem,
                string? jsonHeader = null,
                string? jsonQuery = null,
                string? jsonBody = null,
                bool isExibiu = false)
                    {
                        using var connection = _appDbContext.Database.GetDbConnection();
                        if (connection.State != System.Data.ConnectionState.Open)
                            await connection.OpenAsync();

                        using var command = connection.CreateCommand();
                        command.CommandText = @"
                    INSERT INTO OSUSR_E9A_CSICP_SY997 
                    (
                        TENANT_ID, 
                        SY997_DATAINC, 
                        SY997_NOMEUSUARIO, 
                        SY997_ISEXIBIU, 
                        SY997_SEVERIDADE, 
                        SY997_MENSAGEM, 
                        SY997_EXTERNAL_ID, 
                        JSON_HEADER, 
                        JSON_QUERY, 
                        JSON_BODY
                    )
                    VALUES 
                    (
                        @TenantId, 
                        @DataInc, 
                        @NomeUsuario, 
                        @IsExibiu, 
                        @Severidade, 
                        @Mensagem, 
                        @ExternalId, 
                        @JsonHeader, 
                        @JsonQuery, 
                        @JsonBody
                    )";

                        var tenantParam = command.CreateParameter();
                        tenantParam.ParameterName = "@TenantId";
                        tenantParam.Value = tenantId;
                        command.Parameters.Add(tenantParam);

                        var dataIncParam = command.CreateParameter();
                        dataIncParam.ParameterName = "@DataInc";
                        dataIncParam.Value = DateTime.UtcNow.ToLocalTime();
                        command.Parameters.Add(dataIncParam);

                        var nomeUsuarioParam = command.CreateParameter();
                        nomeUsuarioParam.ParameterName = "@NomeUsuario";
                        nomeUsuarioParam.Value = nomeUsuario.Length > 100 ? nomeUsuario.Substring(0, 100) : nomeUsuario;
                        command.Parameters.Add(nomeUsuarioParam);

                        var isExibiuParam = command.CreateParameter();
                        isExibiuParam.ParameterName = "@IsExibiu";
                        isExibiuParam.Value = isExibiu;
                        command.Parameters.Add(isExibiuParam);

                        var severidadeParam = command.CreateParameter();
                        severidadeParam.ParameterName = "@Severidade";
                        severidadeParam.Value = severidade.Length > 50 ? severidade.Substring(0, 50) : severidade;
                        command.Parameters.Add(severidadeParam);

                        var mensagemParam = command.CreateParameter();
                        mensagemParam.ParameterName = "@Mensagem";
                        mensagemParam.Value = mensagem ?? (object)DBNull.Value;
                        command.Parameters.Add(mensagemParam);

                        var externalIdParam = command.CreateParameter();
                        externalIdParam.ParameterName = "@ExternalId";
                        externalIdParam.Value = Guid.NewGuid().ToString();
                        command.Parameters.Add(externalIdParam);

                        var jsonHeaderParam = command.CreateParameter();
                        jsonHeaderParam.ParameterName = "@JsonHeader";
                        jsonHeaderParam.Value = jsonHeader ?? (object)DBNull.Value;
                        command.Parameters.Add(jsonHeaderParam);

                        var jsonQueryParam = command.CreateParameter();
                        jsonQueryParam.ParameterName = "@JsonQuery";
                        jsonQueryParam.Value = jsonQuery ?? (object)DBNull.Value;
                        command.Parameters.Add(jsonQueryParam);

                        var jsonBodyParam = command.CreateParameter();
                        jsonBodyParam.ParameterName = "@JsonBody";
                        jsonBodyParam.Value = jsonBody ?? (object)DBNull.Value;
                        command.Parameters.Add(jsonBodyParam);

                        await command.ExecuteNonQueryAsync();
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

        protected virtual ICSInclude<TEntity>[] GetIncludesParaAplicar()
        {
            throw new NotImplementedException("Implementação do GetInclude deve ser feita na classe filha");
        }


        protected virtual ICSFilter<TEntity>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            throw new NotImplementedException("Implementação do GetOutrosFiltros deve ser feita na classe filha");
        }

        protected virtual ICSFilter<TEntity>[] GetFiltrosParaAplicar<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtrosPersonalizados = GetOutrosFiltros(TenantId, Filtros) ?? [];

            return new ICSFilter<TEntity>[] { new FiltroBaseTenantId<TEntity>(TenantId) }
                .Concat(filtrosPersonalizados)
                .ToArray();
        }

        protected IQueryable<TEntity> AplicaIncludes(IQueryable<TEntity> query, params ICSInclude<TEntity>[] InIncludes)
        {
            foreach (var include in InIncludes)
            {
                query = include.ApplyIncludes(query);
            }
            return query;
        }

        protected IQueryable<TEntity> AplicaFiltro(IQueryable<TEntity> query, params ICSFilter<TEntity>[] InFiltros)
        {
            foreach (var filtro in InFiltros)
            {
                query = filtro.Apply(query);
            }
            return query;
        }
    }
}


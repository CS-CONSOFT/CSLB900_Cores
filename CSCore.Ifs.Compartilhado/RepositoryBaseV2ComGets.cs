using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CSCore.Ifs.Compartilhado
{
   
    public class RepositoryBaseV2ComGets<TEntity> : RepositorioBaseImplV2<TEntity>, IRepositorioBaseV2ComGets<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _appDbContext;
        private readonly string _tenantIdentifierName;
        public RepositoryBaseV2ComGets(AppDbContext appDbContext, string IdIdentifierName = "Id",
            string TenantIdentifierName = "TenantId")
            : base(appDbContext, IdIdentifierName, TenantIdentifierName)
        {
            _appDbContext = appDbContext;
            _tenantIdentifierName = TenantIdentifierName;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(IEnumerable<FiltrosDinamicos> filtros)
        {
            var query = this._appDbContext.Set<TEntity>().AsQueryable();
            var parameter = Expression.Parameter(typeof(TEntity), "e"); // representa o "e" -> e.AlgumaCoisa
            Expression? comparison = null;

            foreach (var item in filtros)
            {
                var property = Expression.Property(parameter, item.NomePropriedade);
                var propertyType = property.Type;
                var constantValue = Convert.ChangeType(item.ValorPropriedade, Nullable.GetUnderlyingType(propertyType) ?? propertyType);
                var constant = Expression.Constant(constantValue, propertyType);

                Expression currentComparison = item.TipoDeIgualdade switch
                {
                    TipoFiltroDinamico.Igual => Expression.Equal(property, constant),
                    TipoFiltroDinamico.Diferente => Expression.NotEqual(property, constant),
                    TipoFiltroDinamico.Maior => Expression.GreaterThan(property, constant),
                    TipoFiltroDinamico.Menos => Expression.LessThan(property, constant),
                    _ => throw new NotSupportedException($"Tipo de filtro {item.TipoDeIgualdade} não suportado.")
                };

                comparison = comparison == null ? currentComparison : Expression.AndAlso(comparison, currentComparison);
            }

            if (comparison != null)
            {
                var lambda = Expression.Lambda<Func<TEntity, bool>>(comparison, parameter); // representa a expressão completa e => e.NomePropriedade == valor
                query = query.Where(lambda);
            }
            
            return await query.ToListAsync();
        }

        public virtual async Task<(IEnumerable<TEntity> Data, int TotalCount)> GetAllAsyncComPaginacao(
           IEnumerable<FiltrosDinamicos> filtros,
           int pageNumber,
           int pageSize)
        {
            var query = this._appDbContext.Set<TEntity>().AsNoTracking().AsQueryable();
            query = AplicaFiltrosDinamicos(query, filtros);

            var totalCount = await query.CountAsync();

            var data = await query
                .PaginacaoNoBanco(pageNumber, pageSize)
                .ToListAsync();

            return (data, totalCount);
        }

        /// <summary>
        /// Aplica filtros dinâmicos em uma query existente.
        /// </summary>
        /// <param name="query">Query base para aplicar os filtros</param>
        /// <param name="filtros">Lista de filtros dinâmicos</param>
        /// <returns>Query com os filtros aplicados</returns>
        protected IQueryable<TEntity> AplicaFiltrosDinamicos(IQueryable<TEntity> query, IEnumerable<FiltrosDinamicos> filtros)
        {
            if (!filtros.Any())
                return query;

            var parameter = Expression.Parameter(typeof(TEntity), "e");
            Expression? comparison = null;

            foreach (var item in filtros)
            {
                var property = Expression.Property(parameter, item.NomePropriedade);
                var propertyType = property.Type;
                var constantValue = Convert.ChangeType(item.ValorPropriedade, Nullable.GetUnderlyingType(propertyType) ?? propertyType);
                var constant = Expression.Constant(constantValue, propertyType);

                Expression currentComparison = item.TipoDeIgualdade switch
                {
                    TipoFiltroDinamico.Igual => Expression.Equal(property, constant),
                    TipoFiltroDinamico.Diferente => Expression.NotEqual(property, constant),
                    TipoFiltroDinamico.Maior => Expression.GreaterThan(property, constant),
                    TipoFiltroDinamico.Menos => Expression.LessThan(property, constant),
                    _ => throw new NotSupportedException($"Tipo de filtro {item.TipoDeIgualdade} não suportado.")
                };

                comparison = comparison == null ? currentComparison : Expression.AndAlso(comparison, currentComparison);
            }

            if (comparison != null)
            {
                var lambda = Expression.Lambda<Func<TEntity, bool>>(comparison, parameter);
                query = query.Where(lambda);
            }

            return query;
        }

        public virtual async Task<TEntity?> GetByIdAsync(string id, int tenant)
        {
            return await FindByIdAndTenantAsync(longId: 0, id, tenant);
        }

        public virtual async Task<TEntity?> GetByIdAsync(long id, int tenant)
        {
            return await FindByIdAndTenantAsync(id, string.Empty, tenant);
        }

        /// <summary>
        /// Recupera assincronamente uma entidade pelo seu identificador e valor de tenant.
        /// </summary>
        /// <remarks>
        /// Este método limpa o ChangeTracker antes da consulta para garantir que a entidade seja carregada do banco de dados.
        /// A entidade só será retornada se a propriedade de tenant corresponder ao valor de tenant especificado.
        /// </remarks>
        /// <param name="longId">Identificador numérico da entidade. Se diferente de zero, este valor será utilizado como chave da entidade.</param>
        /// <param name="stringId">Identificador em formato string da entidade. Utilizado como chave caso <paramref name="longId"/> seja zero.</param>
        /// <param name="tenant">Identificador do tenant para comparar com a propriedade de tenant da entidade.</param>
        /// <returns>
        /// Uma tarefa que representa a operação assíncrona. O resultado contém a entidade se encontrada e se o tenant corresponder; caso contrário, <see langword="null"/>.
        /// </returns>
        private async Task<TEntity?> FindByIdAndTenantAsync(long longId, string stringId, int tenant)
        {
            object id = longId != 0 ? longId : stringId;
            this._appDbContext.ChangeTracker.Clear();
            var entity = await this._appDbContext.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                var tenantProperty = typeof(TEntity).GetProperty(_tenantIdentifierName);
                if (tenantProperty != null)
                {
                    var tenantValue = tenantProperty.GetValue(entity);
                    if (tenantValue != null && Convert.ToInt32(tenantValue) == tenant)
                    {
                        return entity;
                    }
                }
            }
            return null;
        }
    }
}

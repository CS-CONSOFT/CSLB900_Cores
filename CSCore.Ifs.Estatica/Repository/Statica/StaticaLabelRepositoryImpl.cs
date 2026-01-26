using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Estatica.Repository.Statica
{
    public class StaticaLabelRepositoryImpl(AppDbContext appDbContext) : IStaticaLabelRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        // Métodos genéricos
        /// <typeparam name="T">Tipo da entidade estática que possui as propriedades Label, IsActive e Id</typeparam>
        /// <param name="label">Valor do Label para busca</param>
        /// <param name="idPropertyName">Nome da propriedade que contém o ID (padrão: "Id")</param>
        /// <returns>ID da entidade encontrada ou 0 se não encontrada</returns>
        public async Task<int> GetIDStaticaByLabel<T>(string label, string idPropertyName = "Id") where T : class
        {
            var query = _appDbContext.Set<T>().AsQueryable();

            var entityType = _appDbContext.Model.FindEntityType(typeof(T));
            var isActiveProperty = entityType?.FindProperty("IsActive");

            if (isActiveProperty != null)
                query = query.Where(e => EF.Property<bool?>(e, "IsActive") == true);

            return await _appDbContext.Set<T>()
                .Where(e => EF.Property<string>(e, "Label") == label)
                .Select(e => EF.Property<int>(e, idPropertyName))
                .FirstOrDefaultAsync();
        }

        /// <typeparam name="T">Tipo da entidade estática que possui as propriedades Label, IsActive e Id</typeparam>
        /// <param name="label">Valor do Label para busca</param>
        /// <param name="idPropertyName">Nome da propriedade que contém o ID (padrão: "Id")</param>
        /// <returns>ID da entidade encontrada ou 0 se não encontrada</returns>
        public async Task<int> GetIDStaticaByLabelWithoutIsActive<T>(string label, string idPropertyName = "Id") where T : class
        {
            return await _appDbContext.Set<T>()
                .Where(e => EF.Property<string>(e, "Label") == label)
                .Select(e => EF.Property<int>(e, idPropertyName))
                .FirstOrDefaultAsync();
        }

        /// <typeparam name="T">Tipo da entidade estática que possui as propriedades Label, IsActive e Id</typeparam>
        /// <param name="label">Valor do Label para busca</param>
        /// <param name="idPropertyName">Nome da propriedade que contém o ID (padrão: "Id")</param>
        /// <returns>ID da entidade encontrada ou 0 se não encontrada</returns>
        public async Task<int> GetIDStaticaByCodCS<T>(int codCs, string idPropertyName = "Id") where T : class
        {
            return await _appDbContext.Set<T>()
                .Where(e => EF.Property<bool?>(e, "IsActive") == true)
                .Where(e => EF.Property<int?>(e, "Codgcs") == codCs)
                .Select(e => EF.Property<int>(e, idPropertyName))
                .FirstOrDefaultAsync();
        }

        public async Task<T?> GetIDStaticaById<T>(int Id, string idPropertyName = "Id") where T : class
        {
            var query = _appDbContext.Set<T>().AsQueryable();

            var entityType = _appDbContext.Model.FindEntityType(typeof(T));
            var isActiveProperty = entityType?.FindProperty("IsActive");

            if (isActiveProperty != null)
                query = query.Where(e => EF.Property<bool?>(e, "IsActive") == true);

            return await _appDbContext.Set<T>()
                .Where(e => EF.Property<int>(e, idPropertyName) == Id)
                .FirstOrDefaultAsync();
        }
    }
}
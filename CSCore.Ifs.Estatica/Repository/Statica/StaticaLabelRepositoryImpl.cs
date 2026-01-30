using CLT900DbCore.CSCore.Domain.ModelDBClinicTime;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Estatica.Repository.Statica
{
    public class StaticaLabelRepositoryImpl(AppDbContext appDbContext) : IStaticaLabelRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<int> GetIDStaticasByTypeGG071StaPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg071Sta
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeFF102_EntPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpFf102Ents
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeFF102_SitPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpFf102Sits
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }


        public async Task<int> GetIDStaticasByTypeGG073StatusPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg073Stats
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG072StqPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg072Stqs
               .Where(e => e.IsActive == true)
               .Where(e => e.Label!.Equals(label))
               .Select(e => e.Id)
               .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG028NatOpLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg028Nats
              .Where(e => e.IsActive == true)
              .Where(e => e.Label!.Equals(label))
              .Select(e => e.Id)
              .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG028EntSaidaLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg028Entsais
             .Where(e => e.IsActive == true)
             .Where(e => e.Label!.Equals(label))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeGG073TMovPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg073Tmovs
             .Where(e => e.IsActive == true)
             .Where(e => e.Label!.Equals(label))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeBB012_MRELPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpBb012Mrels
               .Where(e => e.IsActive == true)
               .Where(e => e.Label!.Equals(label))
               .Select(e => e.Id)
               .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeGG054StaPorCodCS(int codCs)
        {

            int ID = await _appDbContext.OsusrE9aCsicpGg054Sta
               .Where(e => e.IsActive == true)
               .Where(e => e.Codgcs == codCs)
               .Select(e => e.Id)
               .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeGG055StaPorCodCS(int codCs)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg055Sta
             .Where(e => e.IsActive == true)
             .Where(e => e.Codgcs == codCs)
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeGG032TpInvPorCodCS(string codCs)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg032Tpinvs
             .Where(e => e.IsActive == true)
             .Where(e => e.Codgcs!.Equals(codCs))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeGG032StaPorCodCS(string codCs)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg032Sta
             .Where(e => e.IsActive == true)
             .Where(e => e.Codgcs!.Equals(codCs))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeBB061_TPPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpBb061Tps
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeE9ACSICP_StaticaPorLabel(string label)
        {
            int ID = await _appDbContext.E9ACSICP_Statica
                 .Where(e => e.Label!.Equals(label))
                 .Select(e => e.Id)
                 .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetStaticasByTypeCC081PorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpCc081Cd
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasSimNao(string label)
        {
            int ID = await _appDbContext.E9ACSICP_Statica
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }
        

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
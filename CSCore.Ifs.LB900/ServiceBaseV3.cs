using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.LB900.ABAC;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.LB900
{
    public abstract class ServiceBaseV3<TEntity, TDtoGetList, TDtoGetById, TDtoCreate, TDtoUpdate, TUnitOfWork>
        : IServiceBaseV3<TDtoGetList, TDtoGetById, TDtoCreate, TDtoUpdate>
        where TEntity : class
        where TDtoGetList : class, IConverteParaEntidadeV2<TEntity, TDtoGetList>
        where TDtoGetById : class, IConverteParaEntidadeV2<TEntity, TDtoGetById>
        where TDtoCreate : class, IConverteParaEntidade<TEntity>
        where TDtoUpdate : class, IConverteParaEntidade<TEntity>
        where TUnitOfWork : IUnitOfWorkBase
    {
        protected readonly TUnitOfWork UnitOfWork;

        protected ServiceBaseV3(TUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        protected abstract IRepositorioBaseV2ComGets<TEntity> GetRepository();
        protected abstract ICS_GenerateId GetIdGenerator();

        public async Task<int> BulkCreateAsync(List<TDtoCreate> dtoList)
        {
            throw new NotImplementedException("Método precisa ser implementado no SERVICE BASE V3! Ainda nao tem");
        }

        public async Task<int> BulkCreateAsync(IEnumerable<TDtoCreate> dtoList)
        {
            throw new NotImplementedException("Método precisa ser implementado no SERVICE BASE V3! Ainda nao tem");
        }

        public async Task Create(TDtoCreate dto, int tenant)
        {
            var newID = GetIdGenerator().GenerateUuId();
            var entidade = dto.ToEntity(tenant, newID);
            GetRepository().Create(entidade);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task CreateRange(List<TDtoCreate> dtoList)
        {
            throw new NotImplementedException("Método precisa ser implementado no SERVICE BASE V3! Ainda nao tem");
        }

        public async Task<IEnumerable<TDtoGetList>> GetAllAsync(IEnumerable<FiltrosDinamicos> filtros)
        {
            var lista = await GetRepository().GetAllAsync(filtros);
            return lista.Select(TDtoGetList.FromEntity);
        }

        public async Task<TDtoGetById?> GetByIdAsync(string id, int tenant)
        {
            var entity = await GetRepository().GetByIdAsync(id, tenant);
            if (entity == null)
                return null;
            return TDtoGetById.FromEntity(entity);
        }

        public async Task<TDtoGetById?> GetByIdAsync(long id, int tenant)
        {
            var entity = await GetRepository().GetByIdAsync(id, tenant);
            if (entity == null)
                return null;
            return TDtoGetById.FromEntity(entity);
        }

        public async Task RemoveAsync(string id, int tenant)
        {
            await GetRepository().RemoveAsync(id, tenant);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(long id, int tenant)
        {
            await GetRepository().RemoveAsync(id, tenant);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task<TDtoUpdate?> UpdateAsync(string id, int tenant, TDtoUpdate dto)
        {
            await GetRepository().UpdateAsync(id, tenant, dto.ToEntity(tenant, id));
            await UnitOfWork.SaveChangesAsync();
            return dto;
        }

        public async Task<TDtoUpdate?> UpdateAsync(long id, int tenant, TDtoUpdate dto)
        {
            await GetRepository().UpdateAsync(id, tenant, dto.ToEntity(tenant, id.ToString()));
            await UnitOfWork.SaveChangesAsync();
            return dto;
        }
    }
}
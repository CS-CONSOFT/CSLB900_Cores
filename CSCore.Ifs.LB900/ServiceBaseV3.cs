using CSCore.Domain.Interfaces.V2;
using CSCore.Ex;
using CSCore.Ifs.LB900.ABAC;
using CSLB900.MSTools;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.LB900
{
    public abstract class ServiceBaseV3<TEntity, TDtoGetList, TDtoGetById, TDtoCreate, TDtoUpdate, TUnitOfWork>
        : IServiceBaseV3<TDtoGetList, TDtoGetById, TDtoCreate, TDtoUpdate>
        where TEntity : class
        where TDtoGetList : class, IConverteParaDTO<TEntity, TDtoGetList>
        where TDtoGetById : class, IConverteParaDTO<TEntity, TDtoGetById>
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
        
        protected virtual ICS_GenerateId GetIdGenerator()
        {
            return new SCS_GenerateId();
        }

        public virtual async Task<int> BulkCreateAsync(List<TDtoCreate> dtoList)
        {
            throw new NotImplementedException("Método precisa ser implementado no SERVICE BASE V3! Ainda nao tem");
        }

        public virtual async Task<int> BulkCreateAsync(IEnumerable<TDtoCreate> dtoList)
        {
            throw new NotImplementedException("Método precisa ser implementado no SERVICE BASE V3! Ainda nao tem");
        }

        public virtual async Task Create(TDtoCreate dto, int tenant)
        {
            var newID = GetIdGenerator().GenerateUuId();
            var entidade = dto.ToEntity(tenant, newID);
            GetRepository().Create(entidade);
            await UnitOfWork.SaveChangesAsync();
        }

        public virtual async Task CreateRange(List<TDtoCreate> dtoList)
        {
            throw new NotImplementedException("Método precisa ser implementado no SERVICE BASE V3! Ainda nao tem");
        }

        public virtual async Task<IEnumerable<TDtoGetList>> GetAllAsync(IEnumerable<FiltrosDinamicos> filtros)
        {
            var lista = await GetRepository().GetAllAsync(filtros);
            return lista.Select(TDtoGetList.FromEntity);
        }

        public virtual async Task<PaginationModel<TDtoGetList>> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize)
        {
            var (data, totalCount) = await GetRepository().GetAllAsyncComPaginacao(filtros, pageNumber, pageSize);

            var lista = data.Select(TDtoGetList.FromEntity).ToList();

            var totalPaginas = (int)Math.Ceiling(totalCount / (double)pageSize);

            var result = new PaginationModel<TDtoGetList>
            {
                CurrentPage = pageNumber,
                TotalPage = totalPaginas,
                PageSize = pageSize,
                TotalCount = totalCount,
                HasPrevius = pageNumber > 1,
                HasNext = pageNumber < totalPaginas,
                List = lista
            };

            return result;
        }

        public virtual async Task<TDtoGetById?> GetByIdAsync(string id, int tenant)
        {
            var entity = await GetRepository().GetByIdAsync(id, tenant);
            if (entity == null)
                return null;
            return TDtoGetById.FromEntity(entity);
        }

        public virtual async Task<TDtoGetById?> GetByIdAsync(long id, int tenant)
        {
            var entity = await GetRepository().GetByIdAsync(id, tenant);
            if (entity == null)
                return null;
            return TDtoGetById.FromEntity(entity);
        }

        public virtual async Task RemoveAsync(string id, int tenant)
        {
            await GetRepository().RemoveAsync(id, tenant);
            await UnitOfWork.SaveChangesAsync();
        }

        public virtual async Task RemoveAsync(long id, int tenant)
        {
            await GetRepository().RemoveAsync(id, tenant);
            await UnitOfWork.SaveChangesAsync();
        }

        public virtual async Task<TDtoUpdate?> UpdateAsync(string id, int tenant, TDtoUpdate dto)
        {
            await GetRepository().UpdateAsync(id, tenant, dto.ToEntity(tenant, id));
            await UnitOfWork.SaveChangesAsync();
            return dto;
        }

        public virtual async Task<TDtoUpdate?> UpdateAsync(long id, int tenant, TDtoUpdate dto)
        {
            await GetRepository().UpdateAsync(id, tenant, dto.ToEntity(tenant, id.ToString()));
            await UnitOfWork.SaveChangesAsync();
            return dto;
        }
    }
}
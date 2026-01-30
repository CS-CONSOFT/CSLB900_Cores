using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;
using MathNet.Numerics.Statistics.Mcmc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900
{
    public interface IServiceBaseV3<TDtoGetList, TDtoGetById, TDtoCreate, TDtoUpdate>
    {
        Task<TDtoGetById?> GetByIdAsync(string id, int tenant);
        Task<TDtoGetById?> GetByIdAsync(long id, int tenant);
        Task<IEnumerable<TDtoGetList>> GetAllAsync(IEnumerable<FiltrosDinamicos> filtros);
        Task<string> Create(TDtoCreate dto, int tenant);
        Task CreateRange(List<TDtoCreate> dto);
        Task<int> BulkCreateAsync(List<TDtoCreate> dtoList);
        Task<int> BulkCreateAsync(IEnumerable<TDtoCreate> dtoList);
        Task<TDtoUpdate?> UpdateAsync(string id, int tenant, TDtoUpdate dto);
        Task<TDtoUpdate?> UpdateAsync(long id, int tenant, TDtoUpdate dto);
        Task RemoveAsync(string id, int tenant);
        Task RemoveAsync(long id, int tenant);
    }
}

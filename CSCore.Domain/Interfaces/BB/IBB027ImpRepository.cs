using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB027ImpRepository 
        : IGetListBase<CSICP_Bb027Imp, PrmFiltrosBB027Imp>, IRepositorioBase<CSICP_Bb027Imp>
    {
        Task<CSICP_Bb027Imp?> GetByIdAsync(int InTenantID, string InBB027ID);
        Task<(List<CSICP_Bb027Imp>, int)> GetListAsync(int InTenantID, PrmFiltrosBB027Imp prm);
    }

    public class PrmFiltrosBB027Imp : ParametrosBaseFiltro
    {
        public string? BB027ID { get; set; }
    }
}

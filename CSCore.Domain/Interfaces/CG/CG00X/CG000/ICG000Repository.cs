using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG000
{
    public interface ICG000Repository : IGetListBase<CSICP_CG000, PrmFiltrosCG000Repo>, IRepositorioBaseV2<CSICP_CG000>
    {
        Task<CSICP_CG000?> GetByIdAsync(int InTenant, string InIDCG000);
        Task<(List<CSICP_CG000>, int)> GetListAsync(int InTenant, PrmFiltrosCG000Repo InPrm);
        Task<CSICP_CG000?> GetByIdPorEstabIDAsync(int InTenant, string InEstabCG000ID);

    }
}

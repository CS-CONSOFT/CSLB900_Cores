using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF113;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF113Repository : IRepositorioBase<CSICP_FF113>
    {
        Task<RepoDtoCSICP_FF113?> GetByIdAsync(int in_tenant, string in_ff113Id);
        Task<(List<RepoDtoCSICP_FF113>, int)> GetListAsync(
            int in_tenant, int in_page, int in_pageSize, string? in_filialId, DateTime? in_dataRegistroInicio, DateTime? in_dataRegistroFim, int? in_tipo);

    }
}

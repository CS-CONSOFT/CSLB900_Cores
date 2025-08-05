using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF105;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF105Repository : IRepositorioBase<CSICP_FF105>
    {
        Task<(List<RepoDtoCSICP_FF105>, int)> GetListAsync(int in_tenant, int in_page, int in_pageSize,
            string? in_estabID,
            string? in_descBordero,
            string? in_agCobradorID,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal);
        Task<RepoDtoCSICP_FF105?> GetByIdAsync(int in_tenant, string id);
    }
}

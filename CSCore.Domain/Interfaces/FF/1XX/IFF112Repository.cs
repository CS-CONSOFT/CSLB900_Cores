using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF112;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF112Repository : IRepositorioBase<CSICP_FF112>
    {
        Task<RepoDtoCSICP_FF112?> GetByIdAsync(int in_tenant, string id);
        Task<(List<RepoDtoCSICP_FF112>, int)> GetListAsync(
            int in_tenant, int in_page, int in_pageSize, string? in_estabID, string? in_descCnab, string? in_bancoID, bool? in_isActive, int? in_tipoOperacao);
    }
}

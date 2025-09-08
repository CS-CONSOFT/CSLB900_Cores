using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF017;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF017Repository : IRepositorioBase<CSICP_FF017>
    {
        Task<(List<RepoDtoCSICP_FF017>, int)> GetListAsync(int in_tenant, string in_estabId, string? in_nomeCliente,
            DateTime? in_dataInicial, DateTime? in_dataFinal, int in_pageNumber, int in_pageSize);
        Task<RepoDtoCSICP_FF017?> GetByIdAsync(int in_tenant, string in_ff017Id);
    }
}

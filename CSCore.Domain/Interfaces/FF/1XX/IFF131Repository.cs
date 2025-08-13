using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF131;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF131Repository : IRepositorioBase<CSICP_FF131>
    {
        Task<(List<RepoDtoCSICP_FF131>, int)> GetListAsync(
            int in_tenant,
            int in_pageNumber,
            int in_pageSize,
            string? in_estabId,
            DateTime? in_periodoInicial,
            DateTime? in_periodoFinal,
            string? in_protocolo,
            string? in_nomeContaCliente);

        Task<RepoDtoCSICP_FF131?> GetByIdAsync(int in_tenant, long in_ff131Id);
    }
}

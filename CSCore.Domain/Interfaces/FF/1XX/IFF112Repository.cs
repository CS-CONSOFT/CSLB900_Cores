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
        Task<CSICP_FF112?> GetByIdAsync(int in_tenant, string in_ff112Id);
        Task<(List<CSICP_FF112>, int)> GetListAsync(
            int in_tenant, int in_pageNumber, int in_pageSize, string? in_estabId, string? in_descCnab, string? in_bancoId, bool? in_isActive, int? in_tipoOperacao);
    }
}

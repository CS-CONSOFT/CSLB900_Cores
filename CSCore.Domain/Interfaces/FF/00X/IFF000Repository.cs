using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF
{
    public interface IFF000Repository : IRepositorioBase<CSICP_FF000>
    {
        Task<(IEnumerable<CSICP_FF000>, int)> GetListAsync(int tenant, int page, int pageSize, string? razaoSocial, 
        string? usuario, string? estabelecimentoId);
        Task<CSICP_FF000?> GetByIdAsync(int tenant, string? id, string? estabID);
    }
}

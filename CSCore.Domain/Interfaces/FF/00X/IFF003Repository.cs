using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF
{
    public interface IFF003Repository : IRepositorioBase<CSICP_FF003>
    {
        Task<(IEnumerable<CSICP_FF003>, int)> GetListAsync(int tenant, int page, int pageSize,
           string? descricao, int? tipoEspecie);
        Task<CSICP_FF003?> GetByIdAsync(int tenant, string id);
    }
}

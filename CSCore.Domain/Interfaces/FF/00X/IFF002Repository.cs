using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF
{
    public interface IFF002Repository : IRepositorioBase<CSICP_FF002>
    {
        Task<(IEnumerable<RepoCSICP_FF002>, int)> GetListAsync(int tenant, int page, int pageSize, string? motivo, int? tipoRegistro);

        Task<RepoCSICP_FF002?> GetByIdAsync(int tenant, string id);
    }
}

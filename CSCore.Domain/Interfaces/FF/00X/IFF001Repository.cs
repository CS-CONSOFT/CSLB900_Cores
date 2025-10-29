using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF
{
    public interface IFF001Repository : IRepositorioBase<CSICP_FF001>
    {
        Task<(IEnumerable<CSICP_FF001>, int)> GetListAsync(int tenant, int page, int pageSize,
            string? descFeriado, string? nomeDoDia, string? prmEmpresaId);
        Task<CSICP_FF001?> GetByIdAsync(int tenant, string id);
    }
}

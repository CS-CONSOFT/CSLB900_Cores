using CSCore.Domain.CS_Models.CSICP_TT;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSCore.Domain.Interfaces.TT.TT0XX
{
    public interface ITT030Repository : IRepositorioBase<CSICP_TT030>
    {
        Task<(IEnumerable<CSICP_TT030>, int)> GetListAsync(int tenant, 
            string? in_estabId, 
            int? in_protocoloNumber, 
            string? in_observacao,
            string? in_usuarioVendedorId,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal,
            int pageSize, 
            int page);
        Task<CSICP_TT030?> GetByIdAsync(long id, int tenant);
    }
}

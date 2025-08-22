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
        Task<(List<RepoDtoCSICP_FF105>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_estabId,
            string? in_descBordero,
            string? in_agCobradorId,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal);
        Task<RepoDtoCSICP_FF105?> GetByIdAsync(int in_tenant, string in_ff105Id);

        Task PublicarBorderoAsync(int in_tenant, string in_borderoId, int in_idff105_status_publicado);
        Task DespublicarBorderoAsync(int in_tenant, string in_ff105_borderoId, int in_idff105_status_carregado);
        Task EncerrarBorderoAsync(int in_tenant, string in_ff105_borderoId, int in_idff105_status_encerrado);
    }
}

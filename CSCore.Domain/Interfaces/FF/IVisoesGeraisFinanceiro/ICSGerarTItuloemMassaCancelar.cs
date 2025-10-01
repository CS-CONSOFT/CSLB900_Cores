using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro
{
    public interface ICSGerarTItuloemMassaCancelar
    {
        Task<bool> CancelarGeracaoTitulosEmMassa(int tenantId, long ff040Id, int incsicp_ff040_sit_CANCELADO);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Rebanho.Processos.ProcessaLote
{
    public interface IProcessaLoteEAtualizaPeso
    {
        Task GetExecutaProcessoLote(int InTenantID, string InRR020IDLote);
    }
}

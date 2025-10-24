using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.ProcessaLote
{
    public interface IProcessaLoteEAtualizaPeso
    {
        Task GetExecutaProcessoLote(int InTenantID, string InRR020IDLote);
    }
}

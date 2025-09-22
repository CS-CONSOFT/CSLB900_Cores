using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Atualiza_Cobrador_Todos
{
    public interface IAtualizaCobradorTodosFF102
    {
        Task Atualiza_Cobrador_Todos(PrmAtualizaCobradorTodos InPrm);
    }
}

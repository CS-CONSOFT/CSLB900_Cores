using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Atualiza_Cobrador_Todos
{
    public class PrmAtualizaCobradorTodos
    {
        public int InTenantID { get; set; }
        public string InBB012_ID  { get; set; } = string.Empty;
        public string InBB006_CobradorID  { get; set; } = string.Empty;
        public string? InSY001_ID  { get; set; } = string.Empty;
        public int InStIDFF102_Cob_Cobranca { get; set; }
        public int InStIDFF102_Sit_Aberto { get; set; }
        public int InStIDFF102_Sit_BxParcial { get; set; }
    }
}

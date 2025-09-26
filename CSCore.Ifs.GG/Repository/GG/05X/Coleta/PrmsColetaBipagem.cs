using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._05X.Coleta
{
    public class PrmsColetaBipagem
    {
        public string FilialBB001ID { get; set; } = string.Empty;

        public string CodgBarras { get; set; } = string.Empty;

        public long GG054_ID { get; set; }

        public int StatusAbertoID { get; set; }
    }
}

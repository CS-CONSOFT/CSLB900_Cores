using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.CS_Models.CSICP_SYS
{
    public class CSICP_SY906_SPACE
    {
        public string ID { get; set; } = null!;

        public string? LABEL { get; set; }

        public int? ORDER { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public int? ID_SY806 { get; set; }

        public int? PROP_CS_SISPRO_ID { get; set; }

        public int? MENUTIPO { get; set; }
    }
}

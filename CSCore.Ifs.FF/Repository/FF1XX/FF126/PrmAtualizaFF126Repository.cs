using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF126
{
    public class PrmAtualizaFF126Repository
    {
        public ICS_GenerateId InCS_GenerateID { get; set; } = null!;
        public string InNovoProtocoloFF127 { get; set; } = string.Empty;
        public string InSY001Id { get; set; } = string.Empty;
        public int InTenantID { get; set; } = 0;
        public int InSTIDFF102SitAberto { get; set; } = 0;
        public int InSTIDFF102SitBxParcial { get; set; } = 0;
        public string InBB012_ID { get; set; } = string.Empty;
        public string InMensagem { get; set; } = string.Empty;
        public DateTime InDataPrevisao { get; set; } = DateTime.MinValue;
        public DateTime InDataVisita { get; set; } = DateTime.MinValue;
        public string InFF002_ID_Motivo { get; set; } = string.Empty;
    }
}

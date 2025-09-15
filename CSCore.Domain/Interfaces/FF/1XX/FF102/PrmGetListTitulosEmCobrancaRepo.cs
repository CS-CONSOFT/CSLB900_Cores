using CSLB900.MSTools.CS_QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102
{
    public class PrmGetListTitulosEmCobrancaRepo : ParametrosBaseFiltro
    {
        public PrmGetListTitulosEmCobrancaRepo(
            int inTenantID,
            string inBB012_ID,
            int inStIDFF102_Cob_Cobranca,
            int inStIDFF102_Sit_Aberto,
            int inStIDFF102_Sit_BxParcial)
        {
            InTenantID = inTenantID;
            InBB012_ID = inBB012_ID;
            InStIDFF102_Cob_Cobranca = inStIDFF102_Cob_Cobranca;
            InStIDFF102_Sit_Aberto = inStIDFF102_Sit_Aberto;
            InStIDFF102_Sit_BxParcial = inStIDFF102_Sit_BxParcial;
        }

        public int InTenantID { get; set; }
        public string InBB012_ID { get; set; } = string.Empty;
        public int InStIDFF102_Cob_Cobranca { get; set; }
        public int InStIDFF102_Sit_Aberto { get; set; }
        public int InStIDFF102_Sit_BxParcial { get; set; }
    }
}

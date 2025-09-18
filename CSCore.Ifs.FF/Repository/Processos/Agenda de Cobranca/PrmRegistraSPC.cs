using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.Agenda_de_Cobranca
{
    public class PrmRegistraSPC
    {
        public int InTenantId { get; set; }
        public string InFF126_ID { get; set; } = string.Empty;
        public int InStIDCsicp_bb012_SitCta_CIS { get; set; }
        public DateTime InFf126_DtRegistro { get; set; }
        public string InFf126_Mensagem { get; set; } = string.Empty;
        public string InSY001_ID { get; set; } = string.Empty;
        public bool InFf126Registrarspc { get; set; } = true;

        public PrmRegistraSPC(
            int inTenantId,
            string inFF126_ID, int inStIDCsicp_bb012_SitCta_CIS, DateTime inFf126_DtRegistro, string inFf126_Mensagem, string inSY001_ID, bool InRegistrarSPC)
        {
            InTenantId = inTenantId;
            InFF126_ID = inFF126_ID;
            InStIDCsicp_bb012_SitCta_CIS = inStIDCsicp_bb012_SitCta_CIS;
            InFf126_DtRegistro = inFf126_DtRegistro;
            InFf126_Mensagem = inFf126_Mensagem;
            InSY001_ID = inSY001_ID;
            this.InFf126Registrarspc = InRegistrarSPC;
        }
    }
}

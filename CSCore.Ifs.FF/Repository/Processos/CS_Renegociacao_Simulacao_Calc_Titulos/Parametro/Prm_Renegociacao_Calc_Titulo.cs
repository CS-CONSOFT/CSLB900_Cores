using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro
{
    public class Prm_Renegociacao_Calc_Simulacao_Titulos : PrmRenegociacaoCalcTitulosController
    {
        public int in_TenantID { get; set; }
        public int in_StID_bb008_tp_Dias { get; set; }
        public int in_StID_bb008_tp_ParcelaDias { get; set; }
        public int in_StID_bb008_tp_ParcelaMes { get; set; }
        public int in_StID_bb008_tp_A_vista { get; set; }
    }

    public class PrmRenegociacaoCalcTitulosController
    {
        public string in_renegociacaoID { get; set; } = string.Empty;
        public string in_condicaoPagamento { get; set; } = string.Empty;
        public decimal in_valorEntrada { get; set; }
        public DateTime in_data { get; set; }
    }
}

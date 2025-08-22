using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloBaixar_Kernel
{
    public class PrmMovtoTituloBaixarKernel
    {
        public string InFF103ID { get; set; } = string.Empty;
        public string InSY001UsuarioID { get; set; } = string.Empty;
        public int InTenantID { get; set; }
        public int InSTIDff102SitLiquidado { get; set; }
        public int InSTIDff102SitCancelado { get; set; }
        public int InSTIDff102SitRenegociado { get; set; }
        public int InSTIDff102SitProvisao { get; set; }
        /*PARAMTROS PARA _tituloCalculoBaixa*/
        public int InSTIDFF102BxParcial_tituloCalcBaixa { get; set; }
        public int InSTIDFF102Aberto_tituloCalcBaixa { get; set; }
        public int InSTIDFF103TpBaiCancelamento_tituloCalcBaixa { get; set; }
        public int InSTIDFF103TpBaiDevolucao_tituloCalcBaixa { get; set; }
        public int InSTIDFF103TpBaiDoacao_tituloCalcBaixa { get; set; }
        public string InEstabID_tituloCalcBaixa { get; set; } = string.Empty;

    }
}

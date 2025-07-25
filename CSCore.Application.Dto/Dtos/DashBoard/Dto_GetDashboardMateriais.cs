using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DashBoard
{
    public class Dto_GetDashboardMateriais
    {
        public int almoxarifados { get; set; }
        public int produtos { get; set; }
        public int kardex { get; set; }
        public int almoxarifados_por_estabelecimento { get; set; }
        public int produtos_por_estabelecimento { get; set; }
        public int saldos_por_estabelecimento { get; set; }
        public SaldosTotais saldos_totais { get; set; }
        public OutrosTotalizadores outros_totalizadores { get; set; }

    }
    public class OutrosTotalizadores
    {
        public int artigo { get; set; }
        public int marca { get; set; }
        public int grupo { get; set; }
        public int sub_grupo { get; set; }
        public int classe { get; set; }
        public int categoria { get; set; }
        public int unidade { get; set; }
        public int padrao { get; set; }
        public int ncm { get; set; }
        public int linha { get; set; }
        public int tipo_padrao { get; set; }
        public int qualidade_produto { get; set; }
        public int anp { get; set; }
    }

    public class SaldosTotais
    {
        public int produtos { get; set; }
        public int kardex { get; set; }
        public int saldos_por_armazem { get; set; }
    }


}

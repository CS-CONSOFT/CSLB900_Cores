using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro
{
    public class Prm_Renegociacao_Cria_Titulo
    {
        public int In_TenantID { get; set; }
        public string? In_FF017_ID { get; set; }
        public string? In_FF999_ControleID { get; set; }
        public string In_BB001_FilialID { get; set; } = null!;
        public int In_FF102_Ent_Entrada { get; set; }
        public int In_FF102_Ent_Parcela { get; set; }
        public int In_Statica_Sim { get; set; }
        public int In_Statica_Nao { get; set; }
        public int In_FF102AutPgtoAutorizado { get; set; }
        public int In_FF102AutPgtoNaoAutorizado { get; set; }
    }
}

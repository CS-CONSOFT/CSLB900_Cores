using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102.RepoDto
{

    public class RepoDtoCSICP_FF102
    {
        public CSICP_FF102 CSICP_FF102 { get; set; } = null!;

        public int? CSDiasAtraso { get; set; } = default;
        public decimal? CSValorCorrecaoMonetaria { get; set; } = default;
        public decimal? CSValorMulta { get; set; } = default;
        public decimal? CSValorHonorarios { get; set; } = default;
        public decimal? CSValorJuros { get; set; } = default;
        public decimal? CSValorAPagar { get; set; } = default;
        public decimal? CSPercentualJurosConfig { get; set; }
        public decimal? CSPercentualMultaConfig { get; set; }
        public decimal? CSPercentualCorrecaoMonetariaConfig { get; set; }
        public decimal? CSPercentualHonorarioConfig { get; set; }

        public CSICP_BB001? NavBB001 { get; set; }
        public CSICP_Bb005? NavBB005 { get; set; }
        public CSICP_Bb006? NavBB006 { get; set; }
        public CSICP_BB007? NavBB007 { get; set; }
        public CSICP_Bb008? NavBB008 { get; set; }
        public CSICP_Bb009? NavBB009 { get; set; }
        public CSICP_Bb019? NavBB019 { get; set; }
        public CSICP_BB012? NavBB012 { get; set; }
        public CSICP_BB012? NavBB012ContaID { get; set; }
        public CSICP_BB012? NavBB012ContaRealID { get; set; }
        public CSICP_BB012? NavBB012AvalistaID { get; set; }
        public CSICP_Bb01201Jur? NavBB01201Jur { get; set; }
        public CSICP_Bb026? NavBB026 { get; set; }
        public CSICP_FF000? NavFF000 { get; set; }
        public CSICP_FF003? NavFF003 { get; set; }
        public CSICP_FF102_C021? NavFF102C021 { get; set; }
        public CSICP_FF102Des? NavFF102Des { get; set; }
        public CSICP_FF102Ent? NavFF102Ent { get; set; }
        public CSICP_FF102Sit? NavFF102Sit { get; set; }
        public CSICP_FF102_C018? NavFF102C018 { get; set; }
        public CSICP_FF102_G073? NavFF102G073 { get; set; }
        public CSICP_FF102Cob? NavFF102Cob { get; set; }
        public CSICP_FF102Aut? NavFF102Aut { get; set; }
        public CSICP_FF102ApiBanco? NavFF102ApiBanco { get; set; }
        public CSICP_FF102Adt? NavFF102Adt { get; set; }
        public CSICP_FF112ApiOcorrencium? NavFF112ApiOcorrencium { get; set; }
        public CSICP_FF112ApiLiquidacao? NavFF112ApiLiquidacao { get; set; }
        public CSICP_FF112ApiBaixa? NavFF112ApiBaixa { get; set; }
        public CSICP_FF120TrackApi? NavFF120Trackapi { get; set; }
        public Csicp_Sy001? NavSy001Usuario { get; set; }
        public Csicp_Sy001? NavSy001CodCobrador { get; set; }
        public Csicp_Sy001? NavSy001Aprovador { get; set; }
        public Csicp_Sy001? NavSy001CTBUsuarioID { get; set; }
        public Csicp_Sy001? NavSy001CTBEstUsuarioID { get; set; }
        public Csicp_Sy001? NavSy001CTLUsuarioID { get; set; }
        public Csicp_Sy001? NavSy001CTLEstUsuarioID { get; set; }
        public CSICP_Statica? NavStaticaFluxoCaixa { get; set; }
        public CSICP_Statica? NavStaticaConfirmadoID { get; set; }

    }
}

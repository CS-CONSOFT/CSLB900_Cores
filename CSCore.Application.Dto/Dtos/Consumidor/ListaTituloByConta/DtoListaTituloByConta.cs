using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Application.Dto.Dtos.Consumidor.ListaTituloByConta
{

    public class DtoListaTituloByConta
    {
        public List<StrRetListTitulo> strRetListTitulos { get; set; } = [];
        public ContadorCR? Contador_CR { get; set; }
    }

    public class CamposVirtuaisBaixaTitulo
    {
        public string atraso { get; set; }
        public double? multa { get; set; }
        public double? juros { get; set; }
        public double? valor_a_pagar { get; set; }
    }

    public class ContadorCR
    {
        public int? QtdeTitulo { get; set; }
        public double? TotalTitulo { get; set; }
        public double? TotalAberto { get; set; }
        public double? TotalJuros { get; set; }
        public double? TotalMulta { get; set; }
        public double? TotalDescontos { get; set; }
        public double? TotalPago { get; set; }
        public double? TotalPagar { get; set; }
    }


    public class StrRetListTitulo
    {
        public CSICP_BB012? csicp_bb012 { get; set; }
        public CSICP_FF102Sit? csicp_ff102_sit { get; set; }
        //public CSICP_DD csicp_dd040 { get; set; }
        public CSICP_Bb006? csicp_bb006 { get; set; }
        public CSICP_BB001? csicp_bb001 { get; set; }
        public CSICP_FF102? csicp_ff102 { get; set; }
        public CamposVirtuaisBaixaTitulo? CamposVirtuaisBaixaTitulo { get; set; }
    }


}

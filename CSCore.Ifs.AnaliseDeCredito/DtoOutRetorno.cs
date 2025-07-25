using CSCore.Domain;

namespace CSCore.Ifs.AnaliseDeCredito
{
    public class DtoOutRetorno
    {
        public CSICP_BB01210? CsicpBb01210 { get; set; }
        public CSICP_BB012? CsicpBb012 { get; set; }
        public CSICP_BB01201? CsicpBb01201 { get; set; }
        public CSICP_BB01202? CsicpBb01202 { get; set; }
        public List<CSICP_BB01210> CreditoGradualList { get; set; } = new();
    }
}

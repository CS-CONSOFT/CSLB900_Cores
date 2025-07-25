using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSCore.Domain;

namespace CSCore.Application.Dto.Dtos.AnaliseCredito
{
    public class DtoOutRetornoApplication
    {
        public CSICP_BB01210? CsicpBb01210 { get; set; }
        public Dto_GetBB012_Exibicao? CsicpBb012 { get; set; }
        public List<CSICP_BB01210> CreditoGradualList { get; set; } = new();
    }
}

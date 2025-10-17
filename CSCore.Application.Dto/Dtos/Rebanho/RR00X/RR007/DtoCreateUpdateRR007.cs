using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR007
{
    public class DtoCreateUpdateRR007 : IConverteParaEntidade<OsusrTo3CsicpRr007>
    {
        public string? Rr007Proprietario { get; set; }

        public OsusrTo3CsicpRr007 ToEntity(int tenant, string? _)
        {
            return new OsusrTo3CsicpRr007
            {
                TenantId = tenant,
                Rr007Proprietario = Rr007Proprietario
            };
        }
    }
}
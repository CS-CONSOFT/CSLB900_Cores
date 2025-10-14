using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR006
{
    public class DtoCreateUpdateRR006 : IConverteParaEntidade<OsusrTo3CsicpRr006>
    {
        public string? Rr006Ocorrencia { get; set; }

        public OsusrTo3CsicpRr006 ToEntity(int tenant, string? _)
        {
            return new OsusrTo3CsicpRr006
            {
                TenantId = tenant,
                Rr006Ocorrencia = Rr006Ocorrencia
            };
        }
    }
}
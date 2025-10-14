using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR005
{
    public class DtoCreateUpdateRR005 : IConverteParaEntidade<OsusrTo3CsicpRr005>
    {
        public string? Rr005Situacao { get; set; }

        public OsusrTo3CsicpRr005 ToEntity(int tenant, string? _)
        {
            return new OsusrTo3CsicpRr005
            {
                TenantId = tenant,
                Rr005Situacao = Rr005Situacao
            };
        }
    }
}
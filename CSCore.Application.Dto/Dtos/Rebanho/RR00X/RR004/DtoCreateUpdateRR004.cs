using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR004
{
    public class DtoCreateUpdateRR004 : IConverteParaEntidade<OsusrTo3CsicpRr004>
    {
        public string? Rr004Raca { get; set; }

        public OsusrTo3CsicpRr004 ToEntity(int tenant, string? _)
        {
            return new OsusrTo3CsicpRr004
            {
                TenantId = tenant,
                Rr004Raca = Rr004Raca
            };
        }
    }
}
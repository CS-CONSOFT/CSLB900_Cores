using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR008
{
    public class DtoCreateUpdateRR008 : IConverteParaEntidade<OsusrTo3CsicpRr008>
    {
        public string? Rr008Regalimentar { get; set; }

        public string? Rr008Descritivo { get; set; }

        public OsusrTo3CsicpRr008 ToEntity(int tenant, string? _)
        {
            return new OsusrTo3CsicpRr008
            {
                TenantId = tenant,
                Rr008Regalimentar = Rr008Regalimentar,
                Rr008Descritivo = Rr008Descritivo
            };
        }
    }
}
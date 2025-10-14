using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR003
{
    public class DtoCreateUpdateRR003 : IConverteParaEntidade<OsusrTo3CsicpRr003>
    {
        public string? Rr003Descricao { get; set; }

        public OsusrTo3CsicpRr003 ToEntity(int tenant, string? _)
        {
            return new OsusrTo3CsicpRr003
            {
                TenantId = tenant,
                Rr003Descricao = Rr003Descricao
            };
        }
    }
}
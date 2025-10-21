using CSCore.Domain.CS_Models.CSICP_RR;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021
{
    public class DtoCreateRR021 : IConverteParaEntidade<OsusrTo3CsicpRr021>
    {
        public string? Rr021Animalid { get; set; }
        public DateTime? Rr021Dtregistro { get; set; }

        public OsusrTo3CsicpRr021 ToEntity(int tenantId, string? id)
        {
            return new OsusrTo3CsicpRr021
            {
                TenantId = tenantId,
                Id = id!,
                Rr021Animalid = Rr021Animalid,
                Rr021Dtregistro = Rr021Dtregistro
            };
        }
    }

    public class DtoCreateRR021List
    {
        public List<DtoCreateRR021>? CreateListRR021 { get; set; }
    }
}
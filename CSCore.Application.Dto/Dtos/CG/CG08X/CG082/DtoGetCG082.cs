using CSCore.Application.Dto.Dtos.CG.CG00X.CG006;
using CSCore.Application.Dto.Dtos.CG.CG08X.CG081;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Dtos.CG.CG08X.CG082
{
    public class DtoGetCG082
    {
        public int TenantId { get; set; }

        public long Cg082Id { get; set; }

        public long? Cg082Contrelregid { get; set; }

        public string? Cg082Contcontaid { get; set; }

        public DateTime? Cg082Dateinicial { get; set; }

        public DateTime? Cg082Datefinal { get; set; }

        public DtoGetCG081Padrao? NavCG081ContRelRegID_CG082 { get; set; }

        public DtoGetCG006Padrao? NavCG006ContConta_CG082 { get; set; }
    }
}
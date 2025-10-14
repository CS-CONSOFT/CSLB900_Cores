using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG016.GG016f
{
    public class DtoCreateUpdateGG016f : IConverteParaEntidade<CSICP_GG016f>
    {
        public long? Gg016eId { get; set; }

        public string? Gg016fGradelinhaid { get; set; }

        public string? Gg016fGradecolunaid { get; set; }

        public CSICP_GG016f ToEntity(int tenant, string? _)
        {
            return new CSICP_GG016f
            {
                TenantId = tenant,
                Gg016eId = this.Gg016eId,
                Gg016fGradelinhaid = this.Gg016fGradelinhaid,
                Gg016fGradecolunaid = this.Gg016fGradecolunaid,
            };
        }
    }
}

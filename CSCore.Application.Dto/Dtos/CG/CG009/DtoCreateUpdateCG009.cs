using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG009
{
    public class DtoCreateUpdateCG009 : IConverteParaEntidade<CSICP_CG009>
    {
        public string? Cg009FilialId { get; set; }

        public string? Cg009TipoSaldoId { get; set; }

        public string? Cg009ContaId { get; set; }

        public int Cg009Ano { get; set; }

        public int Cg009Mes { get; set; }



        public CSICP_CG009 ToEntity(int tenant, string? id)
        {
            return CSICP_CG009.CreateInstance(tenant, id!, Cg009FilialId, Cg009TipoSaldoId , Cg009ContaId, Cg009Ano, Cg009Mes);
        }
    }
}
using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG006;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG008;
using CSCore.Domain.CS_Models.CSICP_BB;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Dtos.CG.CG00X.CG009
{
    public class DtoGetCG009
    {
        public int TenantId { get; set; }

        public string Cg009Id { get; set; } = null!;

        public string? Cg009FilialId { get; set; }

        public string? Cg009TipoSaldoId { get; set; }

        public string? Cg009ContaId { get; set; }

        public int? Cg009Ano { get; set; }

        public int? Cg009Mes { get; set; }

        public decimal? Cg009Totaldebito { get; set; }

        public decimal? Cg009Totalcredito { get; set; }

        public decimal? Cg009Saldo { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001Estab_CG009 { get; set; }
        public DtoGetCG006Padrao? NavCG006Conta_CG009 { get; set; }
        public DtoGetCG008? NavCG008TipoSaldo_CG009 { get; set; }
    }
}
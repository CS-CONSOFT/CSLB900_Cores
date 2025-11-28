using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG009;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG009Mapper
    {
        public static DtoGetCG009 ToDtoGet(this CSICP_CG009 entity)
        {
            return new DtoGetCG009
            {
                TenantId = entity.TenantId,
                Cg009Id = entity.Cg009Id,
                Cg009FilialId = entity.Cg009FilialId,
                Cg009TipoSaldoId = entity.Cg009TipoSaldoId,
                Cg009ContaId = entity.Cg009ContaId,
                Cg009Ano = entity.Cg009Ano,
                Cg009Mes = entity.Cg009Mes,
                Cg009Totaldebito = entity.Cg009Totaldebito,
                Cg009Totalcredito = entity.Cg009Totalcredito,
                Cg009Saldo = entity.Cg009Saldo,
                NavBB001Estab_CG009 = entity.NavBB001Estab_CG009?.ToDtoGetExibicao(),
                NavCG006Conta_CG009 = entity.NavCG006Conta_CG009?.ToDtoGetPadrao(),
                NavCG008TipoSaldo_CG009 = entity.NavCG008TipoSaldo_CG009?.ToDtoGet()
            };
        }

        public static DtoGetCG009Padrao ToDtoGetPadrao(this CSICP_CG009 entity)
        {
            return new DtoGetCG009Padrao
            {
                TenantId = entity.TenantId,
                Cg009Id = entity.Cg009Id,
                Cg009FilialId = entity.Cg009FilialId,
                Cg009TipoSaldoId = entity.Cg009TipoSaldoId,
                Cg009ContaId = entity.Cg009ContaId,
                Cg009Ano = entity.Cg009Ano,
                Cg009Mes = entity.Cg009Mes,
                Cg009Totaldebito = entity.Cg009Totaldebito,
                Cg009Totalcredito = entity.Cg009Totalcredito,
                Cg009Saldo = entity.Cg009Saldo
            };
        }
    }
}
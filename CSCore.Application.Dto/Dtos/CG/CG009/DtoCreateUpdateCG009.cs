using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG009
{
    public class DtoCreateUpdateCG009 : IConverteParaEntidade<CSICP_CG009>
    {
        public string? Cg009FilialId { get; set; }

        public string? Cg009TipoSaldoId { get; set; }

        public string? Cg009ContaId { get; set; }

        public int? Cg009Ano { get; set; }

        public int? Cg009Mes { get; set; }

        public decimal? Cg009Totaldebito { get; set; }

        public decimal? Cg009Totalcredito { get; set; }

        public decimal? Cg009Saldo { get; set; }

        public CSICP_CG009 ToEntity(int tenant, string? id)
        {
            return new CSICP_CG009
            {
                TenantId = tenant,
                Cg009Id = id!,
                Cg009FilialId = Cg009FilialId,
                Cg009TipoSaldoId = Cg009TipoSaldoId,
                Cg009ContaId = Cg009ContaId,
                Cg009Ano = Cg009Ano,
                Cg009Mes = Cg009Mes,
                Cg009Totaldebito = Cg009Totaldebito,
                Cg009Totalcredito = Cg009Totalcredito,
                Cg009Saldo = Cg009Saldo
            };
        }
    }
}
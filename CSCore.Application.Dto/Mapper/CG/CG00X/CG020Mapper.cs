using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG020;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG020Mapper
    {
        public static DtoGetCG020 ToDtoGet(this CSICP_CG020 entity)
        {
            return new DtoGetCG020
            {
                TenantId = entity.TenantId,
                Cg020Id = entity.Cg020Id,
                Cg020FilialId = entity.Cg020FilialId,
                Cg020Ano = entity.Cg020Ano,
                Cg020Mes = entity.Cg020Mes,
                Cg020Lote = entity.Cg020Lote,
                Cg020TiposaldoId = entity.Cg020TiposaldoId,
                Cg020Datainicio = entity.Cg020Datainicio,
                Cg020Datafinal = entity.Cg020Datafinal,
                Cg020Qtdlanctos = entity.Cg020Qtdlanctos,
                Cg020Totaldebito = entity.Cg020Totaldebito,
                Cg020Totalcredito = entity.Cg020Totalcredito,
                Cg020Difdebcre = entity.Cg020Difdebcre,
                Cg020Gtdebcre = entity.Cg020Gtdebcre,
                Cg020Ultlancto = entity.Cg020Ultlancto,
                Cg020UltSeq = entity.Cg020UltSeq,
                Cg020SituacaoloteId = entity.Cg020SituacaoloteId,
                Cg020ConsolidadoFilialId = entity.Cg020ConsolidadoFilialId,
                NavBB001Estab_CG020 = entity.NavBB001Estab_CG020?.ToDtoGetExibicao(),
                NavBB001ConsoEstab_CG020 = entity.NavBB001ConsoEstab_CG020?.ToDtoGetExibicao(),
                NavCG008TpSaldo_CG020 = entity.NavCG008TpSaldo_CG020?.ToDtoGet(),
                NavCG992_CG020 = entity.NavCG992_CG020
            };
        }
    }
}
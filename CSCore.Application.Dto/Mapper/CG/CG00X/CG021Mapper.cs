using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG021;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG021Mapper
    {
        public static DtoGetCG021 ToDtoGet(this Osusr8dwCsicpCg021 entity)
        {
            return new DtoGetCG021
            {
                TenantId = entity.TenantId,
                Cg021Id = entity.Cg021Id,
                Cg021FilialId = entity.Cg021FilialId,
                Cg021LoteId = entity.Cg021LoteId,
                Cg021Nrolancamento = entity.Cg021Nrolancamento,
                Cg021Seq = entity.Cg021Seq,
                Cg021ConsolidarFilialId = entity.Cg021ConsolidarFilialId,
                Cg021Data = entity.Cg021Data,
                Cg021ContacontabilId = entity.Cg021ContacontabilId,
                Cg021Debcre = entity.Cg021Debcre,
                Cg021Nrodocumento = entity.Cg021Nrodocumento,
                Cg021Valorlancto = entity.Cg021Valorlancto,
                Cg021HistoricoId = entity.Cg021HistoricoId,
                Cg021Historico = entity.Cg021Historico,
                Cg021CtagerencialN2Id = entity.Cg021CtagerencialN2Id,
                Cg021CtagerencialN3Id = entity.Cg021CtagerencialN3Id,
                Cg021CtagerencialN4Id = entity.Cg021CtagerencialN4Id,
                Cg021TiposaldoId = entity.Cg021TiposaldoId,
                Cg021Consolidar = entity.Cg021Consolidar,
                Cg021Isconsolidado = entity.Cg021Isconsolidado,
                Cg021Contacontabil = entity.Cg021Contacontabil,
                Cg021Valorlanctoant = entity.Cg021Valorlanctoant,
                Cg021ProjetoId = entity.Cg021ProjetoId,
                Nn010Id = entity.Nn010Id,
                Nn015Id = entity.Nn015Id,
                Cg021Protocolo = entity.Cg021Protocolo,
                Cg021Sequencia = entity.Cg021Sequencia,
                NavBB001Estab_CG021 = entity.NavBB001Estab_CG021?.ToDtoGetExibicao(),
                NavBB001EstabConsolida_CG021 = entity.NavBB001EstabConsolida_CG021?.ToDtoGetExibicao(),
                NavCG005Hist_CG021 = entity.NavCG005Hist_CG021?.ToDtoGetPadrao(),
                NavCG006ContaContabil_CG021 = entity.NavCG006ContaContabil_CG021?.ToDtoGetPadrao(),
                NavCG007Projeto_CG021 = entity.NavCG007Projeto_CG021?.ToDtoGet(),
               // NavCG008TpSaldo_CG021 = entity.NavCG008TpSaldo_CG021?.ToDtoGetPadrao(),
                NavCG993DebCre_CG021 = entity.NavCG993DebCre_CG021,
                NavCG011ContaGerencialN2_CG021 = entity.NavCG011ContaGerencialN2_CG021?.ToDtoGet(),
                NavCG012ContaGerencialN3_CG021 = entity.NavCG012ContaGerencialN3_CG021?.ToDtoGet(),
                NavCG013ContaGerencialN4_CG021 = entity.NavCG013ContaGerencialN4_CG021?.ToDtoGet(),
               // NavCG020Lote_CG021 = entity.NavCG020Lote_CG021?.ToDtoGetPadrao(),
               // NavCG070Protocolo_CG021 = entity.NavCG070Protocolo_CG021?.ToDtoGet(),
                //NavNN010_CG021 = entity.NavNN010_CG021?.ToDtoGet(),
               // NavNN015_CG021 = entity.NavNN015_CG021?.ToDtoGetExibicao(),
                //NavStaticConsolidar_CG021 
            };
        }
    }
}
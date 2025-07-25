using CSBS101._82Application.Dto.BB00X.BB017;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101.C82Application.Dto.BB00X.BB01X.BB017;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB017ExtensionMethods
    {
        public static CSICP_Bb017 ToEntity(this Dto_CreateUpdateBB017 dto)
        {
            var entity = new CSICP_Bb017
            {
                Bb017Empresaid = dto.Bb017Empresaid,
                Bb017Fpagtoid = dto.Bb017Fpagtoid,
                Bb017Condicaoid = dto.Bb017Condicaoid,
                Bb017Fatoracrescimo = dto.Bb017Fatoracrescimo,
                Bb017Fatorsementrada = dto.Bb017Fatorsementrada,
                Bb017Ordem = dto.Bb017Ordem,
                Bb017CmdTefVdId = dto.Bb017CmdTefVdId,
                Bb017CmdTefCancId = dto.Bb017CmdTefCancId,
                Bb017Parcliquidadas = dto.Bb017Parcliquidadas,
                Bb017Entliquidada = dto.Bb017Entliquidada,
                Bb017Vacimade = dto.Bb017Vacimade
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB017 ToDtoGet(this CSICP_Bb017 entity)
        {
            return new Dto_GetBB017
            {
                Bb017Id = entity.Bb017Id,
                TenantId = entity.TenantId,
                Bb017Empresaid = entity.Bb017Empresaid,
                Bb017Fpagtoid = entity.Bb017Fpagtoid,
                Bb017Condicaoid = entity.Bb017Condicaoid,
                Bb017Fatoracrescimo = entity.Bb017Fatoracrescimo,
                Bb017Fatorsementrada = entity.Bb017Fatorsementrada,
                Bb017Ordem = entity.Bb017Ordem,
                Bb017CmdTefVdId = entity.Bb017CmdTefVdId,
                Bb017CmdTefCancId = entity.Bb017CmdTefCancId,
                Bb017Parcliquidadas = entity.Bb017Parcliquidadas,
                Bb017Entliquidada = entity.Bb017Entliquidada,
                Bb017Vacimade = entity.Bb017Vacimade,
                NavBb008Condicao = entity.NavBb008Condicao?.ToDtoGetSimples(),
                NavBB026FormaPagamento = entity.NavBB026Forma?.ToDtoGetExibicao(),
                NavSta_BB017_EntLiquidada = entity.NavStatica_BB017_EntLiquidada,
                NavSta_BB017_ParcLiquidadas = entity.NavStatica_BB017_ParcLiquidadas,
                NavCSICP_PD001Ctef_Cmd_Tef_VD = entity.NavCSICP_PD001Ctef_Cmd_Tef_VD,
                NavCSICP_PD001Ctef_Cmd_Tef_Canc = entity.NavCSICP_PD001Ctef_Cmd_Tef_Canc
            };
        }


        public static Dto_GetBB017 ToDtoGetSemCondicao(this CSICP_Bb017 entity)
        {
            return new Dto_GetBB017
            {
                Bb017Id = entity.Bb017Id,
                TenantId = entity.TenantId,
                Bb017Empresaid = entity.Bb017Empresaid,
                Bb017Fpagtoid = entity.Bb017Fpagtoid,
                Bb017Condicaoid = entity.Bb017Condicaoid,
                Bb017Fatoracrescimo = entity.Bb017Fatoracrescimo,
                Bb017Fatorsementrada = entity.Bb017Fatorsementrada,
                Bb017Ordem = entity.Bb017Ordem,
                Bb017CmdTefVdId = entity.Bb017CmdTefVdId,
                Bb017CmdTefCancId = entity.Bb017CmdTefCancId,
                Bb017Parcliquidadas = entity.Bb017Parcliquidadas,
                Bb017Entliquidada = entity.Bb017Entliquidada,
                Bb017Vacimade = entity.Bb017Vacimade,
                NavSta_BB017_EntLiquidada = entity.NavStatica_BB017_EntLiquidada,
                NavSta_BB017_ParcLiquidadas = entity.NavStatica_BB017_ParcLiquidadas,
                //NavCSICP_PD001Ctef_Cmd_Tef_VD = entity.NavCSICP_PD001Ctef_Cmd_Tef_VD,
                //NavCSICP_PD001Ctef_Cmd_Tef_Canc = entity.NavCSICP_PD001Ctef_Cmd_Tef_Canc
            };
        }
    }
}

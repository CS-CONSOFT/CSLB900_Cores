using CSBS101._82Application.Dto.BB00X.BB025;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.BB00X
{
    public static class BB025ExtensionMethods
    {
        public static CSICP_Bb025 ToEntity(this Dto_CreateUpdateBB025 dto)
        {
            var entity = new CSICP_Bb025
            {
                Bb025Filial = dto.Bb025Filial,
                Bb025Codigo = dto.Bb025Codigo,
                Bb025Descricao = dto.Bb025Descricao,
                //Bb025GeraDuplicata = dto.Bb025GeraDuplicata == true ? 1 : 0,
                //Bb025UsaTabelaPreco = dto.Bb025UsaTabelaPreco,
                //Bb025Codtptransacao = dto.Bb025Codtptransacao,
                //Bb025Transacaoid = dto.Bb025Transacaoid,
                //Bb025GrupoContabil = dto.Bb025GrupoContabil,
                //Bb025Moddoctofiscal = dto.Bb025Moddoctofiscal,
                //Bb025Cfopdentroestado = dto.Bb025Cfopdentroestado,
                //Bb025Cfopforaestado = dto.Bb025Cfopforaestado,
                //Bb025Baixaestoque = dto.Bb025Baixaestoque,
                Empresaid = dto.Empresaid,
                Bb025Isactive = true,
                Bb025ModdoctofiscalId = dto.Bb025ModdoctofiscalId,
                //Bb025Valorizarprecoid = dto.Bb025Valorizarprecoid,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB025 ToDtoGet(this CSICP_Bb025 entity)
        {
            return new Dto_GetBB025
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb025Filial = entity.Bb025Filial,
                Bb025Codigo = entity.Bb025Codigo,
                Bb025Descricao = entity.Bb025Descricao,
                Bb025GeraDuplicata = entity.Bb025GeraDuplicata,
                Bb025UsaTabelaPreco = entity.Bb025UsaTabelaPreco,
                Bb025Codtptransacao = entity.Bb025Codtptransacao,
                Bb025Transacaoid = entity.Bb025Transacaoid,
                Bb025GrupoContabil = entity.Bb025GrupoContabil,
                Bb025Moddoctofiscal = entity.Bb025Moddoctofiscal,
                Bb025Cfopdentroestado = entity.Bb025Cfopdentroestado,
                Bb025Cfopforaestado = entity.Bb025Cfopforaestado,
                Bb025Baixaestoque = entity.Bb025Baixaestoque,
                Empresaid = entity.Empresaid,
                Bb025Isactive = entity.Bb025Isactive,
                Bb025ModdoctofiscalId = entity.Bb025ModdoctofiscalId,
                Bb025Valorizarprecoid = entity.Bb025Valorizarprecoid,
                NavBb025Transacao = entity.Bb025Transacao?.ToDtoGet(),
                NavSpedICMS = entity.osusr66CSpedInAjIcm,
                NavBb025ModdoctofiscalId =  entity.NavBb025ModdoctofiscalId,

            };
        }

        public static Dto_GetBB025_Exibicao ToDtoGetSimples(this CSICP_Bb025 entity)
        {
            return new Dto_GetBB025_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,

                Bb025Codigo = entity.Bb025Codigo,
                Bb025Descricao = entity.Bb025Descricao,


            };
        }
    }
}


using CSBS101._82Application.Dto.BB00X.BB06X.BB062;
using CSBS101._82Application.ExtensionsMethods.BB00X.BB03X.BB037;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB062
{
    public static class BB062ExtensionMethods
    {
        public static CSICP_Bb062 ToEntity(this Dto_CreateUpdateBB062 dto)
        {
            var entity = new CSICP_Bb062
            {
                Bb062Ano = dto.Bb062Ano,
                Bb062Mes = dto.Bb062Mes,
                Bb062Descritivo = dto.Bb062Descritivo,
                Bb062Dtemissao = dto.Bb062Dtemissao,
                Bb062Diavenctoid = dto.Bb062Diavenctoid,
                Bb062Statusid = dto.Bb062Statusid,
                Bb062Estabid = dto.Bb062Estabid,

            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB062 ToDtoGet(this CSICP_Bb062 entity)
        {
            return new Dto_GetBB062
            {
                TenantId = entity.TenantId,
                Bb062Id = entity.Bb062Id,
                Bb062Ano = entity.Bb062Ano,
                Bb062Mes = entity.Bb062Mes,
                Bb062Descritivo = entity.Bb062Descritivo,
                Bb062Dtemissao = entity.Bb062Dtemissao,
                Bb062Diavenctoid = entity.Bb062Diavenctoid,
                Bb062Statusid = entity.Bb062Statusid,
                Bb062Estabid = entity.Bb062Estabid,
                NavBb062Diavencto = entity.NavBB037Diavencto?.ToDtoGet(),
                NavBb062Status = entity.NavBb062Status,
            };
        }
    }
}

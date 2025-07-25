
using CSBS101._82Application.Dto.BB00X.BB05X.BB057;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB05X.BB057
{
    public static class BB057ExtensionMethods
    {
        public static CSICP_Bb057 ToEntity(this Dto_CreateUpdateBB057 dto)
        {
            var entity = new CSICP_Bb057
            {
                Bb055Id = dto.Bb055Id,
                Bb012Id = dto.Bb012Id,
                Bb057Datahora = dto.Bb057Datahora,
                Bb057Issmsenvprof = dto.Bb057Issmsenvprof,
                Bb057Issmsenvcliente = dto.Bb057Issmsenvcliente,
                Bb057Dtsmsprof = dto.Bb057Dtsmsprof,
                Bb057Dtsmscliente = dto.Bb057Dtsmscliente
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB057 ToDtoGet(this CSICP_Bb057 entity)
        {
            return new Dto_GetBB057
            {
                TenantId = entity.TenantId,
                Bb057Id = entity.Bb057Id,
                Bb055Id = entity.Bb055Id,
                Bb012Id = entity.Bb012Id,
                Bb057Datahora = entity.Bb057Datahora,
                Bb057Issmsenvprof = entity.Bb057Issmsenvprof,
                Bb057Issmsenvcliente = entity.Bb057Issmsenvcliente,
                Bb057Dtsmsprof = entity.Bb057Dtsmsprof,
                Bb057Dtsmscliente = entity.Bb057Dtsmscliente,
                NavBB012 = entity.NavBB012?.ToDtoBB012Simples(),
            };
        }
    }
}

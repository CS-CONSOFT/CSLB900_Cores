

using CSBS101._82Application.Dto.BB00X.BB05X.BB056;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB05X.BB056
{
    public static class BB056ExtensionMethods
    {
        public static CSICP_Bb056 ToEntity(this Dto_CreateUpdateBB056 dto)
        {
            var entity = new CSICP_Bb056
            {
                Bb056Profid = dto.Bb056Profid,
                Bb056Contaid = dto.Bb056Contaid,
                Bb056Mensagem = dto.Bb056Mensagem,
                Bb056Rate = dto.Bb056Rate,
                Bb056Datahora = dto.Bb056Datahora,
                Bb056Isactive = true,
                Bb056Issmsenviadoprof = dto.Bb056Issmsenviadoprof,
                Bb056Issmsenviadocliente = dto.Bb056Issmsenviadocliente,
                Bb056Dtsmsprof = dto.Bb056Dtsmsprof,
                Bb056Dtsmscliente = dto.Bb056Dtsmscliente,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB056 ToDtoGet(this CSICP_Bb056 entity)
        {
            return new Dto_GetBB056
            {
                TenantId = entity.TenantId,
                Bb056Id = entity.Bb056Id,
                Bb056Profid = entity.Bb056Profid,
                Bb056Contaid = entity.Bb056Contaid,
                Bb056Mensagem = entity.Bb056Mensagem,
                Bb056Rate = entity.Bb056Rate,
                Bb056Datahora = entity.Bb056Datahora,
                Bb056Isactive = entity.Bb056Isactive,
                Bb056Issmsenviadoprof = entity.Bb056Issmsenviadoprof,
                Bb056Issmsenviadocliente = entity.Bb056Issmsenviadocliente,
                Bb056Dtsmsprof = entity.Bb056Dtsmsprof,
                Bb056Dtsmscliente = entity.Bb056Dtsmscliente,
                NavBB012 = entity.NavBB012?.ToDtoBB012Simples(),
            };
        }
    }
}


using CSBS101._82Application.Dto.BB00X.BB06X.BB061;
using CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB060;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB061
{
    public static class BB061ExtensionMethods
    {
        public static CSICP_Bb061 ToEntity(this Dto_CreateUpdateBB061 dto)
        {
            var entity = new CSICP_Bb061
            {
                Bb060Convenioid = dto.Bb060Convenioid,
                Bb061Tipoassid = dto.Bb061Tipoassid,
                Bb012Contaid = dto.Bb012Contaid,
                Bb061Dependenteid = dto.Bb061Dependenteid,
                Bb061Valor = dto.Bb061Valor,
                Bb061Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB061 ToDtoGet(this CSICP_Bb061 entity)
        {
            return new Dto_GetBB061
            {
                Bb061Id = entity.Bb061Id,
                Bb060Convenioid = entity.Bb060Convenioid,
                Bb061Tipoassid = entity.Bb061Tipoassid,
                Bb012Contaid = entity.Bb012Contaid,
                Bb061Dependenteid = entity.Bb061Dependenteid,
                Bb061Valor = entity.Bb061Valor,
                Bb061Isactive = entity.Bb061Isactive,
                NavBb060Convenio = entity.NavBb060Convenio?.ToDtoGetExibicao(),
                NavBb061Tipoass = entity.Bb061Tipoass,
                NavBB012 = entity.CSICP_BB012?.ToDtoBB012_Exibicao(),
                NavBB1208 = entity.CSICP_BB01208?.ToDtoGetBB1208()
            };
        }
    }
}


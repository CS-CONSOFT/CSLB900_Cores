using CSBS101._82Application.Dto.AA00X.AA001;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Domain;



namespace CSBS101._82Application.Mapper.AA00X.AA001
{
    public static class AA001ExtensionMethods
    {
        //Entity to DTO GET
        public static Dto_GetAA001 ToDtoGet(this CSICP_AA001 entity)
        {
            return new Dto_GetAA001
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Aa001Filial = entity.Aa001Filial,
                Aa001Identificacao = entity.Aa001Identificacao,
                Aa001Tipo = entity.Aa001Tipo,
                Aa001Conteudo = entity.Aa001Conteudo,
                Aa001Descricao = entity.Aa001Descricao,
                Aa001Filialid = entity.Aa001Filialid,
                Aa001Json = entity.Aa001Json,
                NavFilialBB001 = entity.FilialBB001?.ToDtoGet()
            };
        }
    }
}

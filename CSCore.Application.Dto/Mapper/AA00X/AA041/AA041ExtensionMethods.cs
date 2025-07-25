using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA041
{
    public static class AA041ExtensionMethods
    {
        public static Dto_GetAA041 ToDtoGet(this CSICP_Aa041 entity)
        {
            return new Dto_GetAA041
            {
                TenantId = entity.TenantId,
                Aa041Id = entity.Aa041Id,
                NavAa041Tabsped = entity.Aa041Tabsped,
                Aa041Codigo = entity.Aa041Codigo,
                Aa041Descricao = entity.Aa041Descricao,
                Aa041Dfinal = entity.Aa041Dfinal,
                Aa041Dinicio = entity.Aa041Dinicio,
                Aa041TabspedId = entity.Aa041TabspedId
            };
        }


        //Dto Create to Entity
        //Aqui o tenant e o ID nao vao por conta de serem setados na classe de serviço
        public static CSICP_Aa041 ToEntity(this Dto_CreateUpdateAA041 dto)
        {
            var entity = new CSICP_Aa041()
            {
                Aa041Codigo = dto.Aa041Codigo,
                Aa041Descricao = dto.Aa041Descricao,
                Aa041Dfinal = dto.Aa041Dfinal,
                Aa041Dinicio = dto.Aa041Dinicio,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA040
{
    public static class AA040ExtensionMethods
    {
        public static Dto_GetAA040 ToDtoGet(this CSICP_Aa040 entity)
        {
            return new Dto_GetAA040
            {
                TenantId = entity.TenantId,
                Aa040Id = entity.Aa040Id,
                Aa040UforigemId = entity.Aa040UforigemId,
                Aa040UfdestinoId = entity.Aa040UfdestinoId,
                Aa040Paliquota = entity.Aa040Paliquota
            };
        }


        //Dto Create to Entity
        //Aqui o tenant e o ID nao vao por conta de serem setados na classe de serviço
        public static CSICP_Aa040 ToEntity(this Dto_CreateUpdateAA040 dto)
        {
            var entity = new CSICP_Aa040()
            {
                Aa040UforigemId = dto.Aa040UforigemId,
                Aa040UfdestinoId = dto.Aa040UfdestinoId,
                Aa040Paliquota = dto.Aa040Paliquota
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA029
{
    public static class AA029ExtensionMethods
    {
        public static Dto_GetAA029 ToDtoGet(this CSICP_AA029 entity)
        {
            return new Dto_GetAA029
            {
                Aa029Id = entity.Aa029Id,
                TenantId = entity.TenantId,
                Aa029Cnae = entity.Aa029Cnae,
                Aa029Descricao = entity.Aa029Descricao,
                Aa029Notaexplicativa = entity.Aa029Notaexplicativa,
                Aa029Isactive = entity.Aa029Isactive
            };
        }


        //Dto Create to Entity
        //Aqui o tenant e o ID nao vao por conta de serem setados na classe de serviço
        public static CSICP_AA029 ToEntity(this Dto_CreateUpdateAA029 dto)
        {
            var entity = new CSICP_AA029()
            {
                Aa029Cnae = dto.Aa029Cnae,
                Aa029Descricao = dto.Aa029Descricao,
                Aa029Notaexplicativa = dto.Aa029Notaexplicativa,
                Aa029Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

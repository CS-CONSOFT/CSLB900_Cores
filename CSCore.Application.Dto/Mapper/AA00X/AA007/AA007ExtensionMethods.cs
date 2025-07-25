using CSBS101._82Application.Dto.AA00X.AA007;
using CSCore.Domain;



namespace CSBS101._82Application.Mapper.AA00X.AA007
{
    public static class AA007ExtensionMethods
    {
        public static Dto_GetAA007 ToDtoGet(this CSICP_Aa007 entity)
        {
            return new Dto_GetAA007
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Aa007Descricao = entity.Aa007Descricao,
                Aa007Modeloemail = entity.Aa007Modeloemail,
                Aa007Tipo = entity.Aa007Tipo,
                Aa007Uso = entity.Aa007Uso,
                Isactive = entity.Isactive
            };

        }

    }
}

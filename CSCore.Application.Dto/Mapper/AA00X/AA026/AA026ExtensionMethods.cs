using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA026
{
    public static class AA026ExtensionMethods
    {
        public static Dto_GetAA026 ToDtoGet(this CSICP_Aa026 entity)
        {
            return new Dto_GetAA026
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa026Codigoregiao = entity.Aa026Codigoregiao,
                Aa026Descricao = entity.Aa026Descricao,
                Aa026Codigoibge = entity.Aa026Codigoibge,
                Aa026ExportRegiaoid = entity.Aa026ExportRegiaoid
            };
        }


        //Dto Create to Entity
        public static CSICP_Aa026 ToEntity(this Dto_CreateUpdateAA026 dto)
        {
            var entity = new CSICP_Aa026()
            {
                Aa026Codigoregiao = dto.Aa026Codigoregiao,
                Aa026Descricao = dto.Aa026Descricao,
                Aa026Codigoibge = dto.Aa026Codigoibge,
                Aa026ExportRegiaoid = dto.Aa026ExportRegiaoid
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

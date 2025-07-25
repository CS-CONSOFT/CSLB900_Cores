using CSBS101._82Application.Dto.AA00X.AA006;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Mapper.AA00X.AA006;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;



namespace CSBS101.C82Application.Mapper.AA00X.AA006
{
    public static class AA006ExtensionMethods
    {
        //Entity to DTO GET
        public static Dto_GetAA006 ToDtoGet(this CSICP_AA006 entity)
        {
            return new Dto_GetAA006
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Aa006Filial = entity.Aa006Filial,
                Aa006Arquivo = entity.Aa006Arquivo,
                Aa006Ci = entity.Aa006Ci,
                Aa006Filialid = entity.Aa006Filialid,
                Aa006Dataultcaptura = entity.Aa006Dataultcaptura,
                Aa006Circular = entity.Aa006Circular,
                Aa006Maxcircular = entity.Aa006Maxcircular,
                //NavAa006CircularNavigation = entity.Aa006CircularNavigation,
                NavFilialBB001 = entity.FilialBB001?.ToDtoGet(),
            };
        }


        //Dto Create to Entity
        public static CSICP_AA006 ToEntity(this Dto_CreateUpdateAA006 dto)
        {
            var entity = new CSICP_AA006()
            {
                Aa006Filial = dto.Aa006Filial,
                Aa006Arquivo = dto.Aa006Arquivo,
                Aa006Ci = dto.Aa006Ci,
                Aa006Filialid = dto.Aa006Filialid,
                Aa006Dataultcaptura = dto.Aa006Dataultcaptura.ConverteStringVaziaParaDataNula(),
                Aa006Circular = dto.Aa006Circular,
                Aa006Maxcircular = dto.Aa006Maxcircular
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

using CSBS101._82Application.Dto.AA00X;
using CSBS101._82Application.Mapper.AA00X.AA028;
using CSBS101.C82Application.Dto.AA00X.AA024;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA025
{
    public static class AA024ExtensionMethods
    {
        public static Dto_GetAA024 ToDtoGet(this CSICP_Aa024 entity)
        {
            return new Dto_GetAA024
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa024NomeUdh = entity.Aa024NomeUdh,
                Aa028Id = entity.Aa028Id,
                Aa024IdhmR = entity.Aa024IdhmR,
                Aa024Ano = entity.Aa024Ano,
                Aa027Id = entity.Aa027Id,
                NavAA028 = entity.NavAA028?.ToDtoGet(),
            };
        }


        //Dto Create to Entity
        public static CSICP_Aa024 ToEntity(this Dto_CreateUpdateAA024 dto)
        {
            var entity = new CSICP_Aa024()
            {
                Aa024NomeUdh = dto.Aa024NomeUdh,
                Aa028Id = dto.Aa028Id,
                Aa024IdhmR = dto.Aa024IdhmR,
                Aa024Ano = dto.Aa024Ano,
                Aa027Id = dto.Aa027Id,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

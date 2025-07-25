using CSBS101._82Application.Dto.BB00X.BB020;
using CSBS101._82Application.Mapper.BB00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB020ExtensionMethods
    {
        public static CSICP_Bb020 ToEntity(this Dto_CreateUpdateBB020 dto)
        {
            var entity = new CSICP_Bb020
            {
                Empresaid = dto.Empresaid,
                Bb019Id = dto.Bb019Id,
                Bb008Condicaodepagamentoid = dto.Bb008Condicaodepagamentoid,
                Bb020Tcobcartao = dto.Bb020Tcobcartao,
                Bb020Fpagtoid = dto.Bb020Fpagtoid

            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB020 ToDtoGet(this CSICP_Bb020 entity)
        {
            return new Dto_GetBB020
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Empresaid = entity.Empresaid,
                Bb019Id = entity.Bb019Id,
                Bb008Condicaodepagamentoid = entity.Bb008Condicaodepagamentoid,
                Bb020Tcobcartao = entity.Bb020Tcobcartao,
                Bb020Fpagtoid = entity.Bb020Fpagtoid,
                NavBb008Condicaodepagamento = entity.Bb008Condicaodepagamento?.ToDtoGetSemFatores(),
                //NavBb019 = entity.Bb019?.ToDtoGet(),
                NavBb020Fpagto = entity.Bb020Fpagto?.ToDtoGet()
            };
        }
    }
}

using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021;
using CSCore.Application.Dto.Mapper.Rebanho.RR001;
using CSCore.Application.Dto.Mapper.Rebanho.RR020;
using CSCore.Application.Dto.Mapper.Rebanho.RR022;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR021
{
    public static class RR021Mapper
    {
        public static DtoGetRR021 ToDtoGetRR021(this OsusrTo3CsicpRr021 entity)
        {
            return new DtoGetRR021
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr021Loteid = entity.Rr021Loteid,
                Rr021Animalid = entity.Rr021Animalid,
                Rr021Dtregistro = entity.Rr021Dtregistro,

                // Navegações
                NavRR001Animal = entity.NavRR001Animal_RR021?.ToDtoGetRR001(),
                //NavRR020RegLote = entity.NavRR020RegLote_RR021?.ToDtoGetRR020Padrao()
            };
        }

        public static DtoGetRR021Padrao ToDtoGetRR021Padrao(this OsusrTo3CsicpRr021 entity)
        {
            return new DtoGetRR021Padrao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr021Loteid = entity.Rr021Loteid,
                Rr021Animalid = entity.Rr021Animalid,
                Rr021Dtregistro = entity.Rr021Dtregistro
            };
        }

        public static DtoGetRR021_ComRR001eRR022 ToDtoGetRR021ComRR001eRR022(this OsusrTo3CsicpRr021 entity)
        {
            return new DtoGetRR021_ComRR001eRR022
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr021Loteid = entity.Rr021Loteid,
                Rr021Animalid = entity.Rr021Animalid,
                Rr021Dtregistro = entity.Rr021Dtregistro,

                // Navegações
                NavRR001Animal = entity.NavRR001Animal_RR021?.ToDtoGetRR001Padrao(),
                NavRR022ControlePeso = entity.NavRR022ControlePeso_RR021?.ToDtoGetRR022Padrao()
            };
        }
    }
}
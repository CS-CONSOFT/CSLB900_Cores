using CSCore.Application.Dto.Dtos.Basico_AA.AA1XX;
using CSCore.Application.Dto.Dtos.Basico_AA.AA1XX.AA144;
using CSCore.Domain.CS_Models.CSICP_AA;

namespace CSCore.Application.Dto.Mapper.AA00X.AA144
{
    public static class AA144Mapper
    {
        public static DtoGetAA144 ToDtoGetAA144(this OsusrE9aCsicpAa144 entity)
        {
            return new DtoGetAA144
            {
                Id = entity.Id,
                CstibsCbs = entity.CstibsCbs,
                DescricaocstibsCbs = entity.DescricaocstibsCbs,
                Cclasstrib = entity.Cclasstrib,
                Descricaocclasstrib = entity.Descricaocclasstrib,
                Isactive = entity.Isactive
            };
        }
    }
}
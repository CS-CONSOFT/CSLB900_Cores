using CSCore.Application.Dto.Dtos.Basico_AA.AA1XX.AA143;
using CSCore.Domain.CS_Models.CSICP_AA;


namespace CSCore.Application.Dto.Mapper.AA00X.AA143
{
    public static class AA143Mapper
    {
        public static DtoGetAA143 ToDtoGetAA143(this CSICP_AA143 entity)
        {
            return new DtoGetAA143
            {
                Id = entity.Id,
                Aa043Artigo = entity.Aa043Artigo,
                Aa043LcRedacao = entity.Aa043LcRedacao,
                Aa043Ec = entity.Aa043Ec
            };

        }
    }
}

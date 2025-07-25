

using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSCore.Domain;

namespace CSBS101._82Application.Mapper.BB00X.BB012
{
    public static class BB012OExtensionMethods
    {
        public static CSICP_BB012o ToEntity(this Dto_LinkBB012O dto)
        {
            return new CSICP_BB012o
            {
                Bb012Id = dto.Bb012Id,
                Bb012oCodigo = dto.Bb012oCodigo,
                Bb012oRetem = dto.Bb012oRetem,
                Bb012oPercentual = dto.Bb012oPercentual,
                Bb012oImpostoId = dto.Bb012oImpostoId,
            };
        }
    }
}

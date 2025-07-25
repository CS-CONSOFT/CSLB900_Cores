using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSCore.Domain;

namespace CSBS101._82Application.Mapper.BB00X.BB012
{
    public static class BB01207ExtensionMethods
    {
        public static CSICP_BB01207 ToEntity(this Dto_LinkBB01207 dto)
        {
            return new CSICP_BB01207
            {
                Bb012TipoRegMembroconveni = dto.Bb012TipoRegMembroconveni,
                Bb012Id = dto.Bb012Id,
                Bb012Membroid = dto.Bb012Membroid,
                Bb01207IsActive = true,
            };
        }
    }
}

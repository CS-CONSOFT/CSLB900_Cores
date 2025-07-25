using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSCore.Domain;

namespace CSBS101._82Application.Mapper.BB00X.BB012
{
    public static class BB01203ExtensionMethods
    {
        public static CSICP_BB01203 ToEntity(this Dto_LinkBB01203 dto)
        {
            return new CSICP_BB01203
            {
                Bb012Id = dto.Bb012Id,
                Bb012Contatoid = dto.Bb012Contatoid,
                Bb012Candidatoid = dto.Bb012Candidatoid,
                Bb043Campanhaid = dto.Bb043Campanhaid,
                Bb042Potencialid = dto.Bb042Potencialid,
                Bb040Atividadeid = dto.Bb040Atividadeid,
                Bb041Casoid = dto.Bb041Casoid,
                Bb046Concorrenteid = dto.Bb046Concorrenteid,
                Bb012Nota = dto.Bb012Nota,
                Bb01203IsActive = true,
            };
        }
    }
}

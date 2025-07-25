using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSCore.Domain;


namespace CSBS101._82Application.Mapper.BB00X.BB012
{
    public static class BB01208ExtensionMethods
    {
        public static CSICP_BB01208 ToEntity(this Dto_LinkBB01208 dto)
        {
            return new CSICP_BB01208
            {
                Bb012Id = dto.Bb012Id,
                Bb012Contatoid = dto.Bb012Contatoid,
                Bb036Candidatoid = dto.Bb036Candidatoid,
                Bb043Campanhaid = dto.Bb043Campanhaid,
                Bb042Potencialid = dto.Bb042Potencialid,
                Bb040Atividadeid = dto.Bb040Atividadeid,
                Bb041Casoid = dto.Bb041Casoid,
                Concorrenteid = dto.Concorrenteid,
                Bb01208GrauparentId = dto.Bb01208GrauparentId,
                //Bb01208CodgCliente7x = dto.Bb01208CodgCliente7x,
                //Bb01208SeqCliente7x = dto.Bb01208SeqCliente7x,
                //Bb01208OrigemcontatoId = dto.Bb01208OrigemcontatoId,
            };
        }
    }
}

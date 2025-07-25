using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSCore.Domain;

namespace CSBS101._82Application.Mapper.BB00X.BB012
{
    public static class BB012MExtensionMethods
    {
        public static CSICP_BB012m ToEntity(this Dto_LinkBB012M dto)
        {
            return new CSICP_BB012m
            {
                Bb012Id = dto.Bb012Id,
                Bb012Contatoid = dto.Bb012Contatoid,
                Bb012Candidatoid = dto.Bb012Candidatoid,
                Bb043Campanhaid = dto.Bb043Campanhaid,
                Bb042Potencialid = dto.Bb042Potencialid,
                Bb040Atividadeid = dto.Bb040Atividadeid,
                Bb041Casoid = dto.Bb041Casoid,
                Bb012mCodigoCliente = dto.Bb012mCodigoCliente,
                Bb012mDescricao = dto.Bb012mDescricao,
                Bb012mContent = dto.Bb012mContent,
                Bb012mFiletype = dto.Bb012mFiletype,
                Bb012mFilename = dto.Bb012mFilename,
                Bb012mIsActive = true,
                Bb012mTipodoctoid = dto.Bb012mTipodoctoid,
                Bb012mDoctoid = dto.Bb012mDoctoid,
                Bb012mDatadocto = dto.Bb012mDatadocto,
                Bb012mPath = dto.Bb012mPath,
            };
        }
    }

}

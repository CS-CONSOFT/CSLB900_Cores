using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSCore.Domain;

namespace CSBS101._82Application.Mapper.BB00X.BB012
{
    public static class BB012QExtensionMethods
    {
        public static CSICP_BB012q ToEntity(this Dto_LinkBB012Q dto)
        {
            return new CSICP_BB012q
            {
                Bb012Id = dto.Bb012Id,
                Bb012Agencia = dto.Bb012Agencia,
                Bb012Conta = dto.Bb012Conta,
                Bb012Valorfinanciamento = dto.Bb012Valorfinanciamento,
                Bb012Nomegerente = dto.Bb012Nomegerente,
                Bb012Telefone = dto.Bb012Telefone,
                Bb012Faxcelular = dto.Bb012Faxcelular,
                Bb012Homepage = dto.Bb012Homepage,
                Bb012Email = dto.Bb012Email,
                Bb012qIsActive = true,
            };
        }
    }
}

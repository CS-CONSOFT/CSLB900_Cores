using CSBS101._82Application.Dto.BB00X.BB001.BB001Xml;
using CSCore.Domain;



namespace CSBS101._82Application.Mapper.BB00X.BB00X.BB001
{
    public static class XmlExtensionMethods
    {
        public static CSICP_BB001_AXML ToEntity(this Dto_LinkXml dto, int tenant)
        {
            return new CSICP_BB001_AXML
            {
                TenantId = tenant,
                Bb001aEstabid = dto.Bb001aEstabid,
                Bb001aNome = dto.Bb001aNome,
                Bb001aEmail = dto.Bb001aEmail,
                Bb001aTelefone = dto.Bb001aTelefone,
                Bb001aCpfcnpj = dto.Bb001aCpfcnpj,
                Bb001aIscpf = dto.Bb001aIscpf,
            };
        }

        public static Dto_GetXmlFromBB001 ToDtoGet(this CSICP_BB001_AXML entity)
        {
            return new Dto_GetXmlFromBB001
            {
                TenantId = entity.TenantId,
                Bb001aId = entity.Bb001aId,
                Bb001aEstabid = entity.Bb001aEstabid,
                Bb001aNome = entity.Bb001aNome,
                Bb001aEmail = entity.Bb001aEmail,
                Bb001aTelefone = entity.Bb001aTelefone,
                Bb001aCpfcnpj = entity.Bb001aCpfcnpj,
                Bb001aIscpf = entity.Bb001aIscpf,
            };
        }
    }
}

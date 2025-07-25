using CSBS101._82Application.Dto.BB00X.BB011;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB011ExtensionMethods
    {
        public static CSICP_Bb011 ToEntity(this Dto_CreateUpdateBB011 dto)
        {
            var entity = new CSICP_Bb011
            {
                Bb011Codigo = dto.Bb011Codigo,
                Bb011Atividade = dto.Bb011Atividade,
                Bb011IsActive = true

            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB011 ToDtoGet(this CSICP_Bb011 entity)
        {
            Dto_GetBB011 dto = new();
            if (entity != null)
            {
                dto.Id = entity.Id is not null ? entity.Id : "";
                dto.TenantId = entity.TenantId;
                dto.Bb011Codigo = entity.Bb011Codigo;
                dto.Bb011Atividade = entity.Bb011Atividade;
                dto.Bb011IsActive = entity.Bb011IsActive;
            }
            return dto;
        }
    }
}

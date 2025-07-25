
using CSBS101._82Application.Dto.BB00X.BB009;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.BB00X.BB009
{
    public static class BB009ExtensionMethods
    {
        public static CSICP_Bb009 ToEntity(this Dto_CreateUpdateBB009 dto)
        {
            var entity = new CSICP_Bb009
            {
                Bb009Filial = dto.Bb009Filial,
                Bb009Codigo = dto.Bb009Codigo,
                Bb009Tipocobranca = dto.Bb009Tipocobranca,
                Empresaid = dto.Empresaid,
                Bb009Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB009 ToDtoGet(this CSICP_Bb009 entity)
        {
            return new Dto_GetBB009
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb009Filial = entity.Bb009Filial,
                Bb009Codigo = entity.Bb009Codigo,
                Bb009Tipocobranca = entity.Bb009Tipocobranca,
                Empresaid = entity.Empresaid,
                Bb009Isactive = entity.Bb009Isactive
            };
        }
        public static Dto_GetBB009_Exibicao ToDtoGetBB009_Exibicao(this CSICP_Bb009 entity)
        {
            return new Dto_GetBB009_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb009Codigo = entity.Bb009Codigo,
                Bb009Tipocobranca = entity.Bb009Tipocobranca,
            };
        }

    }
}

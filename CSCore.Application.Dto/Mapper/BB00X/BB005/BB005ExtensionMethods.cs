using CSBS101._82Application.Dto.BB00X.BB005;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.BB00X
{
    public static class BB005ExtensionMethods
    {
        public static CSICP_Bb005 ToEntity(this Dto_CreateUpdateBB005 dto)
        {
            var entity = new CSICP_Bb005
            {
                Bb005Filial = dto.Bb005Filial,
                Bb005Codigo = dto.Bb005Codigo,
                Bb005Nomeccusto = dto.Bb005Nomeccusto,
                Bb005Colunaimpressao = dto.Bb005Colunaimpressao,
                Empresaid = dto.Empresaid,
                Bb005Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
        public static Dto_GetBB005 ToDtoGet(this CSICP_Bb005 entity)
        {
            return new Dto_GetBB005
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb005Filial = entity.Bb005Filial,
                Bb005Codigo = entity.Bb005Codigo,
                Bb005Nomeccusto = entity.Bb005Nomeccusto,
                Bb005Colunaimpressao = entity.Bb005Colunaimpressao,
                Empresaid = entity.Empresaid,
                Bb005Isactive = entity.Bb005Isactive,
            };
        }
        public static Dto_GetBB005_Exibicao ToDtoGetBB005_Exibicao(this CSICP_Bb005 entity)
        {
            return new Dto_GetBB005_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb005Codigo = entity.Bb005Codigo,
                Bb005Nomeccusto = entity.Bb005Nomeccusto
            };
        }
        
    }
}

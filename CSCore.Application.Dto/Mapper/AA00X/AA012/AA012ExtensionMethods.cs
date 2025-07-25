using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain.CS_Models.CSICP_AA;

namespace CSBS101._82Application.Mapper.AA00X.AA012
{
    public static class AA012ExtensionMethods
    {
        public static Dto_GetAA012 ToDtoGet(this CSICP_Aa012 entity)
        {
            return new Dto_GetAA012
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Aa012Tabela = entity.Aa012Tabela,
                Aa012Codigo = entity.Aa012Codigo,
                Aa012Descricao = entity.Aa012Descricao,
                Aa012DescricaoGrande = entity.Aa012DescricaoGrande
            };
        }


        //Dto transformado em uma classe de entidade
        public static CSICP_Aa012 ToEntity(this Dto_CreateUpdateAA012 dto)
        {
            return new CSICP_Aa012()
            {
                Aa012Tabela = dto.Aa012Tabela,
                Aa012Codigo = dto.Aa012Codigo,
                Aa012Descricao = dto.Aa012Descricao,
                Aa012DescricaoGrande = dto.Aa012DescricaoGrande
            };
        }
    }
}

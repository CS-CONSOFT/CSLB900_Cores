using CSBS101._82Application.Dto.AA00X.AA013;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.AA00X.AA013
{
    public static class AA013ExtensionMethods
    {
        public static Dto_GetAA013 ToDtoGet(this CSICP_Aa013 entity)
        {
            return new Dto_GetAA013
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Aa013Filial = entity.Aa013Filial,
                Aa013Serie = entity.Aa013Serie,
                Aa013Numero = entity.Aa013Numero,
                Aa013DataValidade = entity.Aa013DataValidade,
                Aa013Filialid = entity.Aa013Filialid,
                Aa013ModId = entity.Aa013ModId,
                Aa013Isusocontigencia = entity.Aa013Isusocontigencia,
                NavAa013Mod = entity.Aa013Mod,
                NavFilial = entity.Filial != null ? new Dto_GetBB001Simples
                {
                    Id = entity.Filial.Id,
                    Bb001Codigoempresa = entity.Filial.Bb001Codigoempresa,
                    Bb001Razaosocial = entity.Filial.Bb001Razaosocial,
                    Bb001Nomefantasia = entity.Filial.Bb001Nomefantasia
                } : null
            };
        }


        //Dto Create to Entity
        public static CSICP_Aa013 ToEntity(this Dto_CreateUpdateAA013 dto)
        {
            var entity = new CSICP_Aa013()
            {
                Aa013Filial = dto.Aa013Filial,
                Aa013Serie = dto.Aa013Serie,
                Aa013Numero = dto.Aa013Numero,
                Aa013DataValidade = dto.Aa013DataValidade,
                Aa013Filialid = dto.Aa013Filialid,
                Aa013ModId = dto.Aa013ModId,
                Aa013Isusocontigencia = dto.Aa013Isusocontigencia
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}

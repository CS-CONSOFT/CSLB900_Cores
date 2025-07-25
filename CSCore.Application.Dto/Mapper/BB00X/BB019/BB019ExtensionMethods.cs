using CSBS101._82Application.Dto.BB00X.BB019;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB019ExtensionMethods
    {
        public static CSICP_Bb019 ToEntity(this Dto_CreateUpdateBB019 dto)
        {
            var entity = new CSICP_Bb019
            {
                Empresaid = dto.Empresaid,
                Bb019Filial = dto.Bb019Filial,
                Bb019Codigo = dto.Bb019Codigo,
                Bb019Administradora = dto.Bb019Administradora,
                Bb019TaxaDeCobranca = dto.Bb019TaxaDeCobranca,
                Bb019Venctopadrao = dto.Bb019Venctopadrao,
                Bb019Contaid = dto.Bb019Contaid,
                Bb019Usafatoracresc = dto.Bb019Usafatoracresc,
                Bb019Finanproprio = dto.Bb019Finanproprio,
                Bb019Tac = dto.Bb019Tac,
                Bb019Email = dto.Bb019Email,
                Bb019Homepage = dto.Bb019Homepage,
                Bb019TipofinancId = dto.Bb019TipofinancId,
                Bb019Isactive = true,
                Bb019Dialimitevenctopadrao = dto.Bb019Dialimitevenctopadrao,
                Bb019Codigocredenciadora = dto.Bb019Codigocredenciadora,
                Bb019LogoAdm = dto.Bb019LogoAdm,
                Bb019Filename = dto.Bb019Filename,
                Bb019Path = dto.Bb019Path
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB019 ToDtoGet(this CSICP_Bb019 entity)
        {
            return new Dto_GetBB019
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Empresaid = entity.Empresaid,
                Bb019Filial = entity.Bb019Filial,
                Bb019Codigo = entity.Bb019Codigo,
                Bb019Administradora = entity.Bb019Administradora,
                Bb019TaxaDeCobranca = entity.Bb019TaxaDeCobranca,
                Bb019Venctopadrao = entity.Bb019Venctopadrao,
                Bb019Contaid = entity.Bb019Contaid,
                Bb019Usafatoracresc = entity.Bb019Usafatoracresc,
                Bb019Finanproprio = entity.Bb019Finanproprio,
                Bb019Tac = entity.Bb019Tac,
                Bb019Email = entity.Bb019Email,
                Bb019Homepage = entity.Bb019Homepage,
                Bb019TipofinancId = entity.Bb019TipofinancId,
                Bb019Isactive = entity.Bb019Isactive,
                Bb019Dialimitevenctopadrao = entity.Bb019Dialimitevenctopadrao,
                Bb019Codigocredenciadora = entity.Bb019Codigocredenciadora,
                Bb019LogoAdm = entity.Bb019LogoAdm,
                Bb019Filename = entity.Bb019Filename,
                Bb019Path = entity.Bb019Path,
                NavCSICP_Bb019Tipo = entity.NavCSICP_Bb019Tipo
            };
        }

        public static Dto_GetBB019_Exibicao ToDtoGetBB019Exibicao(this CSICP_Bb019 entity)
        {
            return new Dto_GetBB019_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb019Codigo = entity.Bb019Codigo,
                Bb019Administradora = entity.Bb019Administradora
            };
        }
    }
}

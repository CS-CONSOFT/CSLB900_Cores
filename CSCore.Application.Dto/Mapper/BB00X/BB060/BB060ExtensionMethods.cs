

using CSBS101._82Application.Dto.BB00X.BB06X.BB060;
using CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB067;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB009;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB060
{
    public static class BB060ExtensionMethods
    {
        public static CSICP_Bb060 ToEntity(this Dto_CreateUpdateBB060 dto)
        {
            var entity = new CSICP_Bb060
            {
                Bb060Codigo = dto.Bb060Codigo,
                Bb060Descricao = dto.Bb060Descricao,
                Bb060Vbase = dto.Bb060Vbase,
                Bb060Ccustoid = dto.Bb060Ccustoid,
                Bb060Usuarioproprieid = dto.Bb060Usuarioproprieid,
                Bb060Agcobradorid = dto.Bb060Agcobradorid,
                Bb060Responsavelid = dto.Bb060Responsavelid,
                Bb060Condicaoid = dto.Bb060Condicaoid,
                Bb060Tipocobrancaid = dto.Bb060Tipocobrancaid,
                Bb060Usuarioinc = dto.Bb060Usuarioinc,
                Bb060Usuarioalt = dto.Bb060Usuarioalt,
                Bb060Dthrinc = dto.Bb060Dthrinc.ConverteStringVaziaParaDataNula(),
                Bb060Dthralt = dto.Bb060Dthralt.ConverteStringVaziaParaDataNula(),
                Bb060Especieid = dto.Bb060Especieid,
                Bb060FpagtoId = dto.Bb060FpagtoId,
                Bb060Isactive = true,
                Bb060Convmasterid = dto.Bb060Convmasterid
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB060 ToDtoGet(this CSICP_Bb060 entity)
        {
            return new Dto_GetBB060
            {
                TenantId = entity.TenantId,
                Bb060Convenioid = entity.Bb060Convenioid,
                Bb060Codigo = entity.Bb060Codigo,
                Bb060Descricao = entity.Bb060Descricao,
                Bb060Vbase = entity.Bb060Vbase,
                Bb060Ccustoid = entity.Bb060Ccustoid,
                Bb060Usuarioproprieid = entity.Bb060Usuarioproprieid,
                Bb060Agcobradorid = entity.Bb060Agcobradorid,
                Bb060Responsavelid = entity.Bb060Responsavelid,
                Bb060Condicaoid = entity.Bb060Condicaoid,
                Bb060Tipocobrancaid = entity.Bb060Tipocobrancaid,
                Bb060Usuarioinc = entity.Bb060Usuarioinc,
                Bb060Usuarioalt = entity.Bb060Usuarioalt,
                Bb060Dthrinc = entity.Bb060Dthrinc,
                Bb060Dthralt = entity.Bb060Dthralt,
                Bb060Especieid = entity.Bb060Especieid,
                Bb060FpagtoId = entity.Bb060FpagtoId,
                Bb060Isactive = entity.Bb060Isactive,
                Bb060Convmasterid = entity.Bb060Convmasterid,
                NavBb060Agcobrador = entity.Bb060Agcobrador?.ToDtoGet(),
                NavBb060Ccusto = entity.Bb060Ccusto?.ToDtoGet(),
                NavBb060Condicao = entity.Bb060Condicao?.ToDtoGet(),
                NavBb060Convmaster = entity.Bb060Convmaster?.ToDtoGet(),
                NavBb060Responsavel = entity.Bb060Responsavel?.ToDtoGet(),
                NavBb060Tipocobranca = entity.Bb060Tipocobranca?.ToDtoGet(),
                NavFormaPagamento = entity.FormaPagamento?.ToDtoGet()
            };
        }

        public static Dto_GetBB060_Exibicao ToDtoGetExibicao(this CSICP_Bb060 entity)
        {
            return new Dto_GetBB060_Exibicao
            {
                TenantId = entity.TenantId,
                Bb060Convenioid = entity.Bb060Convenioid,
                Bb060Codigo = entity.Bb060Codigo,
                Bb060Descricao = entity.Bb060Descricao,
                Bb060Vbase = entity.Bb060Vbase,

            };
        }
    }
}

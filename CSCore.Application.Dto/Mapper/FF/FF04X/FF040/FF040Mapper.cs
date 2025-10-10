using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB009;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF040;
using CSCore.Application.Dto.Mapper.FF.FF00X;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF04X.FF040
{
    public static class FF040Mapper
    {
        public static DtoGetFF040 ToDtoGet(this CSICP_FF040 entity)
        {
            return new DtoGetFF040
            {
                TenantId = entity.TenantId,
                Ff040Id = entity.Ff040Id,
                Ff040Empresaid = entity.Ff040Empresaid,
                Ff040Tiporegistro = entity.Ff040Tiporegistro,
                Ff040DataMovimento = entity.Ff040DataMovimento,
                Ff040ContaId = entity.Ff040ContaId,
                Ff040CcustoId = entity.Ff040CcustoId,
                Ff040EspecieId = entity.Ff040EspecieId,
                Ff040AgcobradorId = entity.Ff040AgcobradorId,
                Ff040ResponsavelId = entity.Ff040ResponsavelId,
                Ff040Tipocobrancaid = entity.Ff040Tipocobrancaid,
                Ff040Vtransacao = entity.Ff040Vtransacao,
                Ff040Texto = entity.Ff040Texto,
                Ff040UsuarioProprId = entity.Ff040UsuarioProprId,
                Ff040Situacaoid = entity.Ff040Situacaoid,
                Ff040Protocolnumber = entity.Ff040Protocolnumber,
                Ff040Dbasevencto = entity.Ff040Dbasevencto,
                Ff040Isprovisao = entity.Ff040Isprovisao,
                Ff040CtbIscontabilizadoid = entity.Ff040CtbIscontabilizadoid,
                Ff040CtbUsuarioid = entity.Ff040CtbUsuarioid,
                Ff040CtbDtregistro = entity.Ff040CtbDtregistro,
                Ff040CtbIsestornadoid = entity.Ff040CtbIsestornadoid,
                Ff040CtbEstusuarioid = entity.Ff040CtbEstusuarioid,
                Ff040CtbEstdtreg = entity.Ff040CtbEstdtreg,
                Ff040CtbIdlancto = entity.Ff040CtbIdlancto,
                Ff040CtbMsg = entity.Ff040CtbMsg,
                Ff040CtlIscontabilizadoid = entity.Ff040CtlIscontabilizadoid,
                Ff040CtlUsuarioid = entity.Ff040CtlUsuarioid,
                Ff040CtlDtregistro = entity.Ff040CtlDtregistro,
                Ff040CtlIsestornadoid = entity.Ff040CtlIsestornadoid,
                Ff040CtlEstusuarioid = entity.Ff040CtlEstusuarioid,
                Ff040CtlEstdtreg = entity.Ff040CtlEstdtreg,
                Ff040CtlIdlancto = entity.Ff040CtlIdlancto,
                Ff040CtlMsg = entity.Ff040CtlMsg,
                NavBB005CCustoID = entity.NavBB005CCustoID?.ToDtoGetBB005_Exibicao(),
                NavBB006AgCobradorID = entity.NavBB006AgCobradorID?.ToDtoGetExibicao(),
                NavBB007ResponsavelID = entity.NavBB007ResponsavelID?.ToDtoGetSimples(),
                NavBB009TipoCobrancaID = entity.NavBB009TipoCobrancaID?.ToDtoGetBB009_Exibicao(),
                NavBB012ContaID = entity.NavBB012ContaID?.ToDtoGetExibSimples(),
                NavFF003EspecieID = entity.NavFF003EspecieID?.ToDtoGetExibicao(),
                NavFF040SituacaoID = entity.NavFF040SituacaoID,
                NavSY001UsuarioPropID = entity.NavSY001UsuarioPropID?.ToDtoGetSimples(),
            };
        }

        public static DtoGetCopyFF040 ToDtoGetCopyFF040(this CSICP_FF040 entity)
        {
            return new DtoGetCopyFF040
            {
                TenantId = entity.TenantId,
                Ff040Empresaid = entity.Ff040Empresaid,
                Ff040Tiporegistro = entity.Ff040Tiporegistro,
                Ff040DataMovimento = entity.Ff040DataMovimento,
                Ff040ContaId = entity.Ff040ContaId,
                Ff040CcustoId = entity.Ff040CcustoId,
                Ff040EspecieId = entity.Ff040EspecieId,
                Ff040AgcobradorId = entity.Ff040AgcobradorId,
                Ff040ResponsavelId = entity.Ff040ResponsavelId,
                Ff040Tipocobrancaid = entity.Ff040Tipocobrancaid,
                Ff040Vtransacao = entity.Ff040Vtransacao,
                Ff040Texto = entity.Ff040Texto,
                Ff040UsuarioProprId = entity.Ff040UsuarioProprId,
                Ff040Situacaoid = entity.Ff040Situacaoid,
                Ff040Protocolnumber = entity.Ff040Protocolnumber,
                Ff040Dbasevencto = entity.Ff040Dbasevencto,
                Ff040Isprovisao = entity.Ff040Isprovisao,
            };
        }
    }
}
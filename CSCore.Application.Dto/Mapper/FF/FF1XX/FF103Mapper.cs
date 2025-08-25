using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF103;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF103Mapper
    {
        public static DtoGetFF103 ToDtoGet(this CSICP_FF103 ff103)
        {
            return new DtoGetFF103
            {
                TenantId = ff103.TenantId,
                Id = ff103.Id,
                Ff102Id = ff103.Ff102Id,
                Ff103Filialid = ff103.Ff103Filialid,
                Ff103Filial = ff103.Ff103Filial,
                Ff103Pfx = ff103.Ff103Pfx,
                Ff103NoTitulo = ff103.Ff103NoTitulo,
                Ff103Sfx = ff103.Ff103Sfx,
                Ff103SeqBaixa = ff103.Ff103SeqBaixa,
                Ff103DataBaixa = ff103.Ff103DataBaixa,
                Ff103DtaBaixaAnt = ff103.Ff103DtaBaixaAnt,
                Ff103DataCredito = ff103.Ff103DataCredito,
                Ff103Agcobradorid = ff103.Ff103Agcobradorid,
                Ff103Banco = ff103.Ff103Banco,
                Ff103ValorJuros = ff103.Ff103ValorJuros,
                Ff103ValorDesconto = ff103.Ff103ValorDesconto,
                Ff103ValorPago = ff103.Ff103ValorPago,
                Ff103ValorMulta = ff103.Ff103ValorMulta,
                Ff103ValorTarifas = ff103.Ff103ValorTarifas,
                Ff103Atraso = ff103.Ff103Atraso,
                Ff103Historico = ff103.Ff103Historico,
                Ff103BaixadoAuto = ff103.Ff103BaixadoAuto,
                Ff103Usuarioproprid = ff103.Ff103Usuarioproprid,
                Ff103Cobradorid = ff103.Ff103Cobradorid,
                Ff103ResponsavelCob = ff103.Ff103ResponsavelCob,
                Ff103NoPdv = ff103.Ff103NoPdv,
                Ff103CiPdv = ff103.Ff103CiPdv,
                Ff103DespesaCartorio = ff103.Ff103DespesaCartorio,
                Ff103BaixaTesouraria = ff103.Ff103BaixaTesouraria,
                Ff103Lctoctbbxid = ff103.Ff103Lctoctbbxid,
                Ff103ObjBxLabel = ff103.Ff103ObjBxLabel,
                Ff103ObjBxId = ff103.Ff103ObjBxId,
                Ff103Baixado = ff103.Ff103Baixado,
                Ff103Estornado = ff103.Ff103Estornado,
                Ff103Cancelado = ff103.Ff103Cancelado,
                Ff103Dataregistro = ff103.Ff103Dataregistro,
                Ff103Tpbaixaid = ff103.Ff103Tpbaixaid,
                Ff103Flagregistro = ff103.Ff103Flagregistro,
                Ff103MsgId = ff103.Ff103MsgId,
                Ff103CtbIscontabilizadoid = ff103.Ff103CtbIscontabilizadoid,
                Ff103CtbUsuarioid = ff103.Ff103CtbUsuarioid,
                Ff103CtbDtregistro = ff103.Ff103CtbDtregistro,
                Ff103CtbIsestornadoid = ff103.Ff103CtbIsestornadoid,
                Ff103CtbEstusuarioid = ff103.Ff103CtbEstusuarioid,
                Ff103CtbEstdtreg = ff103.Ff103CtbEstdtreg,
                Ff103CtbIdlancto = ff103.Ff103CtbIdlancto,
                Ff103CtbMsg = ff103.Ff103CtbMsg,
                Ff103FpagtoId = ff103.Ff103FpagtoId,
                Ff103VlCorrmonetaria = ff103.Ff103VlCorrmonetaria,
                Ff103VlHonorarios = ff103.Ff103VlHonorarios,
                Ff103CtlIscontabilizadoid = ff103.Ff103CtlIscontabilizadoid,
                Ff103CtlUsuarioid = ff103.Ff103CtlUsuarioid,
                Ff103CtlDtregistro = ff103.Ff103CtlDtregistro,
                Ff103CtlIsestornadoid = ff103.Ff103CtlIsestornadoid,
                Ff103CtlEstusuarioid = ff103.Ff103CtlEstusuarioid,
                Ff103CtlEstdtreg = ff103.Ff103CtlEstdtreg,
                Ff103CtlIdlancto = ff103.Ff103CtlIdlancto,
                Ff103CtlMsg = ff103.Ff103CtlMsg,

            };
        }
    }
}

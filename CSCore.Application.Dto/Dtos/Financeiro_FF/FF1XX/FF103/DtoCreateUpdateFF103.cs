using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF103
{
    public class DtoCreateUpdateFF103 : IConverteParaEntidade<CSICP_FF103>
    {
        public string? Ff102Id { get; set; }

        public string? Ff103Filialid { get; set; }

        public int? Ff103Filial { get; set; }

        public string? Ff103Pfx { get; set; }

        public decimal? Ff103NoTitulo { get; set; }

        public string? Ff103Sfx { get; set; }

        public int? Ff103SeqBaixa { get; set; }

        public DateTime? Ff103DataBaixa { get; set; }

        public DateTime? Ff103DtaBaixaAnt { get; set; }

        public DateTime? Ff103DataCredito { get; set; }

        public string? Ff103Agcobradorid { get; set; }

        public int? Ff103Banco { get; set; }

        public decimal? Ff103ValorJuros { get; set; }

        public decimal? Ff103ValorDesconto { get; set; }

        public decimal? Ff103ValorPago { get; set; }

        public decimal? Ff103ValorMulta { get; set; }

        public decimal? Ff103ValorTarifas { get; set; }

        public int? Ff103Atraso { get; set; }

        public string? Ff103Historico { get; set; }

        public string? Ff103BaixadoAuto { get; set; }

        public string? Ff103Usuarioproprid { get; set; }

        public string? Ff103Cobradorid { get; set; }

        public int? Ff103ResponsavelCob { get; set; }

        public int? Ff103NoPdv { get; set; }

        public decimal? Ff103CiPdv { get; set; }

        public decimal? Ff103DespesaCartorio { get; set; }

        public string? Ff103BaixaTesouraria { get; set; }

        public string? Ff103Lctoctbbxid { get; set; }

        public string? Ff103ObjBxLabel { get; set; }

        public string? Ff103ObjBxId { get; set; }

        public bool? Ff103Baixado { get; set; }

        public bool? Ff103Estornado { get; set; }

        public bool? Ff103Cancelado { get; set; }

        public DateTime? Ff103Dataregistro { get; set; }

        public int? Ff103Tpbaixaid { get; set; }

        public int? Ff103Flagregistro { get; set; }

        public int? Ff103MsgId { get; set; }

        public int? Ff103CtbIscontabilizadoid { get; set; }

        public string? Ff103CtbUsuarioid { get; set; }

        public DateTime? Ff103CtbDtregistro { get; set; }

        public int? Ff103CtbIsestornadoid { get; set; }

        public string? Ff103CtbEstusuarioid { get; set; }

        public DateTime? Ff103CtbEstdtreg { get; set; }

        public long? Ff103CtbIdlancto { get; set; }

        public string? Ff103CtbMsg { get; set; }

        public string? Ff103FpagtoId { get; set; }

        public decimal? Ff103VlCorrmonetaria { get; set; }

        public decimal? Ff103VlHonorarios { get; set; }

        public bool? Ff103CtlIscontabilizadoid { get; set; }

        public string? Ff103CtlUsuarioid { get; set; }

        public DateTime? Ff103CtlDtregistro { get; set; }

        public bool? Ff103CtlIsestornadoid { get; set; }

        public string? Ff103CtlEstusuarioid { get; set; }

        public DateTime? Ff103CtlEstdtreg { get; set; }

        public long? Ff103CtlIdlancto { get; set; }

        public string? Ff103CtlMsg { get; set; }

        public CSICP_FF103 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_FF103
            {
                TenantId = tenant,
                Id = id!,
                Ff102Id = this.Ff102Id,
                Ff103Filialid = this.Ff103Filialid,
                Ff103Filial = this.Ff103Filial,
                Ff103Pfx = this.Ff103Pfx,
                Ff103NoTitulo = this.Ff103NoTitulo,
                Ff103Sfx = this.Ff103Sfx,
                Ff103SeqBaixa = this.Ff103SeqBaixa,
                Ff103DataBaixa = this.Ff103DataBaixa,
                Ff103DtaBaixaAnt = this.Ff103DtaBaixaAnt,
                Ff103DataCredito = this.Ff103DataCredito,
                Ff103Agcobradorid = this.Ff103Agcobradorid,
                Ff103Banco = this.Ff103Banco,
                Ff103ValorJuros = this.Ff103ValorJuros,
                Ff103ValorDesconto = this.Ff103ValorDesconto,
                Ff103ValorPago = this.Ff103ValorPago,
                Ff103ValorMulta = this.Ff103ValorMulta,
                Ff103ValorTarifas = this.Ff103ValorTarifas,
                Ff103Atraso = this.Ff103Atraso,
                Ff103Historico = this.Ff103Historico,
                Ff103BaixadoAuto = this.Ff103BaixadoAuto,
                Ff103Usuarioproprid = this.Ff103Usuarioproprid,
                Ff103Cobradorid = this.Ff103Cobradorid,
                Ff103ResponsavelCob = this.Ff103ResponsavelCob,
                Ff103NoPdv = this.Ff103NoPdv,
                Ff103CiPdv = this.Ff103CiPdv,
                Ff103DespesaCartorio = this.Ff103DespesaCartorio,
                Ff103BaixaTesouraria = this.Ff103BaixaTesouraria,
                Ff103Lctoctbbxid = this.Ff103Lctoctbbxid,
                Ff103ObjBxLabel = this.Ff103ObjBxLabel,
                Ff103ObjBxId = this.Ff103ObjBxId,
                Ff103Baixado = this.Ff103Baixado,
                Ff103Estornado = this.Ff103Estornado,
                Ff103Cancelado = this.Ff103Cancelado,
                Ff103Dataregistro = this.Ff103Dataregistro,
                Ff103Tpbaixaid = this.Ff103Tpbaixaid,
                Ff103Flagregistro = this.Ff103Flagregistro,
                Ff103MsgId = this.Ff103MsgId,
                Ff103CtbIscontabilizadoid = this.Ff103CtbIscontabilizadoid,
                Ff103CtbUsuarioid = this.Ff103CtbUsuarioid,
                Ff103CtbDtregistro = this.Ff103CtbDtregistro,
                Ff103CtbIsestornadoid = this.Ff103CtbIsestornadoid,
                Ff103CtbEstusuarioid = this.Ff103CtbEstusuarioid,
                Ff103CtbEstdtreg = this.Ff103CtbEstdtreg,
                Ff103CtbIdlancto = this.Ff103CtbIdlancto,
                Ff103CtbMsg = this.Ff103CtbMsg,
                Ff103FpagtoId = this.Ff103FpagtoId,
                Ff103VlCorrmonetaria = this.Ff103VlCorrmonetaria,
                Ff103VlHonorarios = this.Ff103VlHonorarios,
                Ff103CtlIscontabilizadoid = this.Ff103CtlIscontabilizadoid,
                Ff103CtlUsuarioid = this.Ff103CtlUsuarioid,
                Ff103CtlDtregistro = this.Ff103CtlDtregistro,
                Ff103CtlIsestornadoid = this.Ff103CtlIsestornadoid,
                Ff103CtlEstusuarioid = this.Ff103CtlEstusuarioid,
                Ff103CtlEstdtreg = this.Ff103CtlEstdtreg,
                Ff103CtlIdlancto = this.Ff103CtlIdlancto,
                Ff103CtlMsg = this.Ff103CtlMsg,
            };
            return entity;
        }
    }
}
using CSBS101._82Application.Dto.BB00X.BB006;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF103
{
    public class DtoGetFF103
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

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

        public bool Ff103Baixado { get; set; }

        public bool Ff103Estornado { get; set; }

        public bool Ff103Cancelado { get; set; }

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

        public bool Ff103CtlIscontabilizadoid { get; set; }

        public string? Ff103CtlUsuarioid { get; set; }

        public DateTime? Ff103CtlDtregistro { get; set; }

        public bool Ff103CtlIsestornadoid { get; set; }

        public string? Ff103CtlEstusuarioid { get; set; }

        public DateTime? Ff103CtlEstdtreg { get; set; }

        public long? Ff103CtlIdlancto { get; set; }

        public string? Ff103CtlMsg { get; set; }

        public DtoGetFF102ParaFF103? NavFF102 { get; set; }
        public Dto_GetBB006_Exibicao? NavBB006 { get; set; }
        public Dto_GetSY001Simples? NavSY001 { get; set; }

    }
}
using FF105Financeiro.C82Application.Dto.GG00X.GG003;
using FF105Financeiro.C82Application.Dto.GG00X.GG008;
using FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008Kdx;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG036
{
    public class DtoGetGG036
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg036Filialid { get; set; }

        public int? Gg036Ordem { get; set; }

        public string? Gg036KardexId { get; set; }

        public decimal? Gg036Codigobarras { get; set; }

        public DateTime? Gg036Dataregistro { get; set; }

        public string? Gg036Saldoid { get; set; }

        public decimal? Gg036QtdEstoque { get; set; }

        public decimal? Gg036Saldoestoque { get; set; }

        public decimal? Gg036Precocusto { get; set; }

        public decimal? Gg036Precocustoreal { get; set; }

        public decimal? Gg036Precocustomedio { get; set; }

        public decimal? Gg036Precovenda { get; set; }

        public bool? Gg036Naoinventariar { get; set; }

        public bool? Gg036Inventariado { get; set; }

        public string? Gg036Mensagem { get; set; }

        public string? Gg036Codbarrasalfa { get; set; }
        public DtoGetGG008? NavCSICP_GG008 { get; set; }
        public DtoGetGG008Kdx? NavCSICP_GG008Kdx { get; set; }
        public DtoGetGG003? NavCSICP_GG003 { get; set; }
    }
}

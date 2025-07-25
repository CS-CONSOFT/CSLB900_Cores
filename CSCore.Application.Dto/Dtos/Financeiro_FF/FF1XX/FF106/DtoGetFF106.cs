using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF106
{
    public class DtoGetFF106
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff106Filialid { get; set; }

        public string? Ff105Id { get; set; }

        public string? Ff102Id { get; set; }

        public bool? Ff106Selecionado { get; set; }

        public string? Ff106Agcobradorid { get; set; }

        public string? Ff106Tipocobrancaid { get; set; }

        public string? Ff106InstCobranca1 { get; set; }

        public string? Ff106InstCobranca2 { get; set; }

        public string? Ff106IdOutroBordero { get; set; }

        public int? Ff106CodgOcorrencia { get; set; }

        public string? Ff106Ocorrencia { get; set; }

        public decimal? Ff106Jurosrecebido { get; set; }

        public decimal? Ff106Multarecebida { get; set; }

        public decimal? Ff106Outrovlrrecebido { get; set; }

        public decimal? Ff106Descconcedido { get; set; }

        public decimal? Ff106Valorpago { get; set; }

        public DateTime? Ff106DataRecto { get; set; }

        public DateTime? Ff106DataCredito { get; set; }

        public string? Nn016IdBxTes { get; set; }

        public DateTime? Ff106DataBxaut { get; set; }

        public DateTime? Ff106DataProtesto { get; set; }

        public int? Ff106Diasprotesto { get; set; }

        public int? Ff106Prazorecto { get; set; }

        public DateTime? Ff106DataLimrecto { get; set; }

        public string? Ff106CodigoErroApi { get; set; }

        public string? Ff106VersaoErroApi { get; set; }

        public string? Ff106MsgErroApi { get; set; }

        public string? Ff106OcorErroApi { get; set; }

        public int? Ff106OcorrenciaApi { get; set; }

        public int? Ff106LiqApi { get; set; }

        public int? Ff106BaixaApi { get; set; }

        public virtual CSICP_FF102? Ff102 { get; set; }

        public virtual CSICP_FF105? Ff105 { get; set; }
    }
}

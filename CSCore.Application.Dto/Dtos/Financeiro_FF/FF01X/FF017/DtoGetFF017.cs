using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF017
{
    public class DtoGetFF017
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Ff017Tiporegistro { get; set; }

        public string? Ff017Filialid { get; set; }

        public int? Ff017Filial { get; set; }

        public DateTime? Ff017DataRenegociacao { get; set; }

        public string? Ff017Especieid { get; set; }

        public string? Ff017Contaid { get; set; }

        public string? Ff017Ccustoid { get; set; }

        public string? Ff017Agcobradorid { get; set; }

        public string? Ff017Usuarioid { get; set; }

        public string? Ff017Condicaoid { get; set; }

        public string? Ff017Tipocobrancaid { get; set; }

        public string? Ff017Contatomadordivid { get; set; }

        public decimal? Ff017PercJuros { get; set; }

        public decimal? Ff017Multa { get; set; }

        public decimal? Ff017TotalTitulos { get; set; }

        public decimal? Ff017TotalAberto { get; set; }

        public decimal? Ff017TotalJuros { get; set; }

        public decimal? Ff017TotalMulta { get; set; }

        public decimal? Ff017TotalDescontos { get; set; }

        public decimal? Ff017Totrenegociado { get; set; }

        public decimal? Ff017ValorEntrada { get; set; }

        public decimal? Ff017PercEntrada { get; set; }

        public bool? Ff017Aberto { get; set; }

        public string? Ff017Protocolnumber { get; set; }

        public decimal? Ff017Pminvlrentrada { get; set; }

        public decimal? Ff017Vminentrada { get; set; }

        public string? Ff017Valecreditoid { get; set; }

        public int? Ff017Statusvcid { get; set; }

        public string? Ff017Formapagtoid { get; set; }
    }
}

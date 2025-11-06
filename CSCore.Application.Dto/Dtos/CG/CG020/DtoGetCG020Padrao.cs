using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG020
{
    public class DtoGetCG020Padrao
    {
        public int TenantId { get; set; }
        public string Cg020Id { get; set; } = null!;
        public string? Cg020FilialId { get; set; }
        public int? Cg020Ano { get; set; }
        public int? Cg020Mes { get; set; }
        public int? Cg020Lote { get; set; }
        public string? Cg020TiposaldoId { get; set; }
        public DateTime? Cg020Datainicio { get; set; }
        public DateTime? Cg020Datafinal { get; set; }
        public int? Cg020Qtdlanctos { get; set; }
        public decimal? Cg020Totaldebito { get; set; }
        public decimal? Cg020Totalcredito { get; set; }
        public decimal? Cg020Difdebcre { get; set; }
        public decimal? Cg020Gtdebcre { get; set; }
        public int? Cg020Ultlancto { get; set; }
        public int? Cg020UltSeq { get; set; }
        public int? Cg020SituacaoloteId { get; set; }
        public string? Cg020ConsolidadoFilialId { get; set; }
    }
}

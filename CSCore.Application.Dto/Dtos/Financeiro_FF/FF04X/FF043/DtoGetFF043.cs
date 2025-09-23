using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF043
{
    public class DtoGetFF043
    {
        public int TenantId { get; set; }

        public long Ff043Id { get; set; }

        public long? Ff042Id { get; set; }

        public int? Ff043Parcela { get; set; }

        public DateTime? Ff043DataVencto { get; set; }

        public decimal? Ff043ValorParcela { get; set; }

        public DateTime? Ff043DataVenctoOri { get; set; }

        public string? Ff043Pfxtitulo { get; set; }

        public decimal? Ff043Titulo { get; set; }

        public string? Ff043Sfxtitulo { get; set; }

        public string? Ff043TituloCpId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD.DD125
{
    public class DtoGetDD125
    {
        public int TenantId { get; set; }

        public string Dd125CartacredId { get; set; } = null!;

        public string? Dd125FilialId { get; set; }

        public string? Dd120TrocaId { get; set; }

        public string? Dd125ContaId { get; set; }

        public DateTime? Dd125DataMovto { get; set; }

        public decimal? Dd125Vcarta { get; set; }

        public decimal? Dd125VsaldoCarta { get; set; }

        public string? Dd125UsuariopropId { get; set; }

        public int? Dd125StatusId { get; set; }

        public string? Dd125Email { get; set; }

        public string? Dd125Sms { get; set; }

        public string? Dd125Protocolnumber { get; set; }

        public bool? Dd125Islock { get; set; }

        public int? Dd125Tiporegid { get; set; }
    }
}

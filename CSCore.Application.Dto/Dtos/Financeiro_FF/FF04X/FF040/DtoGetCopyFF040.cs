using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF040
{
    public class DtoGetCopyFF040
    {
        public int TenantId { get; set; }

        public string? Ff040Empresaid { get; set; }

        public int? Ff040Tiporegistro { get; set; }

        public DateTime? Ff040DataMovimento { get; set; }

        public string? Ff040ContaId { get; set; }

        public string? Ff040CcustoId { get; set; }

        public string? Ff040EspecieId { get; set; }

        public string? Ff040AgcobradorId { get; set; }

        public string? Ff040ResponsavelId { get; set; }

        public string? Ff040Tipocobrancaid { get; set; }

        public decimal? Ff040Vtransacao { get; set; }

        public string? Ff040Texto { get; set; }

        public string? Ff040UsuarioProprId { get; set; }

        public int? Ff040Situacaoid { get; set; }

        public string? Ff040Protocolnumber { get; set; }

        public DateTime? Ff040Dbasevencto { get; set; }

        public bool? Ff040Isprovisao { get; set; }
    }
}

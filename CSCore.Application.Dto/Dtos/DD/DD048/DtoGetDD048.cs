using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD048
{
    public class DtoGetDD048
    {
        public int TenantId { get; set; }

        public string Dd048Id { get; set; } = null!;

        public string? Dd045Id { get; set; }

        public string? Dd040Id { get; set; }

        public int? Dd048Filial { get; set; }

        public decimal? Dd048Ci { get; set; }

        public int? Dd048Tipo { get; set; }

        public string? Dd048IndOperacao { get; set; }

        public string? Dd048IndEmitente { get; set; }

        public string? Dd048Participante { get; set; }

        public string? Dd048Chaveacesso { get; set; }

        public string? Dd048Serie { get; set; }

        public int? Dd048SubSerie { get; set; }

        public decimal? Dd048NumDocto { get; set; }

        public decimal? Dd048NumEcf { get; set; }

        public string? Dd048ModDocFiscal { get; set; }

        public DateTime? Dd048DtEmisDocto { get; set; }

        public string? Dd048UfId { get; set; }

        public string? Dd048Uf { get; set; }

        public string? Dd048Cnpj { get; set; }
    }
}

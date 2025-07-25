using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD045
{
    public class DtoGetDD045
    {
        public int TenantId { get; set; }

        public string Dd045Id { get; set; } = null!;

        public string? Dd040Id { get; set; }

        public int? Dd045Tiporegistro { get; set; }

        public string? Dd045Nomecampo { get; set; }

        public string? Dd045DescricaoCompl { get; set; }
    }
}

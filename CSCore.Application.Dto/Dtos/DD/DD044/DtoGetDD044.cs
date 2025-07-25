using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD044
{
    public class DtoGetDD044
    {
        public int TenantId { get; set; }

        public string Dd044Id { get; set; } = null!;

        public string? Dd040Id { get; set; }

        public int? Dd044Tiporegistro { get; set; }

        public string? Dd044DescricaoCompl { get; set; }

        public int? Dd044Filial { get; set; }

        public decimal? Dd044Ci { get; set; }
        
    }
}

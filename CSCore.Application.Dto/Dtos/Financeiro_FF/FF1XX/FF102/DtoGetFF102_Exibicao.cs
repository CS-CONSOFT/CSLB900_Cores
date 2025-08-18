using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102
{
    public class DtoGetFF102_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Ff102Tiporegistro { get; set; }

        public string? Ff102Filialid { get; set; }

        public string? Ff102Pfx { get; set; }

        public decimal? Ff102NoTitulo { get; set; }

        public string? Ff102Sfx { get; set; }

        public string? Ff102Contaid { get; set; }

        public string? Ff102Contarealid { get; set; }
    }
}            
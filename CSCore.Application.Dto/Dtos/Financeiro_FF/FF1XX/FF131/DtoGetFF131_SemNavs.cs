using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF131
{
    public class DtoGetFF131_SemNavs
    {
        public int TenantId { get; set; }

        public long Ff131Id { get; set; }

        public string? Ff131Filialid { get; set; }

        public DateTime? Ff131Dregistro { get; set; }

        public string? Ff131Contaid { get; set; }

        public string? Ff131TomadorContaid { get; set; }

        public string? Ff131Usuarioid { get; set; }

        public string? Ff131Observacao { get; set; }

        public bool? Ff131Isefetivado { get; set; }

        public string? Ff131Protocolo { get; set; }
    }
}

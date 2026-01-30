using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD.DD001
{
    public class DtoGetDD001SemList
    {
        public int TenantId { get; set; }

        public string Dd001Id { get; set; } = null!;

        public string? Dd001Empresaid { get; set; }

        public int? Dd001Filial { get; set; }

        public string? Dd001Descricao { get; set; }

        public bool? Dd001Isactive { get; set; }

        public DateTime? Dd001Datainicio { get; set; }

        public DateTime? Dd001Datafim { get; set; }

        public string? Dd001Protocolnumber { get; set; }
    }
}

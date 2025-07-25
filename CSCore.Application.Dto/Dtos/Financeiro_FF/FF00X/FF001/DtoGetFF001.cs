using CSBS101._82Application.Dto.BB00X.BB001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF001
{
    public class DtoGetFF001
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff001Filialid { get; set; }

        public int? Ff001Filial { get; set; }

        public DateTime? Ff001Data { get; set; }

        public string? Ff001Descferiado { get; set; }

        public string? Ff001NomeDoDia { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
    }
}

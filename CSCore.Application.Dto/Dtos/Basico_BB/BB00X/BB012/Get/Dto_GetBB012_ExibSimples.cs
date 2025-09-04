using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get
{
    public class Dto_GetBB012_ExibSimples
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;

        public int? Bb012Codigo { get; set; }

        public string? Bb012NomeCliente { get; set; }
    }
}

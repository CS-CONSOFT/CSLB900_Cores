using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG010
{
    public class DtoGetGG010Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg010Filial { get; set; }

        public string? Gg010Filialid { get; set; }

        public string? Gg010CodigoTipopadrao { get; set; }

        public string? Gg010Descricaotipopadrao { get; set; }

        public bool? Gg010IsActive { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace GG104Materiais.C82Application.Dto.GG00X.GG022
{
    public class DtoGetGG022
    {
        public int TenantId { get; set; }

        public string Gg022Id { get; set; } = null!;

        public string? Gg022Ncmid { get; set; }

        public string? Gg022Ufid { get; set; }

        public decimal? Gg022Pfcp { get; set; }

        public CSICP_GG021? Gg022Ncm { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG000
{
    public class DtoGetGG000
    {
        public int TenantId { get; set; }

        public long Gg000Id { get; set; }

        public int? Gg000Ultcodigo { get; set; }

        public DateTime? Gg000Diltregistro { get; set; }

        public string? Gg000AltUsuarioid { get; set; }

        public DateTime? Gg000AltData { get; set; }

        public string? Gg000AwsBucket { get; set; }

        public string? Gg000Awsregion { get; set; }

        public string? Gg000Awsaccesskeyid { get; set; }

        public string? Gg000Awssecretaccesskey { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG060
{
    public class DtoGetCG060
    {
        public int TenantId { get; set; }

        public long Cg060Id { get; set; }

        public long? Cg060Eventoid { get; set; }

        public DateTime? Cg060Dtini { get; set; }

        public DateTime? Cg060Dtfim { get; set; }

        public int? Cg060Nrnumero { get; set; }

        public bool? Cg060Flagrupadeb { get; set; }

        public bool? Cg060Flagrupacred { get; set; }

        public long? Cg060Eventotpdebid { get; set; }

        public long? Cg060Eventotpcredid { get; set; }

        public string? Cg060Txdescricao { get; set; }

        public string? Cg060Estabid { get; set; }

        public int? Cg060Idprevia { get; set; }

        public int? Cg060Qparprenchidos { get; set; }
    }
}

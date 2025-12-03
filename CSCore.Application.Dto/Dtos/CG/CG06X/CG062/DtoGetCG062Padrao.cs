using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG062
{
    public class DtoGetCG062Padrao
    {
        public int TenantId { get; set; }

        public long Cg062Id { get; set; }

        public long? Cg062Regramentoid { get; set; }

        public long? Cg062Eventovalortpid { get; set; }

        public string? Cg062Contadebid { get; set; }

        public string? Cg062Histdebid { get; set; }

        public string? Cg062Contacredid { get; set; }

        public string? Cg062Histcredid { get; set; }

        public long? Cg062Eventovalortpdebid { get; set; }

        public long? Cg062Eventovalortpcredid { get; set; }

        public bool? Cg062Isignorevalor { get; set; }

        public string? Cg062CtagerencialDebn2Id { get; set; }

        public string? Cg062CtagerencialDebn3Id { get; set; }

        public string? Cg062CtagerencialDebn4Id { get; set; }

        public string? Cg062CtagerencialCren2Id { get; set; }

        public string? Cg062CtagerencialCren3Id { get; set; }

        public string? Cg062CtagerencialCren4Id { get; set; }
    }
}

using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG062
{
    public class DtoCreateUpdateCG062 : IConverteParaEntidade<Osusr8dwCsicpCg062>
    {
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

        public Osusr8dwCsicpCg062 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg062
            {
                TenantId = tenant,
                Cg062Regramentoid = Cg062Regramentoid,
                Cg062Eventovalortpid = Cg062Eventovalortpid,
                Cg062Contadebid = Cg062Contadebid,
                Cg062Histdebid = Cg062Histdebid,
                Cg062Contacredid = Cg062Contacredid,
                Cg062Histcredid = Cg062Histcredid,
                Cg062Eventovalortpdebid = Cg062Eventovalortpdebid,
                Cg062Eventovalortpcredid = Cg062Eventovalortpcredid,
                Cg062Isignorevalor = Cg062Isignorevalor,
                Cg062CtagerencialDebn2Id = Cg062CtagerencialDebn2Id,
                Cg062CtagerencialDebn3Id = Cg062CtagerencialDebn3Id,
                Cg062CtagerencialDebn4Id = Cg062CtagerencialDebn4Id,
                Cg062CtagerencialCren2Id = Cg062CtagerencialCren2Id,
                Cg062CtagerencialCren3Id = Cg062CtagerencialCren3Id,
                Cg062CtagerencialCren4Id = Cg062CtagerencialCren4Id
            };
        }
    }
}
using CSCore.Application.Dto.Dtos.CG.CG05X.CG050;
using CSCore.Application.Dto.Dtos.CG.CG05X.CG052;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG051
{
    public class DtoGetCG051
    {
        public int TenantId { get; set; }

        public long Cg051Id { get; set; }

        public long? Cg051Eventotpid { get; set; }

        public long? Cg051Parametrotpid { get; set; }

        public bool? Flobrigatorio { get; set; }

        public DtoGetCG050? NavCG050TipoEvento_CG051 { get; set; }

        public DtoGetCG052? NavCG052PrmEvento_CG051 { get; set; }
    }
}

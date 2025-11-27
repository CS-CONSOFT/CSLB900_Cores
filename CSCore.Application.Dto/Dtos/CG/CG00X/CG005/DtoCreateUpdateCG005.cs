using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG00X.CG005
{
    public class DtoCreateUpdateCG005 : IConverteParaEntidade<CSICP_CG005>
    {
        public string? Cg005FilialId { get; set; }

        public int? Cg005Codigo { get; set; }

        public string? Cg005Historico { get; set; }

        public string? Cg005Historicoresumido { get; set; }

        public bool? Cg005Isactive { get; set; }

        public CSICP_CG005 ToEntity(int tenant, string? id)
        {
            return new CSICP_CG005
            {
                TenantId = tenant,
                Cg005Id = id!,
                Cg005FilialId = Cg005FilialId,
                Cg005Codigo = Cg005Codigo,
                Cg005Historico = Cg005Historico,
                Cg005Historicoresumido = Cg005Historicoresumido,
                Cg005Isactive = Cg005Isactive
            };
        }
    }
}

using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG003
{
    public class DtoCreateUpdateCG003 : IConverteParaEntidade<CSICP_CG003>
    {

        public string? Cg003FilialId { get; set; }

        public int? Cg003Codigo { get; set; }

        public string? Cg003Descricao { get; set; }

        public int? Cg003Natureza { get; set; }

        public bool? Cg003Isactive { get; set; }
        public CSICP_CG003 ToEntity(int tenant, string? id)
        {
            return new CSICP_CG003
            {
                TenantId = tenant,
                Cg003Id = id!,
                Cg003FilialId = Cg003FilialId,
                Cg003Codigo = Cg003Codigo,
                Cg003Descricao = Cg003Descricao,
                Cg003Natureza = Cg003Natureza,
                Cg003Isactive = Cg003Isactive
            };
        }
    }
}

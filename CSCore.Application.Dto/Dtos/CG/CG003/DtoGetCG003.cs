using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG003
{
    public class DtoGetCG003
    {
        public int TenantId { get; set; }

        public string Cg003Id { get; set; } = null!;

        public string? Cg003FilialId { get; set; }

        public int? Cg003Codigo { get; set; }

        public string? Cg003Descricao { get; set; }

        public int? Cg003Natureza { get; set; }

        public bool? Cg003Isactive { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001Estab_CG003 { get; set; }
        public Osusr8dwCsicpCg999? NavCG999Natureza_CG003 { get; set; }
    }
}

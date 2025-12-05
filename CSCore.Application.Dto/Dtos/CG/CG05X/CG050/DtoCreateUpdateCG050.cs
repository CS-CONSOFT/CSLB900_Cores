using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG050
{
    public class DtoCreateUpdateCG050 : IConverteParaEntidade<Osusr8dwCsicpCg050>
    {
        public string? Cg050Txcodigo { get; set; }

        public string? Cg050Txdescricao { get; set; }

        public int? Cg050Periodicidadeid { get; set; }

        public int? Cg050Moduloid { get; set; }

        public bool? Cg050Flonline { get; set; }

        public bool? Cg050Flencerramento { get; set; }

        public bool? Cg050Flperman { get; set; }

        public bool? Cg050Flperexc { get; set; }

        public bool? Cg050Isactive { get; set; }
        
        public Osusr8dwCsicpCg050 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg050
            {
                TenantId = tenant,
                Cg050Txcodigo = this.Cg050Txcodigo,
                Cg050Txdescricao = this.Cg050Txdescricao,
                Cg050Periodicidadeid = this.Cg050Periodicidadeid,
                Cg050Moduloid = this.Cg050Moduloid,
                Cg050Flonline = this.Cg050Flonline,
                Cg050Flencerramento = this.Cg050Flencerramento,
                Cg050Flperman = this.Cg050Flperman,
                Cg050Flperexc = this.Cg050Flperexc,
                Cg050Isactive = this.Cg050Isactive
            };
        }
    }
}

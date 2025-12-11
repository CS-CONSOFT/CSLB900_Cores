using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG05X.CG050;
using CSCore.Domain.CS_Models.CSICP_CG;
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

        public string? Cg060Estabid { get; set; } = null;

        public int? Cg060Idprevia { get; set; }

        public int? Cg060Qparprenchidos { get; set; }

        public DtoGetCG050? NavCG050Evento_CG060 { get; set; }
        public DtoGetCG050? NavCG050EventoTpDeb_CG060 { get; set; }
        public DtoGetCG050? NavCG050EventoTpCred_CG060 { get; set; }
        public Dto_GetBB001_Exibicao? NavBB001Estab_CG060 { get; set; }
    }
}

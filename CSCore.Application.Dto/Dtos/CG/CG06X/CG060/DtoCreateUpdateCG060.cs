using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG060
{
    public class DtoCreateUpdateCG060 : IConverteParaEntidade<Osusr8dwCsicpCg060>
    {
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
        public Osusr8dwCsicpCg060 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg060
            {
                TenantId = tenant,
                Cg060Eventoid = Cg060Eventoid,
                Cg060Dtini = Cg060Dtini,
                Cg060Dtfim = Cg060Dtfim,
                Cg060Nrnumero = Cg060Nrnumero,
                Cg060Flagrupadeb = Cg060Flagrupadeb,
                Cg060Flagrupacred = Cg060Flagrupacred,
                Cg060Eventotpdebid = Cg060Eventotpdebid,
                Cg060Eventotpcredid = Cg060Eventotpcredid,
                Cg060Txdescricao = Cg060Txdescricao,
                Cg060Estabid = Cg060Estabid,
                Cg060Idprevia = Cg060Idprevia,
                Cg060Qparprenchidos = Cg060Qparprenchidos
            };
        }
    }
}

using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_NN;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG000
{
    public class DtoCreateUpdateCG000 : IConverteParaEntidade<CSICP_CG000>
    {
        public string? Cg000Filialid { get; set; }

        public int? Cg000Graus { get; set; }

        public int? Cg000Dgrau1 { get; set; }

        public int? Cg000Dgrau2 { get; set; }

        public int? Cg000Dgrau3 { get; set; }

        public int? Cg000Dgrau4 { get; set; }

        public int? Cg000Dgrau5 { get; set; }

        public string? Cg000Mascaracta { get; set; }

        public int? Cg000Grausctager { get; set; }

        public int? Cg000Dgrau1Ctager { get; set; }

        public int? Cg000Dgrau2Ctager { get; set; }

        public int? Cg000Dgrau3Ctager { get; set; }

        public int? Cg000Dgrau4Ctager { get; set; }

        public int? Cg000Dgrau5Ctager { get; set; }

        public string? Cg000Mascaractager { get; set; }

        public int? Cg000Ultcodgredz { get; set; }

        public int? Cg000Usacalendario { get; set; }
        public CSICP_CG000 ToEntity(int tenant, string? id)
        {
            return new CSICP_CG000
            {
                TenantId = tenant,
                Cg000Id = id!,
                Cg000Filialid = this.Cg000Filialid,
                Cg000Graus = this.Cg000Graus,
                Cg000Dgrau1 = this.Cg000Dgrau1,
                Cg000Dgrau2 = this.Cg000Dgrau2,
                Cg000Dgrau3 = this.Cg000Dgrau3,
                Cg000Dgrau4 = this.Cg000Dgrau4,
                Cg000Dgrau5 = this.Cg000Dgrau5,
                Cg000Mascaracta = this.Cg000Mascaracta,
                Cg000Grausctager = this.Cg000Grausctager,
                Cg000Dgrau1Ctager = this.Cg000Dgrau1Ctager,
                Cg000Dgrau2Ctager = this.Cg000Dgrau2Ctager,
                Cg000Dgrau3Ctager = this.Cg000Dgrau3Ctager,
                Cg000Dgrau4Ctager = this.Cg000Dgrau4Ctager,
                Cg000Dgrau5Ctager = this.Cg000Dgrau5Ctager,
                Cg000Mascaractager = this.Cg000Mascaractager,
                Cg000Ultcodgredz = this.Cg000Ultcodgredz,
                Cg000Usacalendario = this.Cg000Usacalendario
            };
        }
    }
}

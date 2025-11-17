using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG000
{
    public class DtoGetCG000Padrao
    {
        public int TenantId { get; set; }

        public string Cg000Id { get; set; } = null!;

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
    }
}

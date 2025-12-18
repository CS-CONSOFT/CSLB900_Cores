using CSCore.Application.Dto.Dtos.CG.CG08X.CG080;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X;
using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Dtos.CG.CG08X.CG081
{
    public class DtoGetCG081
    {
        public int TenantId { get; set; }

        public long Cg081Id { get; set; }

        public long? Cg081Contrelconfid { get; set; }

        public int? Cg081Asid { get; set; }

        public string? Cg081Txdescricao { get; set; }

        public long? Cg081Contrelregistrosup { get; set; }

        public int? Cg081Naturezasaldo { get; set; }

        public long? Cg081Nrlinha { get; set; }

        public int? Cg081Nrgrau { get; set; }

        public bool? Cg081Fllinharetaap { get; set; }

        public bool? Cg081Fllinhatracap { get; set; }

        public bool? Cg081Flnegrito { get; set; }

        public bool? Cg081Flespacobranco { get; set; }

        public string? Cg081Txnotaexplicativa { get; set; }

        public bool? Cg081Isnewpage { get; set; }

        public int? Cg081Treeorder { get; set; }
        public DtoGetCG080? NavCG081ContRelConf { get; set; }
        public Osusr8dwCsicpCg997? NavCG081ASID { get; set; }
        public DtoGetCG081Padrao? NavCG081ContRelRegistroSup { get; set; }
        public DtoGetCG993? NavCG993NaturezaSaldo { get; set; }
    }
}
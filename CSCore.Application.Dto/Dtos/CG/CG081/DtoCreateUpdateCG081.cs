using System.ComponentModel.DataAnnotations;
using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG081
{
    public class DtoCreateUpdateCG081 : IConverteParaEntidade<Osusr8dwCsicpCg081>
    {

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

        public Osusr8dwCsicpCg081 ToEntity(int tenant, string? _)
        {
            var entity = new Osusr8dwCsicpCg081
            {
                TenantId = tenant,
                Cg081Contrelconfid = this.Cg081Contrelconfid,
                Cg081Asid = this.Cg081Asid,
                Cg081Txdescricao = this.Cg081Txdescricao,
                Cg081Contrelregistrosup = this.Cg081Contrelregistrosup,
                Cg081Naturezasaldo = this.Cg081Naturezasaldo,
                Cg081Nrlinha = this.Cg081Nrlinha,
                Cg081Nrgrau = this.Cg081Nrgrau,
                Cg081Fllinharetaap = this.Cg081Fllinharetaap,
                Cg081Fllinhatracap = this.Cg081Fllinhatracap,
                Cg081Flnegrito = this.Cg081Flnegrito,
                Cg081Flespacobranco = this.Cg081Flespacobranco,
                Cg081Txnotaexplicativa = this.Cg081Txnotaexplicativa,
                Cg081Isnewpage = this.Cg081Isnewpage,
                Cg081Treeorder = this.Cg081Treeorder
            };

            return entity;
        }
    }
}
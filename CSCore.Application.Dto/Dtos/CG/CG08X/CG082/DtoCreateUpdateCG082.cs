using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG08X.CG082
{
    public class DtoCreateUpdateCG082 : IConverteParaEntidade<Osusr8dwCsicpCg082>
    {
        public long? Cg082Contrelregid { get; set; }

        public string? Cg082Contcontaid { get; set; }

        public DateTime? Cg082Dateinicial { get; set; }

        public DateTime? Cg082Datefinal { get; set; }

        public Osusr8dwCsicpCg082 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg082
            {
                TenantId = tenant,
                Cg082Contrelregid = this.Cg082Contrelregid,
                Cg082Contcontaid = this.Cg082Contcontaid,
                Cg082Dateinicial = this.Cg082Dateinicial,
                Cg082Datefinal = this.Cg082Datefinal
            };
        }
    }
}

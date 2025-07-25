using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace GG104Materiais.C82Application.Dto.GG00X.GG022
{
    public class DtoCreateUpdateGG022 : IConverteParaEntidade<CSICP_GG022>
    {
        public string? Gg022Ncmid { get; set; }

        public string? Gg022Ufid { get; set; }

        public decimal? Gg022Pfcp { get; set; }

        public CSICP_GG022 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG022
            {
                Gg022Id = id!,
                TenantId = tenant,
                Gg022Ncmid = this.Gg022Ncmid,
                Gg022Ufid = this.Gg022Ufid,
                Gg022Pfcp = this.Gg022Pfcp,
            };
        }
    }
}

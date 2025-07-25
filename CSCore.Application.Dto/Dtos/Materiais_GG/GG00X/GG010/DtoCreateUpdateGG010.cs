using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace GG104Materiais.C82Application.Dto.GG00X.GG010
{
    public class DtoCreateUpdateGG010 : IConverteParaEntidade<CSICP_GG010>
    {
        public int? Gg010Filial { get; set; }

        public string? Gg010Filialid { get; set; }

        public string? Gg010CodigoTipopadrao { get; set; }

        public string? Gg010Descricaotipopadrao { get; set; }

        public bool? Gg010IsActive { get; set; }
        public CSICP_GG010 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG010
            {
                TenantId = tenant,
                Id = id!,
                Gg010Filial = this.Gg010Filial,
                Gg010Filialid = this.Gg010Filialid,
                Gg010CodigoTipopadrao = this.Gg010CodigoTipopadrao,
                Gg010Descricaotipopadrao = this.Gg010Descricaotipopadrao,
                Gg010IsActive = this.Gg010IsActive,
            };
        }
    }
}

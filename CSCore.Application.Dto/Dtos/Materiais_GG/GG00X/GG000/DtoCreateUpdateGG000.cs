using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG000
{
    public class DtoCreateUpdateGG000 : IConverteParaEntidade<CSICP_GG000>
    {
        public int? Gg000Ultcodigo { get; set; }

        public DateTime? Gg000Diltregistro { get; set; }

        public string? Gg000AltUsuarioid { get; set; }

        public DateTime? Gg000AltData { get; set; }

        public string? Gg000AwsBucket { get; set; }

        public string? Gg000Awsregion { get; set; }

        public string? Gg000Awsaccesskeyid { get; set; }

        public string? Gg000Awssecretaccesskey { get; set; }

        public CSICP_GG000 ToEntity(int tenant, string? _)
        {
            return new CSICP_GG000
            {
                TenantId = tenant,
                Gg000Ultcodigo = this.Gg000Ultcodigo,
                Gg000Diltregistro = this.Gg000Diltregistro,
                Gg000AltUsuarioid = this.Gg000AltUsuarioid,
                Gg000AltData = this.Gg000AltData,
                Gg000AwsBucket = this.Gg000AwsBucket,
                Gg000Awsregion = this.Gg000Awsregion,
                Gg000Awsaccesskeyid = this.Gg000Awsaccesskeyid,
                Gg000Awssecretaccesskey = this.Gg000Awssecretaccesskey,
            };
        }
    }
}

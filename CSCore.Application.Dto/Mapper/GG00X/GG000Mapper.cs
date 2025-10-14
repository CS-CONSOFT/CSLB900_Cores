using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG000;
using FF105Financeiro.C82Application.Dto.GG00X.GG001;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG000Mapper
    {
        public static DtoGetGG000 ToDtoGet(this CSICP_GG000 entity)
        {
            return new DtoGetGG000
            {
                TenantId = entity.TenantId,
                Gg000Id = entity.Gg000Id,
                Gg000Ultcodigo = entity.Gg000Ultcodigo,
                Gg000Diltregistro = entity.Gg000Diltregistro,
                Gg000AltUsuarioid = entity.Gg000AltUsuarioid,
                Gg000AltData = entity.Gg000AltData,
                Gg000AwsBucket = entity.Gg000AwsBucket,
                Gg000Awsregion = entity.Gg000Awsregion,
                Gg000Awsaccesskeyid = entity.Gg000Awsaccesskeyid,
                Gg000Awssecretaccesskey = entity.Gg000Awssecretaccesskey,
            };
        }

    }}

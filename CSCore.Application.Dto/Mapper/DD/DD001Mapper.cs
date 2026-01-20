using CSCore.Application.Dto.Dtos.DD.DD001;
using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD042;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.DD
{
    public static class DD001Mapper
    {
        public static DtoGetDD001SemList ToDtoGetDD001(this CSICP_DD001 entity)
        {
            return new DtoGetDD001SemList
            {
                TenantId = entity.TenantId,
                Dd001Id =  entity.Dd001Id,
                Dd001Empresaid = entity.Dd001Empresaid,
                Dd001Filial = entity.Dd001Filial,
                Dd001Descricao = entity.Dd001Descricao,
                Dd001Isactive = entity.Dd001Isactive,
                Dd001Datainicio = entity.Dd001Datainicio,
                Dd001Datafim = entity.Dd001Datafim,
                Dd001Protocolnumber = entity.Dd001Protocolnumber
            };
        }
    }
}

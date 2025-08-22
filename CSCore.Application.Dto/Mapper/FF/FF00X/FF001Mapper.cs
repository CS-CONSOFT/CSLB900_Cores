using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF001;
using CSCore.Application.Dto.Mapper.FF;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF00X
{
    public static class FF001Mapper
    {
        public static DtoGetFF001 ToDtoGet(this CSICP_FF001 entity)
        {
            return new DtoGetFF001
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff001Filialid = entity.Ff001Filialid,
                Ff001Filial = entity.Ff001Filial,
                Ff001Data = entity.Ff001Data,
                Ff001Descferiado = entity.Ff001Descferiado,
                Ff001NomeDoDia = entity.Ff001NomeDoDia,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
            };
        }
    }
}

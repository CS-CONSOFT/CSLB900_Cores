using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF005;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF005Mapper
    {
        public static DtoGetFF005 ToDtoGet(this CSICP_FF005 entity)
        {
            return new DtoGetFF005
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff005Filialid = entity.Ff005Filialid,
                Ff005Tipo = entity.Ff005Tipo,
                Ff003Especieid = entity.Ff003Especieid,
                Ff005Sequencia = entity.Ff005Sequencia,
                Ff005Contafornid = entity.Ff005Contafornid,
                Ff005Diavencimento = entity.Ff005Diavencimento,
                Ff005Pfx = entity.Ff005Pfx,
                Ff005ImpostoId = entity.Ff005ImpostoId,
                Ff003Especie = entity.Ff003Especie,
                NavFF003 = entity.NavFF003?.ToDtoGetExibicao(),
                NavFF003TpEsp = entity.NavFF003TpEsp,
                NavAA037Imp = entity.NavAA037Imp,
            };
        }
    }
}











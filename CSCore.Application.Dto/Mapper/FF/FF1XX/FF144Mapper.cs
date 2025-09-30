using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF143;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF144;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF144Mapper
    {
        public static DtoGetFF144 ToDtoGetFF144(this CSICP_FF144 entity)
        {
            if (entity == null) return null!;
            return new DtoGetFF144
            {
                TenantId = entity.TenantId,
                Ff144Id = entity.Ff144Id,
                Ff144RdId = entity.Ff144RdId,
                Ff144Dhregistro = entity.Ff144Dhregistro,
                Ff144Usuarioproprieid = entity.Ff144Usuarioproprieid,
                Ff144Statusid = entity.Ff144Statusid,
                Ff144Execucaoid = entity.Ff144Execucaoid,
                F144Observacao = entity.F144Observacao,
                NavFF140StatusFF144 = entity.NavFF140StatusFF144,
                NavFF140ExecucaoFF144 = entity.NavFF140ExecucaoFF144,
                NavSY001UsuarioFF144 = entity.NavSY001UsuarioFF144?.ToDtoGetSimples()
            };
        }
    }
}

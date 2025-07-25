using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG072;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG072Mapper
    {
        public static DtoGetGG072 ToDtoGet(this CSICP_GG072 entity)
        {
            return new DtoGetGG072
            {
                TenantId = entity.TenantId,
                Gg072Id = entity.Gg072Id,
                Gg071Id = entity.Gg071Id,
                Gg072Codbarrasalfa = entity.Gg072Codbarrasalfa,
                Gg072KardexId = entity.Gg072KardexId,
                Gg072Saidasaldoid = entity.Gg072Saidasaldoid,
                Gg072UnId = entity.Gg072UnId,
                Gg072Quantidade = entity.Gg072Quantidade,
                Gg072ValorUnitario = entity.Gg072ValorUnitario,
                Gg072QtdAnterior = entity.Gg072QtdAnterior,
                Gg072Entradasaldoid = entity.Gg072Entradasaldoid,
                Gg072UnSecId = entity.Gg072UnSecId,
                Gg072UnSecTipoconvId = entity.Gg072UnSecTipoconvId,
                Gg072UnSecFatorconv = entity.Gg072UnSecFatorconv,
                Gg072UnSecQtde = entity.Gg072UnSecQtde,
                Gg072Statusestqid = entity.Gg072Statusestqid,
                Dd080Id = entity.Dd080Id,
                Gg072Qtdsolicitada = entity.Gg072Qtdsolicitada,
            };
        }
    }
}


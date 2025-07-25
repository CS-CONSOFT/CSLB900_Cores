using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD048;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X
{
    public static class DD048Mapper
    {
        public static DtoGetDD048 ToDtoGetDD048(this CSICP_DD048 entity)
        {
            return new DtoGetDD048
            {
                TenantId = entity.TenantId,
                Dd048Id = entity.Dd048Id,
                Dd045Id = entity.Dd045Id,
                Dd040Id = entity.Dd040Id,
                Dd048Filial = entity.Dd048Filial,
                Dd048Ci = entity.Dd048Ci,
                Dd048Tipo = entity.Dd048Tipo,
                Dd048IndOperacao = entity.Dd048IndOperacao,
                Dd048IndEmitente = entity.Dd048IndEmitente,
                Dd048Participante = entity.Dd048Participante,
                Dd048Chaveacesso = entity.Dd048Chaveacesso,
                Dd048Serie = entity.Dd048Serie,
                Dd048SubSerie = entity.Dd048SubSerie,
                Dd048NumDocto = entity.Dd048NumDocto,
                Dd048NumEcf = entity.Dd048NumEcf,
                Dd048ModDocFiscal = entity.Dd048ModDocFiscal,
                Dd048DtEmisDocto = entity.Dd048DtEmisDocto,
                Dd048UfId = entity.Dd048UfId,
                Dd048Uf = entity.Dd048Uf,
                Dd048Cnpj = entity.Dd048Cnpj
            };
        }
    }
}

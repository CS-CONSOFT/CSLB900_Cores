using CSCore.Application.Dto.Dtos.TT.TT0XX.TT031;
using CSCore.Domain.CS_Models.CSICP_TT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.TT00X
{
    public static class TT031Mapper
    {
        public static DtoGetTT031 ToDtoGet(this RepoTT031 entity)
        {
            return new DtoGetTT031
            {
                TenantId = entity.TenantId,
                Tt031Id = entity.Tt031Id ?? 0,
                Tt030Id = entity.Tt030Id,
                CsCodgproduto = entity.CsCodgproduto,
                CsQtd = entity.CsQtd,
                CsValor = entity.CsValor,
                CsDesc = entity.CsDesc,
                Gg008Id = entity.Gg008Id,
                Gg008kdxId = entity.Gg008kdxId,
                Gg520Id = entity.Gg520Id,
                Campoespecial1 = entity.Campoespecial1,
                Campoespecial2 = entity.Campoespecial2,
                Gg001Descalmox = entity.Gg001Descalmox,
                Gg008Descreduzida = entity.Gg008Descreduzida,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                GG007UnidadeID = entity.gg007_UnID
            };
        }
        public static DtoGetTT031Excel ToDtoGetTT031Excel(this CSICP_TT031 dto)
        {
            return new DtoGetTT031Excel
            {
                TenantId = dto.TenantId,
                Tt031Id = dto.Tt031Id ?? 0  ,
                CsCodgproduto = dto.CsCodgproduto,
                CsQtd = dto.CsQtd,
                CsValor = dto.CsValor,
                CsDesc = dto.CsDesc,
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG029;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG029Mapper
    {
        public static DtoGetGG029 ToDtoGet(this CSICP_GG029 entity)
        {
            return new DtoGetGG029
            {

                TenantId = entity.TenantId,
                Gg029Id = entity.Gg029Id,
                Gg029Codganp = entity.Gg029Codganp,
                Gg029Descricao = entity.Gg029Descricao,
                Gg029Codif = entity.Gg029Codif,
                Gg029Pmixgn = entity.Gg029Pmixgn,
                Gg029Pglp = entity.Gg029Pglp,
                Gg029Pgnn = entity.Gg029Pgnn,
                Gg029Pgni = entity.Gg029Pgni,
                Gg029Vpart = entity.Gg029Vpart,
                Gg029Adremicms = entity.Gg029Adremicms,
                Gg029Pbio = entity.Gg029Pbio,
                Gg029AdremicmsBio = entity.Gg029AdremicmsBio,
            };
        }
    }
}
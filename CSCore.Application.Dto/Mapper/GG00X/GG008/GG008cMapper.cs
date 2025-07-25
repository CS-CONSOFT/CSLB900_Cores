using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using GG104Materiais.C82Application.Dto.GG00X.GG008.GG008c;

namespace GG104Materiais.C82Application.Mapper.GG008
{
    public static class GG008cMapper
    {
        public static DtoGetGG008c ToDtoGet(this CSICP_GG008c entity)
        {
            return new DtoGetGG008c
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg008cFilialid = entity.Gg008cFilialid,
                Gg008cProdutoid = entity.Gg008cProdutoid,
                Gg008cFilial = entity.Gg008cFilial,
                Gg008cCodgproduto = entity.Gg008cCodgproduto,
                Gg008cDescricao = entity.Gg008cDescricao,
                Gg008cOrdem = entity.Gg008cOrdem,
                Gg008cTiporegistro = entity.Gg008cTiporegistro,
                Gg008cObjeto = entity.Gg008cObjeto,
                Gg008cFiletype = entity.Gg008cFiletype,
                Gg008cTexto = entity.Gg008cTexto,
                Filename = entity.Filename,
                Gg008cIspadrao = entity.Gg008cIspadrao,
                Gg008cPath = entity.Gg008cPath,
                Gg008cSize = entity.Gg008cSize,
                Gg008cCdnid = entity.Gg008cCdnid,
                Gg008cCdn = entity.Gg008cCdn,
            };
        }
    }
}


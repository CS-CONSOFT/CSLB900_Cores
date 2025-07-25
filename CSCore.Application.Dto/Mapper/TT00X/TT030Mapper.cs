using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG030;
using CSCore.Application.Dto.Dtos.TT.TT0XX.TT030;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.CSICP_TT;
using GG104Materiais.C82Application.Dto.GG00X.GG000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.TT00X
{
    public static class TT030Mapper
    {
        public static DtoGetTT030 ToDtoGet(this CSICP_TT030 entity)
        {
            return new DtoGetTT030
            {
                TenantId = entity.TenantId,
                Tt030Id = entity.Tt030Id,
                Tt030Estabid = entity.Tt030Estabid,
                Tt030Protocolonumber = entity.Tt030Protocolonumber,
                Tt030Datahora = entity.Tt030Datahora,
                Tt030Usuariopropid = entity.Tt030Usuariopropid,
                Tt030Usuariovendedorid = entity.Tt030Usuariovendedorid,
                Tt030Observacao = entity.Tt030Observacao,
                Tt030Protocolnumber = entity.Tt030Protocolnumber,
                CS_EstabNomeFantasia = entity.CSICP_BB001?.Bb001Nomefantasia,
                CS_UsuarioPropNome = entity.Csicp_Sy001?.Sy001Usuario
            };
        }

    }
}

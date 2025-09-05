using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003;
using CSCore.Application.Dto.Mapper.FF.FF00X;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Application.Dto.Mapper.FF.FF00X
{
    public static class FF003Mapper
    {
        public static DtoGetFF003 ToDtoGet(this CSICP_FF003 entity)
        {
            return new DtoGetFF003
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff003Filialid = entity.Ff003Filialid,
                Ff003Tipoespecie = entity.Ff003Tipoespecie,
                Ff003Codigo = entity.Ff003Codigo,
                Ff003Descricao = entity.Ff003Descricao,
                Ff003Descresumida = entity.Ff003Descresumida,
                Ff003Pfx = entity.Ff003Pfx,
                Ff003Provisao = entity.Ff003Provisao,
                Ff003Ccustoid = entity.Ff003Ccustoid,
                Ff003Lctoenttitulosid = entity.Ff003Lctoenttitulosid,
                Ff003Lctobxnormalid = entity.Ff003Lctobxnormalid,
                Ff003Lctobxdevolucaoid = entity.Ff003Lctobxdevolucaoid,
                Ff003Seqnrotitulo = entity.Ff003Seqnrotitulo,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavFF003TpEsp = entity.NavFF003TpEsp,
                NavStatica = entity.NavStatica,
                NavBB005 = entity.NavBB005?.ToDtoGetBB005_Exibicao()
            };
        }
        public static Dto_GetFF003_Exibicao ToDtoGetExibicao(this CSICP_FF003 entity)
        {
            return new Dto_GetFF003_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                //Ff003Filialid = entity.Ff003Filialid,
                //Ff003Tipoespecie = entity.Ff003Tipoespecie,
                Ff003Codigo = entity.Ff003Codigo,
                Ff003Descricao = entity.Ff003Descricao
            };
        }

    }
}


 
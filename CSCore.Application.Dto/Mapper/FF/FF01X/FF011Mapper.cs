using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB009;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF011;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF01X
{
    public static class FF011Mapper
    {
        public static DtoGetFF011 ToDtoGet(this CSICP_FF011 entity)
        {
            return new DtoGetFF011
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff011Codigo = entity.Ff011Codigo,
                Ff011DiasAtrasosDe = entity.Ff011DiasAtrasosDe,
                Ff011DiasAtrasosAte = entity.Ff011DiasAtrasosAte,
                Ff011Tipocobrancaid = entity.Ff011Tipocobrancaid,
                Ff011Categoriaid = entity.Ff011Categoriaid,
                Ff011SitcobrancaentId = entity.Ff011SitcobrancaentId,
                Ff011SituacaoentId = entity.Ff011SituacaoentId,
                Ff011SituacaosaiId = entity.Ff011SituacaosaiId,
                NavBB009 = entity.NavBB009?.ToDtoGetBB009_Exibicao(),
                NavBB029 = entity.NavBB029?.ToDtoGet(),
                NavFF998SitCobrancaEnt = entity.NavFF998SitCobrancaEnt,
                NavBB012SitEnt = entity.NavBB012SitEnt,
                NavBB012SitSai = entity.NavBB012SitSai
            };
        }
    }
}

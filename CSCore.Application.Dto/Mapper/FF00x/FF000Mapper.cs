using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF000;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF000Mapper
    {
        public static DtoGetFF000 ToDtoGet(this CSICP_FF000 entity)
        {
            return new DtoGetFF000
            {
                TenantId = entity.TenantId,
                Ff000Id = entity.Ff000Id,
                Ff000EstabId = entity.Ff000EstabId,
                Ff000N1Vacimade = entity.Ff000N1Vacimade,
                Ff000N1AutorizadorId = entity.Ff000N1AutorizadorId,
                Ff000N1AusenciaId = entity.Ff000N1AusenciaId,
                Ff000N2Vacimade = entity.Ff000N2Vacimade,
                Ff000N2AutorizadorId = entity.Ff000N2AutorizadorId,
                Ff000N2AusenciaId = entity.Ff000N2AusenciaId,
                Ff000N3Vacimade = entity.Ff000N3Vacimade,
                Ff000N3AutorizadorId = entity.Ff000N3AutorizadorId,
                Ff000N3AusenciaId = entity.Ff000N3AusenciaId,
                Ff000N4Vacimade = entity.Ff000N4Vacimade,
                Ff000N4AutorizadorId = entity.Ff000N4AutorizadorId,
                Ff000N4AusenciaId = entity.Ff000N4AusenciaId,
                Ff000N5Vacimade = entity.Ff000N5Vacimade,
                Ff000N5AutorizadorId = entity.Ff000N5AutorizadorId,
                Ff000N5AusenciaId = entity.Ff000N5AusenciaId,
                Ff000BasecalcId = entity.Ff000BasecalcId,
                Ff000PercJuros = entity.Ff000PercJuros,
                Ff000PercMulta = entity.Ff000PercMulta,
                Ff000Diascarjuros = entity.Ff000Diascarjuros,
                Ff000Diascarmulta = entity.Ff000Diascarmulta,
                Ff000Diasbloqueio = entity.Ff000Diasbloqueio,
                Ff000Diasbloqmovto = entity.Ff000Diasbloqmovto,
                Ff000Diasretroagirvencto = entity.Ff000Diasretroagirvencto,
                Ff000Diasavancarvencto = entity.Ff000Diasavancarvencto,
                Ff000Isdesabfcconfaut = entity.Ff000Isdesabfcconfaut,
                Ff000PercCorrmonetaria = entity.Ff000PercCorrmonetaria,
                Ff000PercHonorarios = entity.Ff000PercHonorarios,
                Ff000Renccustoid = entity.Ff000Renccustoid,
                Ff000Renagcobradorid = entity.Ff000Renagcobradorid,
                Ff000Rentpcobrancaid = entity.Ff000Rentpcobrancaid,
                Ff000Pminentrenegociacao = entity.Ff000Pminentrenegociacao,
                Ff000Isrensomentetodos = entity.Ff000Isrensomentetodos,
                Ff000Renespecieid = entity.Ff000Renespecieid,
                Ff000Isrensempregerarvc = entity.Ff000Isrensempregerarvc,
                Ff00Formabxtesid = entity.Ff00Formabxtesid,
                F000Formaenvapi = entity.F000Formaenvapi,
                Ff000AgcobradoridApi = entity.Ff000AgcobradoridApi,
                Ff000TpcobrancaidApi = entity.Ff000TpcobrancaidApi,
                Ff000Ispermitecpfcnpjdup = entity.Ff000Ispermitecpfcnpjdup,
                Ff000PixcobFpagtoid = entity.Ff000PixcobFpagtoid,
                NavFF000BaseCalculo = entity.NavFF000BaseCalculo,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavSy001 = entity.NavSy001?.ToDtoGetSimples(),
                NavSy001_2 = entity.NavSy001_2?.ToDtoGetSimples(),
            };
        }
    }
}

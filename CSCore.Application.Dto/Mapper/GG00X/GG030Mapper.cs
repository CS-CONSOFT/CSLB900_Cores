using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG030;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSSY103.C82Application.Mapper;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG030Mapper
    {
        public static DtoGetGG030 ToDtoGet(this CSICP_GG030 entity)
        {
            return new DtoGetGG030
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg030Usuarioid = entity.Gg030Usuarioid,
                Gg030Filial = entity.Gg030Filial,
                Gg030Filialid = entity.Gg030Filialid,
                Gg030DataMovimento = entity.Gg030DataMovimento,
                Gg030Observacao = entity.Gg030Observacao,
                Gg030CodgCCusto = entity.Gg030CodgCCusto,
                Gg030Ccustoid = entity.Gg030Ccustoid,
                Gg030NoDocto = entity.Gg030NoDocto,
                Gg030Percajuste = entity.Gg030Percajuste,
                Gg030Responsavel = entity.Gg030Responsavel,
                Gg030Responsavelid = entity.Gg030Responsavelid,
                Gg030TotalMovimento = entity.Gg030TotalMovimento,
                Gg030Status = entity.Gg030Status,
                Gg030PrecoajusteId = entity.Gg030PrecoajusteId,
                Gg030Protocolnumber = entity.Gg030Protocolnumber,
                NavGG031 = entity.NavGG031?.ToDtoGet(),
                NavBB005 = entity.NavBB005?.ToDtoGet(),
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavBB007 = entity.NavBB007?.ToDtoGetSemList(),
                NavSY001 = entity.NavSY001?.ToDtoGetSimples(),
                NavGG023Val = entity.NavGG023Val,
                NavGG030Sta = entity.NavGG030Sta
            };
        }
    }
}


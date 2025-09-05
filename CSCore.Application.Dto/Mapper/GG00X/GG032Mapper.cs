using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG032;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG032Mapper
    {
        public static DtoGetGG032 ToDtoGet(this CSICP_GG032 entity)
        {
            return new DtoGetGG032
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg032Filialid = entity.Gg032Filialid,
                Gg032Usuarioid = entity.Gg032Usuarioid,
                Gg032Filial = entity.Gg032Filial,
                Gg032Datamovimento = entity.Gg032Datamovimento,
                Gg032Observacao = entity.Gg032Observacao,
                Gg032Almoxid = entity.Gg032Almoxid,
                Gg032Codgalmox = entity.Gg032Codgalmox,
                Gg032Totalcusto = entity.Gg032Totalcusto,
                Gg032Totalcreal = entity.Gg032Totalcreal,
                Gg032Totalcmedio = entity.Gg032Totalcmedio,
                Gg032Totalvenda = entity.Gg032Totalvenda,
                Gg032DataHoraBloqueado = entity.Gg032DataHoraBloqueado,
                Gg032DataHoraProcessado = entity.Gg032DataHoraProcessado,
                Gg032QtosPodutos = entity.Gg032QtosPodutos,
                Gg032QtosNaoconform = entity.Gg032QtosNaoconform,
                Gg032QtosNaoinventariado = entity.Gg032QtosNaoinventariado,
                Gg032QtdRegraNconf = entity.Gg032QtdRegraNconf,
                Gg032TipoinventarioId = entity.Gg032TipoinventarioId,
                Gg032StatusId = entity.Gg032StatusId,
                Gg032Protocolnumber = entity.Gg032Protocolnumber,
                NavSy001Usuario = entity.NavSy001Usuario?.ToDtoGetSimples(),
                NavGG032Status = entity.NavGG032Status,
                NavGG032Tinventario = entity.NavGG032Tinventario
            };
        }
    }
}



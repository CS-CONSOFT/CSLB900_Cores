using CSBS101._82Application.Mapper.BB00X;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG073;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSSY103.C82Application.Mapper;
using CSCore.Application.Dto.Mapper.GG00X;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG073Mapper
    {
        public static DtoGetGG073 ToDtoGet(this CSICP_GG073 entity)
        {
            return new DtoGetGG073
            {
                TenantId = entity.TenantId,
                Gg073Id = entity.Gg073Id,
                Gg073Estabid = entity.Gg073Estabid,
                Gg073DataMovimento = entity.Gg073DataMovimento,
                Gg073Usuarioid = entity.Gg073Usuarioid,
                Gg073Observacao = entity.Gg073Observacao,
                Gg073Ccustoid = entity.Gg073Ccustoid,
                Gg073Almoxmovd = entity.Gg073Almoxmovd,
                Gg073Dhregistro = entity.Gg073Dhregistro,
                Gg073Statusid = entity.Gg073Statusid,
                Gg073Tmovid = entity.Gg073Tmovid,
                Gg073Valorizarporid = entity.Gg073Valorizarporid,
                Gg073Tmovimento = entity.Gg073Tmovimento,
                Gg073Protocolonro = entity.Gg073Protocolonro,
                Gg073Almoxmovsaida = entity.Gg073Almoxmovsaida,
                Gg073QtdeItens = entity.Gg073QtdeItens,
                Gg073IdOrig = entity.Gg073IdOrig,
                Dd190Obraid = entity.Dd190Obraid,
                Gg073AlmoxmovdNavigation = entity.Gg073AlmoxmovdNavigation?.ToDtoGetSimples(),
                Gg073AlmoxmovsaidaNavigation = entity.Gg073AlmoxmovsaidaNavigation?.ToDtoGetSimples(),
                Gg073Status = entity.Gg073Status,
                Gg073Tmov = entity.Gg073Tmov,
                Gg073Valorizarpor = entity.Gg073Valorizarpor,
            };
        }

        public static DtoGetGG0073_2 ToDtoGet_2(this CSICP_GG073 entity)
        {
            return new DtoGetGG0073_2
            {
                TenantId = entity.TenantId,
                Gg073Id = entity.Gg073Id,
                Gg073Estabid = entity.Gg073Estabid,
                Gg073DataMovimento = entity.Gg073DataMovimento,
                Gg073Usuarioid = entity.Gg073Usuarioid,
                Gg073Observacao = entity.Gg073Observacao,
                Gg073Ccustoid = entity.Gg073Ccustoid,
                Gg073Almoxmovd = entity.Gg073Almoxmovd,
                Gg073Dhregistro = entity.Gg073Dhregistro,
                Gg073Statusid = entity.Gg073Statusid,
                Gg073Tmovid = entity.Gg073Tmovid,
                Gg073Valorizarporid = entity.Gg073Valorizarporid,
                Gg073Tmovimento = entity.Gg073Tmovimento,
                Gg073Protocolonro = entity.Gg073Protocolonro,
                Gg073Almoxmovsaida = entity.Gg073Almoxmovsaida,
                Gg073QtdeItens = entity.Gg073QtdeItens,
                Gg073IdOrig = entity.Gg073IdOrig,
                Dd190Obraid = entity.Dd190Obraid,
                NavGg001Almoxmovd = entity.Gg073AlmoxmovdNavigation != null ? entity.Gg073AlmoxmovdNavigation.ToDtoGet() : null,
                NavGg001Almoxmovsaida = entity.Gg073AlmoxmovsaidaNavigation != null ? entity.Gg073AlmoxmovsaidaNavigation.ToDtoGet() : null,
                NavGg073Status = entity.Gg073Status,
                NavGg073Tmov = entity.Gg073Tmov,
                NavGg073Valorizarpor = entity.Gg073Valorizarpor,
                NavSY001Usuario = entity.NavSY001 != null ? entity.NavSY001.ToDtoGetSimples() : null,
                NavBB005CentroDeCusto = entity.NavBB005 != null ? entity.NavBB005.ToDtoGet() : null,
            };
        }
    }
}


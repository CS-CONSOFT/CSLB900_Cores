using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG054;
using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Mapper;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG054Mapper
    {
        public static DtoGetGG054 ToDtoGet(this CSICP_GG054 entity)
        {
            return new DtoGetGG054
            {
                TenantId = entity.TenantId,
                Gg054Id = entity.Gg054Id,
                Gg054Filialid = entity.Gg054Filialid,
                Gg054Protocolnumber = entity.Gg054Protocolnumber,
                Gg054UsuarioId = entity.Gg054UsuarioId,
                Gg054DataColeta = entity.Gg054DataColeta,
                Gg054Observacao = entity.Gg054Observacao,
                Gg054Status = entity.Gg054Status,
                Gg054Almox = entity.Gg054Almox,
                Gg054DataInc = entity.Gg054DataInc,
                Gg054HoraInc = entity.Gg054HoraInc,
                Gg054DataAlt = entity.Gg054DataAlt,
                Gg054HoraAlt = entity.Gg054HoraAlt,
                Gg054UsuarioAlt = entity.Gg054UsuarioAlt,
                Gg032Id = entity.Gg032Id,
                Gg054DocInvent = entity.Gg054DocInvent,
                Gg054Ismarcado = entity.Gg054Ismarcado,
                Gg054StatusNavigation = entity.Gg054StatusNavigation,
                NavGG001Almox = entity.NavGG001Almox?.ToDtoGetSimples()
            };
        }


    }
}

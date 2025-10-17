using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR020;
using CSCore.Application.Dto.Mapper.Rebanho.RR008;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR020
{
    public static class RR020Mapper
    {
        public static DtoGetRR020 ToDtoGetRR020(this OsusrTo3CsicpRr020 entity)
        {
            return new DtoGetRR020
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr020Identificador = entity.Rr020Identificador,
                Rr020Descricao = entity.Rr020Descricao,
                Rr020Dtinicio = entity.Rr020Dtinicio,
                Rr020Dtfinal = entity.Rr020Dtfinal,
                Rr020Regalimentarid = entity.Rr020Regalimentarid,

                // Navegação
                NavRR008RegAlimentar = entity.NavRR008RegAlimentar_RR020?.ToDtoGetRR008()
            };
        }

        public static DtoGetRR020Padrao ToDtoGetRR020Padrao(this OsusrTo3CsicpRr020 entity)
        {
            return new DtoGetRR020Padrao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr020Identificador = entity.Rr020Identificador,
                Rr020Descricao = entity.Rr020Descricao,
                Rr020Dtinicio = entity.Rr020Dtinicio,
                Rr020Dtfinal = entity.Rr020Dtfinal,
                Rr020Regalimentarid = entity.Rr020Regalimentarid
            };
        }
    }
}
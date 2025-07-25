using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG034;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG034Mapper
    {
        public static DtoGetGG034 ToDtoGet(this CSICP_GG034 entity)
        {
            return new DtoGetGG034
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg034Usuarioid = entity.Gg034Usuarioid,
                Gg034Filial = entity.Gg034Filial,
                Gg034Filialid = entity.Gg034Filialid,
                Gg034DataMovimento = entity.Gg034DataMovimento,
                Gg034Observacao = entity.Gg034Observacao,
                Gg034NomePromocao = entity.Gg034NomePromocao,
                Gg034Dtinicioprom = entity.Gg034Dtinicioprom,
                Gg034Dtfimprom = entity.Gg034Dtfimprom,
                Gg034Status = entity.Gg034Status,
                Gg034Tipopromocao = entity.Gg034Tipopromocao,
                Gg034Protocolnumber = entity.Gg034Protocolnumber,
            };
        }
    }
}


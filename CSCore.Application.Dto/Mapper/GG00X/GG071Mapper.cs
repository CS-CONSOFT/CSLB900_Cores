using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG071;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG071Mapper
    {
        public static DtoGetGG071 ToDtoGet(this CSICP_GG071 entity)
        {
            return new DtoGetGG071
            {
                TenantId = entity.TenantId,
                Gg071Id = entity.Gg071Id,
                Gg071Estabid = entity.Gg071Estabid,
                Gg071Protocolnumber = entity.Gg071Protocolnumber,
                Gg071DataMovimento = entity.Gg071DataMovimento,
                Gg071Usuarioid = entity.Gg071Usuarioid,
                Gg071Observacao = entity.Gg071Observacao,
                Gg071Ccustoid = entity.Gg071Ccustoid,
                Gg071NoDocto = entity.Gg071NoDocto,
                Gg071Statusid = entity.Gg071Statusid,
                Dd070Id = entity.Dd070Id,
                Gg071Almoxsaidaid = entity.Gg071Almoxsaidaid,
                Gg071Almoxentid = entity.Gg071Almoxentid,
                Gg071AtendenteUsuarioid = entity.Gg071AtendenteUsuarioid,
                Gg071Datendimento = entity.Gg071Datendimento,
                Gg071Tpreqid = entity.Gg071Tpreqid,
                Gg071Dhsolicitacao = entity.Gg071Dhsolicitacao,
                Gg071Almoxent = entity.Gg071Almoxent,
                Gg071Almoxsaida = entity.Gg071Almoxsaida,
                Gg071Status = entity.Gg071Status,
                Gg071Tpreq = entity.Gg071Tpreq,
            };
        }
    }
}


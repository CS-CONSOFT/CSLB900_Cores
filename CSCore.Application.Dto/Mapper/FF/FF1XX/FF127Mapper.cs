using System;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX;

public static class FF127Mapper
{
    public static DtoGetCSICP_FF127Simples? ToDtoGetSimples(this CSICP_FF127 entity)
    {
        if (entity == null) return null;

        return new DtoGetCSICP_FF127Simples(
            entity.TenantId,
            entity.Ff127Id,
            entity.Ff127Protocolnumber,
            entity.Ff127ContaId,
            entity.Ff127Dtregistro,
            entity.Ff127Dtprevisao,
            entity.Ff127Mensagem,
            entity.Ff127Ispago,
            entity.Ff127Isactive,
            entity.Ff127CobradorId,
            entity.Ff127AgcobradorId,
            entity.Ff127Isvisitado,
            entity.Ff127Dtvisita,
            entity.Ff127HoraRegistro,
            entity.Ff127UsuarioInc,
            entity.Ff127Motivoid
        );
    }
}

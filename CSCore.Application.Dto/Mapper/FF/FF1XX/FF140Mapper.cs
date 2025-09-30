using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF140;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF140Mapper
    {
        public static DtoGetFF140Simples? ToDtoGetFF140(this CSICP_FF140 entity)
        {
            if (entity == null) return null!;
            return new DtoGetFF140Simples(
                entity.TenantId,
                entity.Ff140Id,
                entity.Ff140Data,
                entity.Ff140Contaid,
                entity.Ff140Especieid,
                entity.Ff140Ccustoid,
                entity.Ff140Usuarioproprieid,
                entity.Ff140Agcobradorid,
                entity.Ff140FpagtoId,
                entity.Ff140Condicaoid,
                entity.Ff140Tipocobrancaid,
                entity.Ff140Descricao,
                entity.Ff140Protocolnumber,
                entity.Ff140Vrequisicao,
                entity.Ff140Projetoid,
                entity.Ff140Statusid,
                entity.Ff140Execucaoid,
                entity.Ff140Tpvinculoid,
                entity.Ff140QtdeParcelas,
                entity.Ff140Estabid,
                entity.Ff140AdtoId
            );
        }
    }
}

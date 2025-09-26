using CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF043;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF04X.FF043
{
    public static class FF043Mapper
    {
        public static DtoGetFF043 ToDtoGet(this CSICP_FF043 entity)
        {
            return new DtoGetFF043
            {
                TenantId = entity.TenantId,
                Ff043Id = entity.Ff043Id,
                Ff042Id = entity.Ff042Id,
                Ff043Parcela = entity.Ff043Parcela,
                Ff043DataVencto = entity.Ff043DataVencto,
                Ff043ValorParcela = entity.Ff043ValorParcela,
                Ff043DataVenctoOri = entity.Ff043DataVenctoOri,
                Ff043Pfxtitulo = entity.Ff043Pfxtitulo,
                Ff043Titulo = entity.Ff043Titulo,
                Ff043Sfxtitulo = entity.Ff043Sfxtitulo,
                Ff043TituloCpId = entity.Ff043TituloCpId
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF006;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF006Mapper
    {
        public static DtoGetFF006 ToDtoGet(this CSICP_FF006 entity)
        {
            return new DtoGetFF006
            {
                TenantId = entity.TenantId,
                Ff006Id = entity.Ff006Id,
                Ff102Id = entity.Ff102Id,
                Ff006Vdescjuros = entity.Ff006Vdescjuros,
                Ff006Pdescjuros = entity.Ff006Pdescjuros,
                Ff006Dsolicitacao = entity.Ff006Dsolicitacao,
                Ff006Usuariosolicid = entity.Ff006Usuariosolicid,
                Ff006Dresgate = entity.Ff006Dresgate,
                Ff006Usuarioresgid = entity.Ff006Usuarioresgid,
                Ff006Chaveautoriz = entity.Ff006Chaveautoriz,
                Ff006Vabertotit = entity.Ff006Vabertotit,
                Ff006Vjurostit = entity.Ff006Vjurostit,
                Ff006Datrasotit = entity.Ff006Datrasotit,
                Ff006Statusid = entity.Ff006Statusid,
                Ff006Chave = entity.Ff006Chave,
                Ff006Tabela = entity.Ff006Tabela,
                Ff102 = entity.Ff102,
            };
        }
    }
}




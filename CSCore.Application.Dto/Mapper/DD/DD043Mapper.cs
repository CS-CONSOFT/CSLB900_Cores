using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD043;
using EnviaNFeHercules.C82Application.Dto.DD.DD044;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X
{
    public static class DD043Mapper
    {
        public static DtoGetDD043 ToDtoGetDD043(this CSICP_DD043 entity)
        {
            return new DtoGetDD043
            {
                TenantId = entity.TenantId,
                Dd043Id = entity.Dd043Id,
                Dd042Id = entity.Dd042Id,
                Dd043Parcela = entity.Dd043Parcela,
                Dd043DataVencto = entity.Dd043DataVencto,
                Dd043ValorParcela = entity.Dd043ValorParcela,
                Dd043NoCartao = entity.Dd043NoCartao,
                Dd043Banco = entity.Dd043Banco,
                Dd043Agencia = entity.Dd043Agencia,
                Dd043Dvagencia = entity.Dd043Dvagencia,
                Dd043Conta = entity.Dd043Conta,
                Dd043Dvconta = entity.Dd043Dvconta,
                Dd043Cheque = entity.Dd043Cheque,
                Dd043Rg = entity.Dd043Rg,
                Dd043Telefone = entity.Dd043Telefone,
                Dd043Compensacao = entity.Dd043Compensacao,
                Dd043ChequeTerceiro = entity.Dd043ChequeTerceiro,
                Dd043DataVenctoOri = entity.Dd043DataVenctoOri,
                Dd043UsuarioidAltdtvc = entity.Dd043UsuarioidAltdtvc
            };
        }
    }
}

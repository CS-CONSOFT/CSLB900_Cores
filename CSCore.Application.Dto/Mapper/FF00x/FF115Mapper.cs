using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF115;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF115Mapper
    {
        public static DtoGetFF115 ToDtoGet(this CSICP_FF115 entity)
        {
            return new DtoGetFF115
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff115Filialid = entity.Ff115Filialid,
                Ff113Controleid = entity.Ff113Controleid,
                Ff115Codgfilial = entity.Ff115Codgfilial,
                Ff115Pfx = entity.Ff115Pfx,
                Ff115Titulo = entity.Ff115Titulo,
                Ff115Sfx = entity.Ff115Sfx,
                Ff115Conta = entity.Ff115Conta,
                Ff115Nossonumero = entity.Ff115Nossonumero,
                Ff115Codgmovtoretorno = entity.Ff115Codgmovtoretorno,
                Ff115Datavencimento = entity.Ff115Datavencimento,
                Ff115Valornominaltitulo = entity.Ff115Valornominaltitulo,
                Ff115Jurosmultaencargos = entity.Ff115Jurosmultaencargos,
                Ff115Vlrdescontoconcedido = entity.Ff115Vlrdescontoconcedido,
                Ff115Abatimentocancelamento = entity.Ff115Abatimentocancelamento,
                Ff115Valorpago = entity.Ff115Valorpago,
                Ff115Valorliquido = entity.Ff115Valorliquido,
                Ff115Datacredito = entity.Ff115Datacredito,
                Ff102TituloId = entity.Ff102TituloId,
                Ff115IsincluirBaixa = entity.Ff115IsincluirBaixa,
                Ff115Codgmovc044 = entity.Ff115Codgmovc044,
                Ff115Desccodgmovimento = entity.Ff115Desccodgmovimento,
                Ff115Codgocorrcc047 = entity.Ff115Codgocorrcc047,
                Ff115Desccodgocorrcc047 = entity.Ff115Desccodgocorrcc047
            };
        }
            
    }
}

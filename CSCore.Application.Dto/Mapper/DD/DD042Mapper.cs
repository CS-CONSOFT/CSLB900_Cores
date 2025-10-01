using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD042;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X
{
    public static class DD042Mapper
    {
        public static DtoGetDD042 ToDtoGetDD042(this CSICP_DD042 entity)
        {
            return new DtoGetDD042
            {
                TenantId = entity.TenantId,
                Dd042Id = entity.Dd042Id,
                Dd040Id = entity.Dd040Id,
                Dd042Fpagtoid = entity.Dd042Fpagtoid,
                Dd042ValorPago = entity.Dd042ValorPago,
                Dd042Qtd = entity.Dd042Qtd,
                Dd042ValorTotalpago = entity.Dd042ValorTotalpago,
                Dd042ValorTroco = entity.Dd042ValorTroco,
                Dd042Condicaoid = entity.Dd042Condicaoid,
                Dd042Nroparcelas = entity.Dd042Nroparcelas,
                Dd042Valor1aparcela = entity.Dd042Valor1aparcela,
                Dd042Administradoraid = entity.Dd042Administradoraid,
                Dd042Filial = entity.Dd042Filial,
                Dd042Ci = entity.Dd042Ci,
                Dd042FormaPagto = entity.Dd042FormaPagto,
                Dd042DataMovimento = entity.Dd042DataMovimento,
                Dd042Operador = entity.Dd042Operador,
                Dd042Regtransferido = entity.Dd042Regtransferido,
                Dd042ChaveVincId = entity.Dd042ChaveVincId,
                Dd042Produtoservico = entity.Dd042Produtoservico,
                Dd042Cnsu = entity.Dd042Cnsu,
                Dd042Cdatamovimento = entity.Dd042Cdatamovimento,
                Dd042Cpv = entity.Dd042Cpv,
                Dd042Cdoc = entity.Dd042Cdoc,
                Dd042Caut = entity.Dd042Caut,
                Dd042Perccomissao = entity.Dd042Perccomissao,
                Dd042Valorcomissao = entity.Dd042Valorcomissao,
                Dd042Cnsuctf = entity.Dd042Cnsuctf,
                Dd042Cautorizadora = entity.Dd042Cautorizadora,
                Dd042Cvanctf = entity.Dd042Cvanctf,
                Dd042Cinstituicaoctf = entity.Dd042Cinstituicaoctf,
                Dd042Cnsucanc = entity.Dd042Cnsucanc,
                Dd042Cdatacanc = entity.Dd042Cdatacanc,
                Dd042RetCompestab = entity.Dd042RetCompestab,
                Dd042RetCompcliente = entity.Dd042RetCompcliente,
                Dd042RetCompcanc = entity.Dd042RetCompcanc,
                Dd042Nrotitulo = entity.Dd042Nrotitulo,
                Dd042Fatoracresc = entity.Dd042Fatoracresc,
                NavBB026 = entity.NavBB026?.ToDtoGetBB026ComBB026Classe(),
                NavBb026Classe = entity.NavBb026Classe,
                NavDD043 = entity.NavDD043.Select(e => e.ToDtoGetDD043()).ToList(),
            };
        }
    }
}













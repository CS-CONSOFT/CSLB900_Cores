using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB009;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF017;
using CSCore.Application.Dto.Mapper.DD;
using CSCore.Application.Dto.Mapper.FF.FF00X;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF017;

namespace CSCore.Application.Dto.Mapper.FF.FF01X
{
    public static class FF017Mapper
    {
        public static DtoGetFF017 ToDtoGet(this RepoDtoCSICP_FF017 entity)
        {
            return new DtoGetFF017
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff017Tiporegistro = entity.Ff017Tiporegistro,
                Ff017Filialid = entity.Ff017Filialid,
                Ff017Filial = entity.Ff017Filial,
                Ff017DataRenegociacao = entity.Ff017DataRenegociacao,
                Ff017Especieid = entity.Ff017Especieid,
                Ff017Contaid = entity.Ff017Contaid,
                Ff017Ccustoid = entity.Ff017Ccustoid,
                Ff017Agcobradorid = entity.Ff017Agcobradorid,
                Ff017Usuarioid = entity.Ff017Usuarioid,
                Ff017Condicaoid = entity.Ff017Condicaoid,
                Ff017Tipocobrancaid = entity.Ff017Tipocobrancaid,
                Ff017Contatomadordivid = entity.Ff017Contatomadordivid,
                Ff017PercJuros = entity.Ff017PercJuros,
                Ff017Multa = entity.Ff017Multa,
                Ff017TotalTitulos = entity.Ff017TotalTitulos,
                Ff017TotalAberto = entity.Ff017TotalAberto,
                Ff017TotalJuros = entity.Ff017TotalJuros,
                Ff017TotalMulta = entity.Ff017TotalMulta,
                Ff017TotalDescontos = entity.Ff017TotalDescontos,
                Ff017Totrenegociado = entity.Ff017Totrenegociado,
                Ff017ValorEntrada = entity.Ff017ValorEntrada,
                Ff017PercEntrada = entity.Ff017PercEntrada,
                Ff017Aberto = entity.Ff017Aberto,
                Ff017Protocolnumber = entity.Ff017Protocolnumber,
                Ff017Pminvlrentrada = entity.Ff017Pminvlrentrada,
                Ff017Vminentrada = entity.Ff017Vminentrada,
                Ff017Valecreditoid = entity.Ff017Valecreditoid,
                Ff017Statusvcid = entity.Ff017Statusvcid,
                Ff017Formapagtoid = entity.Ff017Formapagtoid,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavBB005 = entity.NavBB005?.ToDtoGetBB005_Exibicao(),
                NavBB006 = entity.NavBB006?.ToDtoGetExibicao(),
                NavBB008 = entity.NavBB008?.ToDtoGetSimples(),
                NavBB009 = entity.NavBB009?.ToDtoGetBB009_Exibicao(),
                NavBB012 = entity.NavBB012?.ToDtoBB012Exibicao(),
                NavBB026 = entity.NavBB026?.ToDtoGetExibicao(),
                NavDD125 = entity.NavDD125?.ToDtoGet(),
                NavFF003 = entity.NavFF003?.ToDtoGetExibicao(),
                NavSY001 = entity.NavSY001?.ToDtoGetSimples(),
                NavFF107vc = entity.NavFF107vc,
            };
        }

    }
}
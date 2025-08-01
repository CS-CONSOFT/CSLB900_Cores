using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF017;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF017Mapper
    {
        public static DtoGetFF017 ToDtoGet(this CSICP_FF017 entity)
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
            };
        }
    }
}
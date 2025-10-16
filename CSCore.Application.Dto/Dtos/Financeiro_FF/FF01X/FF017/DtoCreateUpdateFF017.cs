using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF017
{
    public class DtoCreateUpdateFF017 : IConverteParaEntidade<CSICP_FF017>
    {
        public int? Ff017Tiporegistro { get; set; }

        public string? Ff017Filialid { get; set; }

        public int? Ff017Filial { get; set; }

        public DateTime? Ff017DataRenegociacao { get; set; }

        public string? Ff017Especieid { get; set; }

        public string? Ff017Contaid { get; set; }

        public string? Ff017Ccustoid { get; set; }

        public string? Ff017Agcobradorid { get; set; }

        public string? Ff017Usuarioid { get; set; }

        public string? Ff017Condicaoid { get; set; }

        public string? Ff017Tipocobrancaid { get; set; }

        public string? Ff017Contatomadordivid { get; set; }

        public decimal? Ff017PercJuros { get; set; }

        public decimal? Ff017Multa { get; set; }

        public decimal? Ff017TotalTitulos { get; set; }

        public decimal? Ff017TotalAberto { get; set; }

        public decimal? Ff017TotalJuros { get; set; }

        public decimal? Ff017TotalMulta { get; set; }

        public decimal? Ff017TotalDescontos { get; set; }

        public decimal? Ff017Totrenegociado { get; set; }

        public decimal? Ff017ValorEntrada { get; set; }

        public decimal? Ff017PercEntrada { get; set; }

        public bool? Ff017Aberto { get; set; }

        public string? Ff017Protocolnumber { get; set; }

        public decimal? Ff017Pminvlrentrada { get; set; }

        public decimal? Ff017Vminentrada { get; set; }

        public string? Ff017Valecreditoid { get; set; }

        public int? Ff017Statusvcid { get; set; }

        public string? Ff017Formapagtoid { get; set; }

        public CSICP_FF017 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF017
            {
                TenantId = tenant,
                Id = id!,
                Ff017Tiporegistro = Ff017Tiporegistro,
                Ff017Filialid = Ff017Filialid,
                Ff017Filial = Ff017Filial,
                Ff017DataRenegociacao = Ff017DataRenegociacao,
                Ff017Especieid = Ff017Especieid,
                Ff017Contaid = Ff017Contaid,
                Ff017Ccustoid = Ff017Ccustoid,
                Ff017Agcobradorid = Ff017Agcobradorid,
                Ff017Usuarioid = Ff017Usuarioid,
                Ff017Condicaoid = Ff017Condicaoid,
                Ff017Tipocobrancaid = Ff017Tipocobrancaid,
                Ff017Contatomadordivid = Ff017Contatomadordivid,
                Ff017PercJuros = Ff017PercJuros,
                Ff017Multa = Ff017Multa,
                Ff017TotalTitulos = Ff017TotalTitulos,
                Ff017TotalAberto = Ff017TotalAberto,
                Ff017TotalJuros = Ff017TotalJuros,
                Ff017TotalMulta = Ff017TotalMulta,
                Ff017TotalDescontos = Ff017TotalDescontos,
                Ff017Totrenegociado = Ff017Totrenegociado,
                Ff017ValorEntrada = Ff017ValorEntrada,
                Ff017PercEntrada = Ff017PercEntrada,
                Ff017Aberto = Ff017Aberto,
                Ff017Protocolnumber = Ff017Protocolnumber,
                Ff017Pminvlrentrada = Ff017Pminvlrentrada,
                Ff017Vminentrada = Ff017Vminentrada,
                Ff017Valecreditoid = Ff017Valecreditoid,
                Ff017Statusvcid = Ff017Statusvcid,
                Ff017Formapagtoid = Ff017Formapagtoid
            };
        }
    }
}

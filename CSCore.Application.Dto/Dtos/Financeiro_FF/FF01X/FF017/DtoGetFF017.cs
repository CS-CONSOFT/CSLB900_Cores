using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB009;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Application.Dto.Dtos.DD.DD125;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF003;
using CSCore.Application.Dto.Dtos.Sistema.SY001.SY001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF017
{
    public class DtoGetFF017
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

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

        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public Dto_GetBB005_Exibicao? NavBB005 { get; set; }
        public Dto_GetBB006_Exibicao? NavBB006 { get; set; }
        public Dto_GetBB008_Exibicao? NavBB008 { get; set; }
        public Dto_GetBB009_Exibicao? NavBB009 { get; set; }
        public Dto_GetBB012_Exibicao? NavBB012 { get; set; }
        public Dto_GetBB026_Exibicao? NavBB026 { get; set; }
        public DtoGetDD125? NavDD125 { get; set; } //Quais campos são necessários?
        public OsusrE9aCsicpFf107Vc? NavFF107vc { get; set; }
        public Dto_GetFF003_Exibicao? NavFF003 { get; set; }
        public Dto_GetSY001Simples? NavSY001 { get; set; }

        public CSICP_FF017 ToEntity()
        {
            return new CSICP_FF017
            {
                TenantId = TenantId,
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
                Id = Id,
                Ff017Valecreditoid = Ff017Valecreditoid,
                Ff017Statusvcid = Ff017Statusvcid
            };
        }
    }
}

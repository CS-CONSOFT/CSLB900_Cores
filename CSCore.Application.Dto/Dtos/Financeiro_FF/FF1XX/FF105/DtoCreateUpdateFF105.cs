using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF105
{
    public class DtoCreateUpdateFF105 : IConverteParaEntidade<CSICP_FF105>
    {
        public string? Ff105Filialid { get; set; }

        public string? Ff105Descricaobordero { get; set; }

        public int? Ff105ClienteInicial { get; set; }

        public int? Ff105ClienteFinal { get; set; }

        public DateTime? Ff105EmissaoInicial { get; set; }

        public DateTime? Ff105EmissaoFinal { get; set; }

        public DateTime? Ff105VenctoInicial { get; set; }

        public DateTime? Ff105VenctoFinal { get; set; }

        public int? Ff105CodgcategIni { get; set; }

        public int? Ff105CodgcategFim { get; set; }

        public int? Ff105CodgrotaIni { get; set; }

        public int? Ff105CodgrotaFim { get; set; }

        public decimal? Ff105ValorMinimo { get; set; }

        public string? Ff105Agcobradorid { get; set; }

        public string? Ff105Tipocobrancaid { get; set; }

        public string? Ff105InstCobranca1 { get; set; }

        public string? Ff105InstCobranca2 { get; set; }

        public int? Ff105Agencia { get; set; }

        public string? Ff105AgenciaDv { get; set; }

        public int? Ff105ContaCorrente { get; set; }

        public string? Ff105ContaDv { get; set; }

        public DateTime? Ff105DataEnvio { get; set; }

        public decimal? Ff105ValorBordero { get; set; }

        public int? Ff105QtdTitulos { get; set; }

        public bool? Ff105Fechado { get; set; }

        public bool? Ff105IsActive { get; set; }

        public int? Ff105Status { get; set; }

        public string? Ff105Protocolnumber { get; set; }

        public int? Ff105ApiId { get; set; }

        public int? Ff105Statusapi { get; set; }

        public DateTime? Ff105DataCriacao { get; set; }

        public CSICP_FF105 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF105
            {
                TenantId = tenant,
                Id = id!,
                Ff105Filialid = Ff105Filialid,
                Ff105Descricaobordero = Ff105Descricaobordero,
                Ff105ClienteInicial = Ff105ClienteInicial,
                Ff105ClienteFinal = Ff105ClienteFinal,
                Ff105EmissaoInicial = Ff105EmissaoInicial,
                Ff105EmissaoFinal = Ff105EmissaoFinal,
                Ff105VenctoInicial = Ff105VenctoInicial,
                Ff105VenctoFinal = Ff105VenctoFinal,
                Ff105CodgcategIni = Ff105CodgcategIni,
                Ff105CodgcategFim = Ff105CodgcategFim,
                Ff105CodgrotaIni = Ff105CodgrotaIni,
                Ff105CodgrotaFim = Ff105CodgrotaFim,
                Ff105ValorMinimo = Ff105ValorMinimo,
                Ff105Agcobradorid = Ff105Agcobradorid,
                Ff105Tipocobrancaid = Ff105Tipocobrancaid,
                Ff105InstCobranca1 = Ff105InstCobranca1,
                Ff105InstCobranca2 = Ff105InstCobranca2,
                Ff105Agencia = Ff105Agencia,
                Ff105AgenciaDv = Ff105AgenciaDv,
                Ff105ContaCorrente = Ff105ContaCorrente,
                Ff105ContaDv = Ff105ContaDv,
                Ff105DataEnvio = Ff105DataEnvio,
                Ff105ValorBordero = Ff105ValorBordero,
                Ff105QtdTitulos = Ff105QtdTitulos,
                Ff105Fechado = Ff105Fechado,
                Ff105IsActive = Ff105IsActive,
                Ff105Status = Ff105Status,
                Ff105Protocolnumber = Ff105Protocolnumber,
                Ff105ApiId = Ff105ApiId,
                Ff105Statusapi = Ff105Statusapi,
                Ff105DataCriacao = Ff105DataCriacao,
            };
        }
    }
}

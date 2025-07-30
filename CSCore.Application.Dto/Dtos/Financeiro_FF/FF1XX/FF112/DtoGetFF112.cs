using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB006;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112
{
    public class DtoGetFF112
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff112Filialid { get; set; }

        public string? Ff112Bancoid { get; set; }

        public string? Ff112Descregistro { get; set; }

        public decimal? Ff112Ultlote { get; set; }

        public int? Ff112Carteira { get; set; }

        public string? Ff112Convenio { get; set; }

        public int? Ff112Cadastramento { get; set; }

        public int? Ff112Documento { get; set; }

        public int? Ff112Emissaobloqueto { get; set; }

        public int? Ff112Distribuicaobloqueto { get; set; }

        public decimal? Ff112Nrocontrato { get; set; }

        public string? Ff112Moedapadrao { get; set; }

        public int? Ff112Tipooperacao { get; set; }

        public int? Ff112Tiposervico { get; set; }

        public int? Ff112Tipoinscricao { get; set; }

        public int? Ff112Codgprotesto { get; set; }

        public int? Ff112Prazoprotesto { get; set; }

        public int? Ff112Codgbaixadevolucao { get; set; }

        public int? Ff112Prazodevolucao { get; set; }

        public string? Ff112Versaocnab { get; set; }

        public string? Ff112Mensagem1 { get; set; }

        public string? Ff112Mensagem2 { get; set; }

        public string? Ff112Mensagem3 { get; set; }

        public string? Ff112Mensagem4 { get; set; }

        public bool? IsActive { get; set; }

        public string? Ff112Codgmovimetoretorno { get; set; }

        public string? Ff112Nrocarteira { get; set; }

        public string? Ff112Varcarteira { get; set; }

        public int? Ff112Faixanossonro { get; set; }

        public int? Ff112CnabId { get; set; }

        public decimal? Ff112PercJuros { get; set; }

        public decimal? Ff112ValorJuros { get; set; }

        public decimal? Ff112PercMulta { get; set; }

        public decimal Ff112ValorMulta { get; set; } = 0m;

        public decimal? Ff112PercDesconto { get; set; }

        public int? Ff112CnabCodDesconto { get; set; }

        public int? Ff112CnabCodJurosMora { get; set; }

        public int? Ff112CnabCodMulta { get; set; }

        public int? Ff112Prazorecbto { get; set; }

        public string? Ff112Boletoid { get; set; }

        public string? Ff112Ccorrenteid { get; set; }

        public int? Ff112IdentAceite { get; set; }

        public bool? Ff112Ismultempresa { get; set; }

        public string? Ff112TpCobrEntrada { get; set; }

        public string? Ff112TpCobrSaida { get; set; }

        public int? Ff112Prazonegativacao { get; set; }

        public int? Ff112OrgaoNeg { get; set; }

        //Tabelas Nav
        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public Dto_GetBB006_Exibicao? NavBB006 { get; set; }
        public OsusrE9aCsicpFf112C006? NavFF112C006 { get; set; }
        public OsusrE9aCsicpFf112C007? NavFF112C007 { get; set; }
        public OsusrE9aCsicpFf112C008? NavFF112C008 { get; set; }
        public OsusrE9aCsicpFf112C009? NavFF112C009 { get; set; }
        public OsusrE9aCsicpFf112C026? NavFF112C026 { get; set; }
        public OsusrE9aCsicpFf112C028? NavFF112C028 { get; set; }
        public OsusrE9aCsicpFf112G005? NavFF112G005 { get; set; }
        public OsusrE9aCsicpFf112G025? NavFF112G025 { get; set; }
        public OsusrE9aCsicpFf112G028? NavFF112G028 { get; set; }
        public OsusrE9aCsicpFf112Cnab? NavFF112Cnab { get; set; }


    }
}

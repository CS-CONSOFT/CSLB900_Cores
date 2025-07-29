using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112
{
    public class DtoCreateUpdateFF112 : IConverteParaEntidade<CSICP_FF112>
    {
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

        public CSICP_FF112 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF112
            {
                TenantId = tenant,
                Id = id!,
                Ff112Filialid = Ff112Filialid,
                Ff112Bancoid = Ff112Bancoid,
                Ff112Descregistro = Ff112Descregistro,
                Ff112Ultlote = Ff112Ultlote,
                Ff112Carteira = Ff112Carteira,
                Ff112Convenio = Ff112Convenio,
                Ff112Cadastramento = Ff112Cadastramento,
                Ff112Documento = Ff112Documento,
                Ff112Emissaobloqueto = Ff112Emissaobloqueto,
                Ff112Distribuicaobloqueto = Ff112Distribuicaobloqueto,
                Ff112Nrocontrato = Ff112Nrocontrato,
                Ff112Moedapadrao = Ff112Moedapadrao,
                Ff112Tipooperacao = Ff112Tipooperacao,
                Ff112Tiposervico = Ff112Tiposervico,
                Ff112Tipoinscricao = Ff112Tipoinscricao,
                Ff112Codgprotesto = Ff112Codgprotesto,
                Ff112Prazoprotesto = Ff112Prazoprotesto,
                Ff112Codgbaixadevolucao = Ff112Codgbaixadevolucao,
                Ff112Prazodevolucao = Ff112Prazodevolucao,
                Ff112Versaocnab = Ff112Versaocnab,
                Ff112Mensagem1 = Ff112Mensagem1,
                Ff112Mensagem2 = Ff112Mensagem2,
                Ff112Mensagem3 = Ff112Mensagem3,
                Ff112Mensagem4 = Ff112Mensagem4,
                IsActive = IsActive,
                Ff112Codgmovimetoretorno = Ff112Codgmovimetoretorno,
                Ff112Nrocarteira = Ff112Nrocarteira,
                Ff112Varcarteira = Ff112Varcarteira,
                Ff112Faixanossonro = Ff112Faixanossonro,
                Ff112CnabId = Ff112CnabId,
                Ff112PercJuros = Ff112PercJuros,
                Ff112ValorJuros = Ff112ValorJuros,
                Ff112PercMulta = Ff112PercMulta,
                Ff112ValorMulta = Ff112ValorMulta,
                Ff112PercDesconto = Ff112PercDesconto,
                Ff112CnabCodDesconto = Ff112CnabCodDesconto,
                Ff112CnabCodJurosMora = Ff112CnabCodJurosMora,
                Ff112CnabCodMulta = Ff112CnabCodMulta,
                Ff112Prazorecbto = Ff112Prazorecbto,
                Ff112Boletoid = Ff112Boletoid,
                Ff112Ccorrenteid = Ff112Ccorrenteid,
                Ff112IdentAceite = Ff112IdentAceite,
                Ff112Ismultempresa = Ff112Ismultempresa,
                Ff112TpCobrEntrada = Ff112TpCobrEntrada,
                Ff112TpCobrSaida = Ff112TpCobrSaida,
                Ff112Prazonegativacao = Ff112Prazonegativacao,
                Ff112OrgaoNeg = Ff112OrgaoNeg,
            };
        }
    }
}
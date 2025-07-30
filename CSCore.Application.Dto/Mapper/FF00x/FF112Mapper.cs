using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF112;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF112Mapper
    {
        public static DtoGetFF112 ToDtoGetFF112(this RepoDtoCSICP_FF112 entity)
        {
            return new DtoGetFF112
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff112Filialid = entity.Ff112Filialid,
                Ff112Bancoid = entity.Ff112Bancoid,
                Ff112Descregistro = entity.Ff112Descregistro,
                Ff112Ultlote = entity.Ff112Ultlote,
                Ff112Carteira = entity.Ff112Carteira,
                Ff112Convenio = entity.Ff112Convenio,
                Ff112Cadastramento = entity.Ff112Cadastramento,
                Ff112Documento = entity.Ff112Documento,
                Ff112Emissaobloqueto = entity.Ff112Emissaobloqueto,
                Ff112Distribuicaobloqueto = entity.Ff112Distribuicaobloqueto,
                Ff112Nrocontrato = entity.Ff112Nrocontrato,
                Ff112Moedapadrao = entity.Ff112Moedapadrao,
                Ff112Tipooperacao = entity.Ff112Tipooperacao,
                Ff112Tiposervico = entity.Ff112Tiposervico,
                Ff112Tipoinscricao = entity.Ff112Tipoinscricao,
                Ff112Codgprotesto = entity.Ff112Codgprotesto,
                Ff112Prazoprotesto = entity.Ff112Prazoprotesto,
                Ff112Codgbaixadevolucao = entity.Ff112Codgbaixadevolucao,
                Ff112Prazodevolucao = entity.Ff112Prazodevolucao,
                Ff112Versaocnab = entity.Ff112Versaocnab,
                Ff112Mensagem1 = entity.Ff112Mensagem1,
                Ff112Mensagem2 = entity.Ff112Mensagem2,
                Ff112Mensagem3 = entity.Ff112Mensagem3,
                Ff112Mensagem4 = entity.Ff112Mensagem4,
                IsActive = entity.IsActive,
                Ff112Codgmovimetoretorno = entity.Ff112Codgmovimetoretorno,
                Ff112Nrocarteira = entity.Ff112Nrocarteira,
                Ff112Varcarteira = entity.Ff112Varcarteira,
                Ff112Faixanossonro = entity.Ff112Faixanossonro,
                Ff112CnabId = entity.Ff112CnabId,
                Ff112PercJuros = entity.Ff112PercJuros,
                Ff112ValorJuros = entity.Ff112ValorJuros,
                Ff112PercMulta = entity.Ff112PercMulta,
                Ff112ValorMulta = entity.Ff112ValorMulta,
                Ff112PercDesconto = entity.Ff112PercDesconto,
                Ff112CnabCodDesconto = entity.Ff112CnabCodDesconto,
                Ff112CnabCodJurosMora = entity.Ff112CnabCodJurosMora,
                Ff112CnabCodMulta = entity.Ff112CnabCodMulta,
                Ff112Prazorecbto = entity.Ff112Prazorecbto,
                Ff112Boletoid = entity.Ff112Boletoid,
                Ff112Ccorrenteid = entity.Ff112Ccorrenteid,
                Ff112IdentAceite = entity.Ff112IdentAceite,
                Ff112Ismultempresa = entity.Ff112Ismultempresa,
                Ff112TpCobrEntrada = entity.Ff112TpCobrEntrada,
                Ff112TpCobrSaida = entity.Ff112TpCobrSaida,
                Ff112Prazonegativacao = entity.Ff112Prazonegativacao,
                Ff112OrgaoNeg = entity.Ff112OrgaoNeg,
                //Navs
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavBB006 = entity.NavBB006?.ToDtoGetExibicao(),
                NavFF112C006 = entity.NavFF112C006,
                NavFF112C007 = entity.NavFF112C007,
                NavFF112C008 = entity.NavFF112C008,
                NavFF112C009 = entity.NavFF112C009,
                NavFF112C026 = entity.NavFF112C026,
                NavFF112C028 = entity.NavFF112C028,
                NavFF112Cnab = entity.NavFF112Cnab,
                NavFF112G005 = entity.NavFF112G005,
                NavFF112G025 = entity.NavFF112G025,
                NavFF112G028 = entity.NavFF112G028
            };
        }
    }
}

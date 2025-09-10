using CSBS101._82Application.Mapper.AA00X.AA025;
using CSBS101._82Application.Mapper.AA00X.AA027;
using CSBS101._82Application.Mapper.AA00X.AA028;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.DD.DD041;
using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.DD
{
    public static class DD041Mapper
    {
        public static DtoGetDD041 ToDtoGetDD041(this CSICP_DD041 entity)
        {
            return new DtoGetDD041
            {
                TenantId = entity.TenantId,
                Dd041Id = entity.Dd041Id,
                Dd040Id = entity.Dd040Id,
                Dd041Tipo = entity.Dd041Tipo,
                Dd041ContaId = entity.Dd041ContaId,
                Dd041Tipodocto = entity.Dd041Tipodocto,
                Dd041CnpjCpf = entity.Dd041CnpjCpf,
                Dd041Nome = entity.Dd041Nome,
                Dd041Logradouro = entity.Dd041Logradouro,
                Dd041Numero = entity.Dd041Numero,
                Dd041Complemento = entity.Dd041Complemento,
                Dd041Perimetro = entity.Dd041Perimetro,
                Dd041BairroId = entity.Dd041BairroId,
                Dd041Nomebairro = entity.Dd041Nomebairro,
                Dd041Cep = entity.Dd041Cep,
                Dd041PaisId = entity.Dd041PaisId,
                Dd041UfId = entity.Dd041UfId,
                Dd041CidadeId = entity.Dd041CidadeId,
                Dd041IeRg = entity.Dd041IeRg,
                Dd041Suframa = entity.Dd041Suframa,
                Dd041Telefone = entity.Dd041Telefone,
                Dd041Email = entity.Dd041Email,
                Dd041TransportadoraId = entity.Dd041TransportadoraId,
                Dd041Nometransp = entity.Dd041Nometransp,
                Dd041Modalidadefrete = entity.Dd041Modalidadefrete,
                Dd041Placaveiculo = entity.Dd041Placaveiculo,
                Dd041Ufveiculo = entity.Dd041Ufveiculo,
                Dd041Marcaveiculo = entity.Dd041Marcaveiculo,
                Dd041Numtransp = entity.Dd041Numtransp,
                Dd041Placareboque = entity.Dd041Placareboque,
                Dd041UfreboqueId = entity.Dd041UfreboqueId,
                Dd041Numtranspreboq = entity.Dd041Numtranspreboq,
                Dd041Vagao = entity.Dd041Vagao,
                Dd041Balsa = entity.Dd041Balsa,
                Dd041EnderecoId = entity.Dd041EnderecoId,
                Dd041SendEmail = entity.Dd041SendEmail,
                Dd041SendSms = entity.Dd041SendSms,
                Dd041UserOperadorId = entity.Dd041UserOperadorId,
                Dd041DataCaixa = entity.Dd041DataCaixa,
                Dd041Sms = entity.Dd041Sms,
                Dd041Indfinal = entity.Dd041Indfinal,
                Dd041IdentEstrangeiro = entity.Dd041IdentEstrangeiro,
                NavBB012Trasportadora = entity.NavBB012Trasportadora?.ToDtoGet(),
                NavDD041Doc = entity.NavDD041Doc,
                NavAA025 = entity.NavAA025?.ToDtoGet(),
                NavAA027 = entity.NavAA027?.ToDtoGetAA027SASimples(),
                NavAA028 = entity.NavAA028?.ToDtoGetSimples()

            };
        }
    }
}
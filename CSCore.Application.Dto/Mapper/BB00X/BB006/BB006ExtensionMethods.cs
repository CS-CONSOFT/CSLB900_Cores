
using CSBS101._82Application.Dto.BB00X.BB006;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.BB00X
{
    public static class BB006ExtensionMethods
    {
        public static CSICP_Bb006 ToEntity(this Dto_CreateUpdateBB006 dto)
        {
            var entity = new CSICP_Bb006
            {
                Bb006Filial = dto.Bb006Filial,
                Bb006Codgbanco = dto.Bb006Codgbanco,
                Bb006Banco = dto.Bb006Banco,
                Bb006Nomereduzido = dto.Bb006Nomereduzido,
                Bb006Nobanco = dto.Bb006Nobanco,
                Bb006Agencia = dto.Bb006Agencia,
                Bb006AgenciaDv = dto.Bb006AgenciaDv,
                Bb006Noconta = dto.Bb006Noconta,
                Bb006Contadv = dto.Bb006Contadv,
                Bb006Dvagenciacc = dto.Bb006Dvagenciacc,
                Bb006Endereco = dto.Bb006Endereco,
                Cidadeid = dto.Cidadeid,
                Bb006Telefone = dto.Bb006Telefone,
                Bb006Fax = dto.Bb006Fax,
                Bb006Email = dto.Bb006Email,
                Bb006Homepage = dto.Bb006Homepage,
                Bb006Contato = dto.Bb006Contato,
                Bb006Diasretencao = dto.Bb006Diasretencao,
                Bb006Diasretencaodesc = dto.Bb006Diasretencaodesc,
                Bb006Saldoatual = dto.Bb006Saldoatual,
                Bb006Txcobsimples = dto.Bb006Txcobsimples,
                Bb006Txdesconto = dto.Bb006Txdesconto,
                Bb006Contacontabil = dto.Bb006Contacontabil,
                Bb006Codghistorico = dto.Bb006Codghistorico,
                Bb006Limitecredito = dto.Bb006Limitecredito,
                Bb006Msgboleto = dto.Bb006Msgboleto,
                Bb006Codempresabanco = dto.Bb006Codempresabanco,
                Bb006Nroseqremessa = dto.Bb006Nroseqremessa,
                Bb006Perccomissao = dto.Bb006Perccomissao,
                Bb006Movtatesouraria = dto.Bb006Movtatesouraria,
                Bb006Nomeagencia = dto.Bb006Nomeagencia,
                Bb006Classificacao = dto.Bb006Classificacao,
                Bb006Codgeracaocrec = dto.Bb006Codgeracaocrec,
                Empresaid = dto.Empresaid,
                Bb006Tipocobrancaid = dto.Bb006Tipocobrancaid,
                Ufid = dto.Ufid,
                Bb006Isactive = true,
                Bb006BancoId = dto.Bb006BancoId,
                Bb006CodcobradorId = dto.Bb006CodcobradorId,
                Bb006ApiId = dto.Bb006ApiId,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
        public static Dto_GetBB006 ToDtoGet(this CSICP_Bb006 entity)
        {
            return new Dto_GetBB006
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb006Filial = entity.Bb006Filial,
                Bb006Codgbanco = entity.Bb006Codgbanco,
                Bb006Banco = entity.Bb006Banco,
                Bb006Nomereduzido = entity.Bb006Nomereduzido,
                Bb006Nobanco = entity.Bb006Nobanco,
                Bb006Agencia = entity.Bb006Agencia,
                Bb006AgenciaDv = entity.Bb006AgenciaDv,
                Bb006Noconta = entity.Bb006Noconta,
                Bb006Contadv = entity.Bb006Contadv,
                Bb006Dvagenciacc = entity.Bb006Dvagenciacc,
                Bb006Endereco = entity.Bb006Endereco,

                Cidadeid = entity.Cidadeid,
                Bb006Telefone = entity.Bb006Telefone,
                Bb006Fax = entity.Bb006Fax,
                Bb006Email = entity.Bb006Email,
                Bb006Homepage = entity.Bb006Homepage,
                Bb006Contato = entity.Bb006Contato,
                Bb006Diasretencao = entity.Bb006Diasretencao,
                Bb006Diasretencaodesc = entity.Bb006Diasretencaodesc,
                Bb006Saldoatual = entity.Bb006Saldoatual,
                Bb006Txcobsimples = entity.Bb006Txcobsimples,
                Bb006Txdesconto = entity.Bb006Txdesconto,
                Bb006Contacontabil = entity.Bb006Contacontabil,
                Bb006Codghistorico = entity.Bb006Codghistorico,
                Bb006Limitecredito = entity.Bb006Limitecredito,
                Bb006Msgboleto = entity.Bb006Msgboleto,
                Bb006Codempresabanco = entity.Bb006Codempresabanco,
                Bb006Nroseqremessa = entity.Bb006Nroseqremessa,
                Bb006Perccomissao = entity.Bb006Perccomissao,
                Bb006Movtatesouraria = entity.Bb006Movtatesouraria,
                Bb006Nomeagencia = entity.Bb006Nomeagencia,
                Bb006Classificacao = entity.Bb006Classificacao,
                Bb006Codgeracaocrec = entity.Bb006Codgeracaocrec,
                Empresaid = entity.Empresaid,
                Bb006Tipocobrancaid = entity.Bb006Tipocobrancaid,
                Ufid = entity.Ufid,
                Bb006Isactive = entity.Bb006Isactive,
                Bb006BancoId = entity.Bb006BancoId,
                Bb006CodcobradorId = entity.Bb006CodcobradorId,
                Bb006ApiId = entity.Bb006ApiId,

                NavBb006Tipocobranca = entity.Bb006Tipocobranca
            };
        }

        public static Dto_GetBB006_Exibicao ToDtoGetExibicao(this CSICP_Bb006 entity)
        {
            return new Dto_GetBB006_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb006Codgbanco = entity.Bb006Codgbanco,
                Bb006Banco = entity.Bb006Banco
            };
        }
    }
}

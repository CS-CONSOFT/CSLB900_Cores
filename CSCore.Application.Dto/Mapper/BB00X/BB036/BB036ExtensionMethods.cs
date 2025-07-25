

using CSBS101._82Application.Dto.BB00X.BB036;
using CSBS101._82Application.Dto.BB00X.BB03X.BB036.BB036End;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB036ExtensionMethods
    {
        public static CSICP_Bb036 ToEntity(this Dto_CreateUpdateBB036 dto)
        {
            var entity = new CSICP_Bb036
            {
                Bb036Primeironome = dto.Bb036Primeironome,
                Bb036Sobrenome = dto.Bb036Sobrenome,
                Bb036Empresa = dto.Bb036Empresa,
                Bb036Email = dto.Bb036Email,
                Bb036Emailsecundario = dto.Bb036Emailsecundario,
                Bb036Titulo = dto.Bb036Titulo,
                Bb036Telefone = dto.Bb036Telefone,
                Bb036Celular = dto.Bb036Celular,
                Bb036Fax = dto.Bb036Fax,
                Bb036Site = dto.Bb036Site,
                Bb036Descricao = dto.Bb036Descricao,
                Bb036IsActive = true,
                Bb036TratamentoId = dto.Bb036TratamentoId,
                Bb036SituacaoId = dto.Bb036SituacaoId,
                Bb036Atividadeid = dto.Bb036Atividadeid
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB036 ToDtoGet(this CSICP_Bb036 entity)
        {
            return new Dto_GetBB036
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb036Primeironome = entity.Bb036Primeironome,
                Bb036Sobrenome = entity.Bb036Sobrenome,
                Bb036Empresa = entity.Bb036Empresa,
                Bb036Email = entity.Bb036Email,
                Bb036Emailsecundario = entity.Bb036Emailsecundario,
                Bb036Titulo = entity.Bb036Titulo,
                Bb036Telefone = entity.Bb036Telefone,
                Bb036Celular = entity.Bb036Celular,
                Bb036Fax = entity.Bb036Fax,
                Bb036Site = entity.Bb036Site,
                Bb036Descricao = entity.Bb036Descricao,
                Bb036IsActive = entity.Bb036IsActive,
                Bb036TratamentoId = entity.Bb036TratamentoId,
                Bb036SituacaoId = entity.Bb036SituacaoId,
                Bb036Atividadeid = entity.Bb036Atividadeid,
                NavBb036Atividade = entity.Bb036Atividade?.ToDtoGet(),
            };
        }


        public static CSICP_Bb036Ender ToEntity(this Dto_CreateUpdateBB036End dto)
        {
            return new CSICP_Bb036Ender
            {
                Bb036Candidatoid = dto.Bb036Candidatoid,
                Bb036Logradouro = dto.Bb036Logradouro,
                Bb036Numero = dto.Bb036Numero,
                Bb036Complemento = dto.Bb036Complemento,
                Bb036Bairro = dto.Bb036Bairro,
                Bb036CodigoCidade = dto.Bb036CodigoCidade,
                Bb036Uf = dto.Bb036Uf,
                Bb036Cep = dto.Bb036Cep,
                Bb036CodigoPais = dto.Bb036CodigoPais
            };
        }

        public static Dto_GetBB036End ToDtoGet(this CSICP_Bb036Ender entity)
        {
            return new Dto_GetBB036End
            {
                TenantId = entity.TenantId,
                Bb036Id = entity.Bb036Id,
                Bb036Candidatoid = entity.Bb036Candidatoid,
                Bb036Logradouro = entity.Bb036Logradouro,
                Bb036Numero = entity.Bb036Numero,
                Bb036Complemento = entity.Bb036Complemento,
                Bb036Bairro = entity.Bb036Bairro,
                Bb036CodigoCidade = entity.Bb036CodigoCidade,
                Bb036Uf = entity.Bb036Uf,
                Bb036Cep = entity.Bb036Cep,
                Bb036CodigoPais = entity.Bb036CodigoPais,
                NavBb036Candidato = entity.Bb036Candidato
            };
        }
    }
}

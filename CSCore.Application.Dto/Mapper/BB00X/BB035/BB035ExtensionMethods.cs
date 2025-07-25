
using CSBS101._82Application.Dto.BB00X.BB035;
using CSBS101._82Application.Dto.BB00X.BB03X.BB035;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB03X.BB035;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB035ExtensionMethods
    {
        public static CSICP_Bb035 ToEntity(this Dto_CreateUpdateBB035 dto)
        {
            var entity = new CSICP_Bb035
            {
                Bb035Primeironome = dto.Bb035Primeironome,
                Bb035Sobrenome = dto.Bb035Sobrenome,
                Bb035Email = dto.Bb035Email,
                Bb035Titulo = dto.Bb035Titulo,
                Bb035Departamento = dto.Bb035Departamento,
                Bb035DataAniversario = dto.Bb035DataAniversario,
                Bb035Telefone = dto.Bb035Telefone,
                Bb035Outrotelefone = dto.Bb035Outrotelefone,
                Bb035Celular = dto.Bb035Celular,
                Bb035Fax = dto.Bb035Fax,
                Bb035Telefoneresidencia = dto.Bb035Telefoneresidencia,
                Bb035Descricao = dto.Bb035Descricao,
                Bb035Assistente = dto.Bb035Assistente,
                Bb035Telefoneassist = dto.Bb035Telefoneassist,
                Bb035Emailsecundario = dto.Bb035Emailsecundario,
                Bb035Cpf = dto.Bb035Cpf,
                Bb035Rg = dto.Bb035Rg,
                Bb035OrgaoExpedRg = dto.Bb035OrgaoExpedRg,
                Bb035DataEmissaoRg = dto.Bb035DataEmissaoRg?.ConverteStringVaziaParaDataNula(),
                Bb035IsActive = true,
                Bb035TratamentoId = dto.Bb035TratamentoId,
                Bb035OrigemcontatoId = dto.Bb035OrigemcontatoId,
                //Bb035CodgCliente7x = dto.Bb035CodgCliente7x,
                //Bb035SeqCliente7x = dto.Bb035SeqCliente7x,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static (CSICP_Bb035, CSICP_Bb035End) ToEntity(this Dto_CreateUpdateBB035Separado dto)
        {
            var entity = new CSICP_Bb035
            {
                Bb035Primeironome = dto.NavCSICP_BB035.Bb035Primeironome,
                Bb035Sobrenome = dto.NavCSICP_BB035.Bb035Sobrenome,
                Bb035Email = dto.NavCSICP_BB035.Bb035Email,
                Bb035Titulo = dto.NavCSICP_BB035.Bb035Titulo,
                Bb035Departamento = dto.NavCSICP_BB035.Bb035Departamento,
                Bb035DataAniversario = dto.NavCSICP_BB035.Bb035DataAniversario,
                Bb035Telefone = dto.NavCSICP_BB035.Bb035Telefone,
                Bb035Outrotelefone = dto.NavCSICP_BB035.Bb035Outrotelefone,
                Bb035Celular = dto.NavCSICP_BB035.Bb035Celular,
                Bb035Fax = dto.NavCSICP_BB035.Bb035Fax,
                Bb035Telefoneresidencia = dto.NavCSICP_BB035.Bb035Telefoneresidencia,
                Bb035Descricao = dto.NavCSICP_BB035.Bb035Descricao,
                Bb035Assistente = dto.NavCSICP_BB035.Bb035Assistente,
                Bb035Telefoneassist = dto.NavCSICP_BB035.Bb035Telefoneassist,
                Bb035Emailsecundario = dto.NavCSICP_BB035.Bb035Emailsecundario,
                Bb035Cpf = dto.NavCSICP_BB035.Bb035Cpf,
                Bb035Rg = dto.NavCSICP_BB035.Bb035Rg,
                Bb035OrgaoExpedRg = dto.NavCSICP_BB035.Bb035OrgaoExpedRg,
                Bb035IsActive = true,
                Bb035TratamentoId = dto.NavCSICP_BB035.Bb035TratamentoId,
                Bb035OrigemcontatoId = dto.NavCSICP_BB035.Bb035OrigemcontatoId,
            };
            entity.ConverteValoresPadraoParaNulo();



            var entityEnd = new CSICP_Bb035End
            {
                Bb035Id = dto.NavCSICP_BB035End.Bb035Id,
                Bb035Logradouro = dto.NavCSICP_BB035End.Bb035Logradouro,
                Bb035Numero = dto.NavCSICP_BB035End.Bb035Numero,
                Bb035Complemento = dto.NavCSICP_BB035End.Bb035Complemento,
                Bb035Bairro = dto.NavCSICP_BB035End.Bb035Bairro,
                Bb035CodigoCidade = dto.NavCSICP_BB035End.Bb035CodigoCidade,
                Bb035Uf = dto.NavCSICP_BB035End.Bb035Uf,
                Bb035Cep = dto.NavCSICP_BB035End.Bb035Cep,
                Bb035CodigoPais = dto.NavCSICP_BB035End.Bb035CodigoPais,
            };
            return (entity, entityEnd);
        }

        public static CSICP_Bb035End ToEntity(this Dto_CreateUpdateBB035EndToUpdateFromBB035 dto)
        {
            return new CSICP_Bb035End
            {
                Bb035Logradouro = dto.Bb035Logradouro,
                Bb035Numero = dto.Bb035Numero,
                Bb035Complemento = dto.Bb035Complemento,
                Bb035Bairro = dto.Bb035Bairro,
                Bb035CodigoCidade = dto.Bb035CodigoCidade,
                Bb035Uf = dto.Bb035Uf,
                Bb035Cep = dto.Bb035Cep,
                Bb035CodigoPais = dto.Bb035CodigoPais,
            };
        }

        public static Dto_GetBB035 ToDtoGet(this CSICP_Bb035 entity)
        {
            return new Dto_GetBB035
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb035Primeironome = entity.Bb035Primeironome,
                Bb035Sobrenome = entity.Bb035Sobrenome,
                Bb035Email = entity.Bb035Email,
                Bb035Titulo = entity.Bb035Titulo,
                Bb035Departamento = entity.Bb035Departamento,
                Bb035DataAniversario = entity.Bb035DataAniversario,
                Bb035Telefone = entity.Bb035Telefone,
                Bb035Outrotelefone = entity.Bb035Outrotelefone,
                Bb035Celular = entity.Bb035Celular,
                Bb035Fax = entity.Bb035Fax,
                Bb035Telefoneresidencia = entity.Bb035Telefoneresidencia,
                Bb035Descricao = entity.Bb035Descricao,
                Bb035Assistente = entity.Bb035Assistente,
                Bb035Telefoneassist = entity.Bb035Telefoneassist,
                Bb035Emailsecundario = entity.Bb035Emailsecundario,
                Bb035Cpf = entity.Bb035Cpf,
                Bb035Rg = entity.Bb035Rg,
                Bb035OrgaoExpedRg = entity.Bb035OrgaoExpedRg,
                Bb035DataEmissaoRg = entity.Bb035DataEmissaoRg,
                Bb035IsActive = entity.Bb035IsActive,
                Bb035TratamentoId = entity.Bb035TratamentoId,
                Bb035OrigemcontatoId = entity.Bb035OrigemcontatoId,
                //Bb035CodgCliente7x = entity.Bb035CodgCliente7x,
                //Bb035SeqCliente7x = entity.Bb035SeqCliente7x,
                NavCSICP_BB035Trat = entity.NavCSICP_BB035Trat,
                NavCSICP_BB035Origem = entity.NavCSICP_BB035Origem,
                NavCSICP_BB035End = entity.NavCSICP_BB035End,
            };
        }

        public static Dto_GetBB035_Exibicao ToDtoGetExibicao(this CSICP_Bb035 entity)
        {
            return new Dto_GetBB035_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb035Primeironome = entity.Bb035Primeironome,
                Bb035Sobrenome = entity.Bb035Sobrenome,

            };
        }
    }
}

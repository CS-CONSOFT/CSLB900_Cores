
using CSBS101._82Application.Dto.BB00X.BB007;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB007;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.BB00X
{
    public static class BB007ExtensionMethods
    {
        public static CSICP_BB007 ToEntity(this Dto_CreateUpdateBB007 dto)
        {
            var entity = new CSICP_BB007
            {
                Empresaid = dto.Bb007Filial,
                Bb007Codigo = dto.Bb007Codigo,
                Bb007Responsavel = dto.Bb007Responsavel,
                Bb007Nomereduzido = dto.Bb007Nomereduzido,
                Bb007Classificacao = dto.Bb007Classificacao,
                Bb007UsuarioId = dto.Bb007UsuarioId,
                Bb007Codgsupervisor = dto.Bb007Codgsupervisor,
                Bb007Codggerente = dto.Bb007Codggerente,
                Bb007Geracpagar = dto.Bb007Geracpagar,
                Bb007Coms1 = dto.Bb007Coms1,
                Bb007Coms2 = dto.Bb007Coms2,
                Bb007Coms3 = dto.Bb007Coms3,
                Bb007Coms4 = dto.Bb007Coms4,
                Bb007Coms5 = dto.Bb007Coms5,
                Bb007Basecomicms = dto.Bb007Basecomicms,
                Bb007Basecomicmsret = dto.Bb007Basecomicmsret,
                Bb007Basecomipi = dto.Bb007Basecomipi,
                Bb007Basecomfrete = dto.Bb007Basecomfrete,
                Bb007Basecomacrfinan = dto.Bb007Basecomacrfinan,
                Bb007Basecomdespesas = dto.Bb007Basecomdespesas,
                Bb007Basecomseguro = dto.Bb007Basecomseguro,
                Bb007Maxdescvenda = dto.Bb007Maxdescvenda,
                Bb007Codgccusto = dto.Bb007Codgccusto,
                Bb007Codgalmox = dto.Bb007Codgalmox,
                Bb007Codgatividade = dto.Bb007Codgatividade,
                Bb007Senha = dto.Bb007Senha,
                Bb007Nomebanco = dto.Bb007Nomebanco,
                Bb007Agencia = dto.Bb007Agencia,
                Bb007Conta = dto.Bb007Conta,
                Bb007Coreregistro = dto.Bb007Coreregistro,
                Bb007Vinculocliente = dto.Bb007Vinculocliente,
                Bb007Observacao = dto.Bb007Observacao,
                Bb007Nrohandheld = dto.Bb007Nrohandheld,
                Bb007Senhahandheld = dto.Bb007Senhahandheld,
                Bb007Handheldsuperv = dto.Bb007Handheldsuperv,
                Bb007Imphandheld = dto.Bb007Imphandheld,
                Bb007Nomeusuario = dto.Bb007Nomeusuario,
                Bb031Funcaoid = dto.Bb031Funcaoid,
                Bb032Cargoid = dto.Bb032Cargoid,
                Bb007Dtadmissao = dto.Bb007Dtadmissao.ConverteStringVaziaParaDataNula(),
                Bb007Dtdemissao = dto.Bb007Dtdemissao.ConverteStringVaziaParaDataNula(),
                Bb007Codgregiao = dto.Bb007Codgregiao,
                Bb007Faixaautorizacao = dto.Bb007Faixaautorizacao,
                Bb007Ccustoid = dto.Bb007Ccustoid,
                Bb007Almoxid = dto.Bb007Almoxid,
                //Empresaid = dto.Empresaid,
                Bb007Isactive = true,
                Bb007Contafornid = dto.Bb007Contafornid,
                Bb007Cpf = dto.Bb007Cpf
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB007 ToDtoGet(this CSICP_BB007 entity)
        {
            return new Dto_GetBB007
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                //Bb007Filial = entity.Bb007Filial,
                Bb007Codigo = entity.Bb007Codigo,
                Bb007Responsavel = entity.Bb007Responsavel,
                Bb007Nomereduzido = entity.Bb007Nomereduzido,
                Bb007Classificacao = entity.Bb007Classificacao,
                Bb007UsuarioId = entity.Bb007UsuarioId,
                Bb007Codgsupervisor = entity.Bb007Codgsupervisor,
                Bb007Codggerente = entity.Bb007Codggerente,
                Bb007Geracpagar = entity.Bb007Geracpagar,
                Bb007Coms1 = entity.Bb007Coms1,
                Bb007Coms2 = entity.Bb007Coms2,
                Bb007Coms3 = entity.Bb007Coms3,
                Bb007Coms4 = entity.Bb007Coms4,
                Bb007Coms5 = entity.Bb007Coms5,
                Bb007Basecomicms = entity.Bb007Basecomicms,
                Bb007Basecomicmsret = entity.Bb007Basecomicmsret,
                Bb007Basecomipi = entity.Bb007Basecomipi,
                Bb007Basecomfrete = entity.Bb007Basecomfrete,
                Bb007Basecomacrfinan = entity.Bb007Basecomacrfinan,
                Bb007Basecomdespesas = entity.Bb007Basecomdespesas,
                Bb007Basecomseguro = entity.Bb007Basecomseguro,
                Bb007Maxdescvenda = entity.Bb007Maxdescvenda,
                Bb007Codgccusto = entity.Bb007Codgccusto,
                Bb007Codgalmox = entity.Bb007Codgalmox,
                Bb007Codgatividade = entity.Bb007Codgatividade,
                Bb007Senha = entity.Bb007Senha,
                Bb007Nomebanco = entity.Bb007Nomebanco,
                Bb007Agencia = entity.Bb007Agencia,
                Bb007Conta = entity.Bb007Conta,
                Bb007Coreregistro = entity.Bb007Coreregistro,
                Bb007Vinculocliente = entity.Bb007Vinculocliente,
                Bb007Observacao = entity.Bb007Observacao,
                Bb007Nrohandheld = entity.Bb007Nrohandheld,
                Bb007Senhahandheld = entity.Bb007Senhahandheld,
                Bb007Handheldsuperv = entity.Bb007Handheldsuperv,
                Bb007Imphandheld = entity.Bb007Imphandheld,
                Bb007Nomeusuario = entity.Bb007Nomeusuario,
                Bb031Funcaoid = entity.Bb031Funcaoid,
                Bb032Cargoid = entity.Bb032Cargoid,
                Bb007Dtadmissao = entity.Bb007Dtadmissao,
                Bb007Dtdemissao = entity.Bb007Dtdemissao,
                Bb007Codgregiao = entity.Bb007Codgregiao,
                Bb007Faixaautorizacao = entity.Bb007Faixaautorizacao,
                Bb007Ccustoid = entity.Bb007Ccustoid,
                Bb007Almoxid = entity.Bb007Almoxid,
                Empresaid = entity.Empresaid,
                Bb007Isactive = entity.Bb007Isactive,
                Bb007Contafornid = entity.Bb007Contafornid,
                Bb007Cpf = entity.Bb007Cpf,
                NavBb007Ccusto = entity.Bb007Ccusto?.ToDtoGet(),
                NavBb007CodggerenteNavigation = entity.Bb007CodggerenteNavigation?.ToDtoGetSimples(),
                NavBb007CodgsupervisorNavigation = entity.Bb007CodgsupervisorNavigation?.ToDtoGetSimples(),
                NavBb031Funcao = entity.Bb031Funcao?.ToDtoGet(),
                NavBb032Cargo = entity.Bb032Cargo?.ToDtoGet(),
                NavBb001Exibicao = entity.Bb001Empresa?.ToDtoGetSimples()
            };
        }

        public static Dto_GetBB007SemListSimples ToDtoGetSimples(this CSICP_BB007 entity)
        {
            return new Dto_GetBB007SemListSimples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                //Bb007Filial = entity.Bb007Filial,
                Bb007Codigo = entity.Bb007Codigo,
                Bb007Responsavel = entity.Bb007Responsavel,
                //Bb007Nomereduzido = entity.Bb007Nomereduzido,

            };
        }


        public static Dto_GetBB007SemList ToDtoGetSemList(this CSICP_BB007 entity)
        {
            return new Dto_GetBB007SemList
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                //Bb007Filial = entity.Bb007Filial,
                Bb007Codigo = entity.Bb007Codigo,
                Bb007Responsavel = entity.Bb007Responsavel,
                Bb007Nomereduzido = entity.Bb007Nomereduzido,
                Bb007Classificacao = entity.Bb007Classificacao,
                Bb007UsuarioId = entity.Bb007UsuarioId,
                Bb007Codgsupervisor = entity.Bb007Codgsupervisor,
                Bb007Codggerente = entity.Bb007Codggerente,
                Bb007Geracpagar = entity.Bb007Geracpagar,
                Bb007Coms1 = entity.Bb007Coms1,
                Bb007Coms2 = entity.Bb007Coms2,
                Bb007Coms3 = entity.Bb007Coms3,
                Bb007Coms4 = entity.Bb007Coms4,
                Bb007Coms5 = entity.Bb007Coms5,
                Bb007Basecomicms = entity.Bb007Basecomicms,
                Bb007Basecomicmsret = entity.Bb007Basecomicmsret,
                Bb007Basecomipi = entity.Bb007Basecomipi,
                Bb007Basecomfrete = entity.Bb007Basecomfrete,
                Bb007Basecomacrfinan = entity.Bb007Basecomacrfinan,
                Bb007Basecomdespesas = entity.Bb007Basecomdespesas,
                Bb007Basecomseguro = entity.Bb007Basecomseguro,
                Bb007Maxdescvenda = entity.Bb007Maxdescvenda,
                Bb007Codgccusto = entity.Bb007Codgccusto,
                Bb007Codgalmox = entity.Bb007Codgalmox,
                Bb007Codgatividade = entity.Bb007Codgatividade,
                Bb007Senha = entity.Bb007Senha,
                Bb007Nomebanco = entity.Bb007Nomebanco,
                Bb007Agencia = entity.Bb007Agencia,
                Bb007Conta = entity.Bb007Conta,
                Bb007Coreregistro = entity.Bb007Coreregistro,
                Bb007Vinculocliente = entity.Bb007Vinculocliente,
                Bb007Observacao = entity.Bb007Observacao,
                Bb007Nrohandheld = entity.Bb007Nrohandheld,
                Bb007Senhahandheld = entity.Bb007Senhahandheld,
                Bb007Handheldsuperv = entity.Bb007Handheldsuperv,
                Bb007Imphandheld = entity.Bb007Imphandheld,
                Bb007Nomeusuario = entity.Bb007Nomeusuario,
                Bb031Funcaoid = entity.Bb031Funcaoid,
                Bb032Cargoid = entity.Bb032Cargoid,
                Bb007Dtadmissao = entity.Bb007Dtadmissao,
                Bb007Dtdemissao = entity.Bb007Dtdemissao,
                Bb007Codgregiao = entity.Bb007Codgregiao,
                Bb007Faixaautorizacao = entity.Bb007Faixaautorizacao,
                Bb007Ccustoid = entity.Bb007Ccustoid,
                Bb007Almoxid = entity.Bb007Almoxid,
                Empresaid = entity.Empresaid,
                Bb007Isactive = entity.Bb007Isactive,
                Bb007Contafornid = entity.Bb007Contafornid,
                Bb007Cpf = entity.Bb007Cpf,
                NavBb007Ccusto = entity.Bb007Ccusto?.ToDtoGet(),
                NavBb007CodggerenteNavigation = entity.Bb007CodggerenteNavigation?.ToDtoGetSimples(),
                NavBb007CodgsupervisorNavigation = entity.Bb007CodgsupervisorNavigation?.ToDtoGetSimples(),
                NavBb031Funcao = entity.Bb031Funcao?.ToDtoGet(),
                NavBb032Cargo = entity.Bb032Cargo?.ToDtoGet(),
                NavBb001Exibicao = entity.Bb001Empresa?.ToDtoGetSimples()
            };
        }
    }
}

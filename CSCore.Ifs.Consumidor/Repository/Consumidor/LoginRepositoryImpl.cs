using CSCore.Domain;
using CSCore.Domain.Interfaces.Consumidor;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Consumidor.Repository.Consumidor
{
    public class LoginRepositoryImpl(AppDbContext appDbContext) : ILoginRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_BB012> GetContaParaLogin(string Prm_Codigo_Conta, string Prm_Chave_Acesso, int tenant)
        {
            IQueryable<CSICP_BB01202> queryBB1202 = CriaQueryBB1202Login();
            queryBB1202 = queryBB1202.Where(e => e.TenantId == tenant);

            //if (EhEmail(Prm_Codigo_Conta)) queryBB1202 = queryBB1202.Where(e => e.CSNav_BB012!.Bb012Email!.Equals(Prm_Codigo_Conta));
            if (EhCPF(Prm_Codigo_Conta)) queryBB1202 = queryBB1202.Where(e => e.Bb012Cpf == Decimal.Parse(Prm_Codigo_Conta));
            if (EhCnpj(Prm_Codigo_Conta)) queryBB1202 = queryBB1202.Where(e => e.Bb012Cnpj!.Equals(Prm_Codigo_Conta));

            CSICP_BB01202? cadastroBB01202Encontrado = await queryBB1202.FirstOrDefaultAsync();

            if (cadastroBB01202Encontrado == null) throw new KeyNotFoundException("Cadastro não encontrado no sistema!");

            IQueryable<CSICP_BB012> queryBB012 = GetContaPadrao(cadastroBB01202Encontrado.Id, tenant);

            CSICP_BB012? cSICP_BB012 = await queryBB012.FirstOrDefaultAsync();

            if (cSICP_BB012 == null) throw new KeyNotFoundException("Cadastro nao encontrado!");

            if (cSICP_BB012.Bb012Keyacess != Prm_Chave_Acesso)
            {
                throw new Exception("Chave de acesso inválida!");
            }

            return cSICP_BB012;
        }


        public async Task<CSICP_BB012?> GetContaParaAtualizarDeletar(string BB012_ID, int tenant)
        {
            IQueryable<CSICP_BB012> cSICP_BB012s = GetContaPadrao(BB012_ID, tenant);
            return await cSICP_BB012s.FirstOrDefaultAsync();
        }

        private IQueryable<CSICP_BB012> GetContaPadrao(string Prm_Conta_ID, int tenant)
        {
            return from _get_bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   where _get_bb012.Bb012IsActive == true
                   where _get_bb012.Id == Prm_Conta_ID
                   where _get_bb012.TenantId == tenant


                   join _get_bb01206 in _appDbContext.OsusrE9aCsicpBb01206s
                   on _get_bb012.Id equals _get_bb01206.Bb012Id into _get_bb016_join
                   from _get_bb01206 in _get_bb016_join.DefaultIfEmpty()

                   join _get_bb01202 in _appDbContext.OsusrE9aCsicpBb01202s
                      on _get_bb012.Id equals _get_bb01202.Id into _get_bb01202_join
                   from _get_bb01202 in _get_bb01202_join.DefaultIfEmpty()

                   join _get_bb01201 in _appDbContext.OsusrE9aCsicpBb01201s
                     on _get_bb012.Id equals _get_bb01201.Id into _get_bb01201_join
                   from _get_bb01201 in _get_bb01201_join.DefaultIfEmpty()

                   select new CSICP_BB012
                   {

                       TenantId = _get_bb012.TenantId,
                       Id = _get_bb012.Id,
                       Bb012Codigo = _get_bb012.Bb012Codigo,
                       Bb012NomeCliente = _get_bb012.Bb012NomeCliente,
                       Bb012NomeFantasia = _get_bb012.Bb012NomeFantasia,
                       Bb012DataAniversario = _get_bb012.Bb012DataAniversario,
                       Bb012DataCadastro = _get_bb012.Bb012DataCadastro,
                       Bb012Telefone = _get_bb012.Bb012Telefone,
                       Bb012Faxcelular = _get_bb012.Bb012Faxcelular,
                       Bb012HomePage = _get_bb012.Bb012HomePage,
                       Bb012Email = _get_bb012.Bb012Email,
                       Bb012DataEntradaSit = _get_bb012.Bb012DataEntradaSit,
                       Bb012DataSaidaSit = _get_bb012.Bb012DataSaidaSit,
                       Bb012Descricao = _get_bb012.Bb012Descricao,
                       Bb012IsActive = _get_bb012.Bb012IsActive,
                       Bb012TipoContaId = _get_bb012.Bb012TipoContaId,
                       Bb012GrupocontaId = _get_bb012.Bb012GrupocontaId,
                       Bb012ClassecontaId = _get_bb012.Bb012ClassecontaId,
                       Bb012StatuscontaId = _get_bb012.Bb012StatuscontaId,
                       Bb012SitContaId = _get_bb012.Bb012SitContaId,
                       Bb012ModrelacaoId = _get_bb012.Bb012ModrelacaoId,
                       Bb012Sequence = _get_bb012.Bb012Sequence,
                       Bb012Dultalteracao = _get_bb012.Bb012Dultalteracao,
                       Bb012Estabcadid = _get_bb012.Bb012Estabcadid,
                       Bb012Keyacess = _get_bb012.Bb012Keyacess,
                       Bb012IdIndicador = _get_bb012.Bb012IdIndicador,
                       Bb012Countappmcon = _get_bb012.Bb012Countappmcon,
                       Bb012Oricadastroid = _get_bb012.Bb012Oricadastroid,

                       OsusrE9aCsicpBb01206 = _get_bb01206 != null ? new CSICP_BB01206
                       {
                           TenantId = _get_bb01206.TenantId,
                           Id = _get_bb01206.Id,
                           Bb012Id = _get_bb01206.Bb012Id,
                           Bb012jEnderecoid = _get_bb01206.Bb012jEnderecoid,
                           Bb012Logradouro = _get_bb01206.Bb012Logradouro,
                           Bb012Numero = _get_bb01206.Bb012Numero,
                           Bb012Complemento = _get_bb01206.Bb012Complemento,
                           Bb012Codgbairro = _get_bb01206.Bb012Codgbairro,
                           Bb012Bairro = _get_bb01206.Bb012Bairro,
                           Bb012CodigoCidade = _get_bb01206.Bb012CodigoCidade,
                           Bb012Uf = _get_bb01206.Bb012Uf,
                           Bb012Cep = _get_bb01206.Bb012Cep,
                           Bb012CodigoPais = _get_bb01206.Bb012CodigoPais,
                           Bb012EntregaLogradouro = _get_bb01206.Bb012EntregaLogradouro,
                           Bb012EntregaNumero = _get_bb01206.Bb012EntregaNumero,
                           Bb012EntregaComplement = _get_bb01206.Bb012EntregaComplement,
                           Bb012EntregaCodgbairro = _get_bb01206.Bb012EntregaCodgbairro,
                           Bb012EntregaBairro = _get_bb01206.Bb012EntregaBairro,
                           Bb012EntregaCodCidade = _get_bb01206.Bb012EntregaCodCidade,
                           Bb012EntregaUf = _get_bb01206.Bb012EntregaUf,
                           Bb012EntregaCep = _get_bb01206.Bb012EntregaCep,
                           Bb012EntregaPais = _get_bb01206.Bb012EntregaPais,
                           Bb012Perimetro = _get_bb01206.Bb012Perimetro,
                           Bb012EntregaPerimetro = _get_bb01206.Bb012EntregaPerimetro,
                           Bb012Telefone = _get_bb01206.Bb012Telefone,
                           Bb012Celular = _get_bb01206.Bb012Celular,
                           Bb012Email = _get_bb01206.Bb012Email,
                       } : null,
                       Nav_BB01202 = _get_bb01202 != null ? new CSICP_BB01202
                       {
                           TenantId = _get_bb01202.TenantId,
                           Id = _get_bb01202.Id,
                           Bb012Cnpj = _get_bb01202.Bb012Cnpj,
                           Bb012Inscestadual = _get_bb01202.Bb012Inscestadual,
                           Bb012Suframa = _get_bb01202.Bb012Suframa,
                           Bb012Regsuframavalido = _get_bb01202.Bb012Regsuframavalido,
                           Bb012Regjuntacomercial = _get_bb01202.Bb012Regjuntacomercial,
                           Bb012Dataregjunta = _get_bb01202.Bb012Dataregjunta,
                           Bb012Patrimonio = _get_bb01202.Bb012Patrimonio,
                           Bb012CapitalSocial = _get_bb01202.Bb012CapitalSocial,
                           Bb012Cpf = _get_bb01202.Bb012Cpf,
                           Bb012Rg = _get_bb01202.Bb012Rg,
                           Bb012Complementorg = _get_bb01202.Bb012Complementorg,
                           Bb012Emissaorg = _get_bb01202.Bb012Emissaorg,
                           Bb012Pis = _get_bb01202.Bb012Pis,
                           Bb012Residedesde = _get_bb01202.Bb012Residedesde,
                           Bb012Nrodependentes = _get_bb01202.Bb012Nrodependentes,
                           Bb012Empadmissao = _get_bb01202.Bb012Empadmissao,
                           Bb012EmpProfissao = _get_bb01202.Bb012EmpProfissao,
                           Bb012Valorremuneracao = _get_bb01202.Bb012Valorremuneracao,
                           Bb012Outrosrendimentos = _get_bb01202.Bb012Outrosrendimentos,
                           Bb012Origemoutrosrend = _get_bb01202.Bb012Origemoutrosrend,
                           Bb012InscEstSniId = _get_bb01202.Bb012InscEstSniId,
                           Bb012SexoId = _get_bb01202.Bb012SexoId,
                           Bb012EstadocivilId = _get_bb01202.Bb012EstadocivilId,
                           Bb012TipodomicilioId = _get_bb01202.Bb012TipodomicilioId,
                           Bb012Compresid01Id = _get_bb01202.Bb012Compresid01Id,
                           Bb012Compresid02Id = _get_bb01202.Bb012Compresid02Id,
                           Bb012GescolaridadeId = _get_bb01202.Bb012GescolaridadeId,
                           Bb012OcupacaoId = _get_bb01202.Bb012OcupacaoId,
                           Bb012NaturaldeId = _get_bb01202.Bb012NaturaldeId,
                           Bb012TptributacaoId = _get_bb01202.Bb012TptributacaoId,
                           Bb012IdentEstrangeiro = _get_bb01202.Bb012IdentEstrangeiro,
                           Bb012Empresa = _get_bb01202.Bb012Empresa,
                           Bb012EmpEndereco = _get_bb01202.Bb012EmpEndereco,
                           Bb012EmpGrupoId = _get_bb01202.Bb012EmpGrupoId,
                           Bb012Motdesoneracaoid = _get_bb01202.Bb012Motdesoneracaoid,
                       } : null,
                       OsusrE9aCsicpBb01201 = _get_bb01201 != null ? new CSICP_BB01201
                       {

                           TenantId = _get_bb01201.TenantId,
                           Id = _get_bb01201.Id,
                           Bb012Zonaid = _get_bb01201.Bb012Zonaid,
                           Bb012Atividadeid = _get_bb01201.Bb012Atividadeid,
                           Bb012Limitecredito = _get_bb01201.Bb012Limitecredito,
                           Bb012Limcreditosecun = _get_bb01201.Bb012Limcreditosecun,
                           Bb012Limiteccredito = _get_bb01201.Bb012Limiteccredito,
                           Bb012Diavenctocartao = _get_bb01201.Bb012Diavenctocartao,
                           Bb012Contaconvenio = _get_bb01201.Bb012Contaconvenio,
                           Bb012Diaspagtoconv = _get_bb01201.Bb012Diaspagtoconv,
                           Bb012Padraobancoid = _get_bb01201.Bb012Padraobancoid,
                           Bb012Bcoagenciaconta = _get_bb01201.Bb012Bcoagenciaconta,
                           Bb012Revenda = _get_bb01201.Bb012Revenda,
                           Bb012TaxaAdministracaoCon = _get_bb01201.Bb012TaxaAdministracaoCon,
                           Bb012Requisicao = _get_bb01201.Bb012Requisicao,
                           Bb012Contacontabil = _get_bb01201.Bb012Contacontabil,
                           Bb012Historicocontabilid = _get_bb01201.Bb012Historicocontabilid,
                           Bb012Contratocartao = _get_bb01201.Bb012Contratocartao,
                           Bb012Datacontratocartao = _get_bb01201.Bb012Datacontratocartao,
                           Bb012Dtvalidadecartao = _get_bb01201.Bb012Dtvalidadecartao,
                           Bb012Modalidadecredcartao = _get_bb01201.Bb012Modalidadecredcartao,
                           Bb012Perclimcredito = _get_bb01201.Bb012Perclimcredito,
                           Bb012Prazoentregafornec = _get_bb01201.Bb012Prazoentregafornec,
                           Bb012Condpagtofornec = _get_bb01201.Bb012Condpagtofornec,
                           Bb012Natoperacaoid = _get_bb01201.Bb012Natoperacaoid,
                           Bb012Condpagtoid = _get_bb01201.Bb012Condpagtoid,
                           Bb012Textonotaid = _get_bb01201.Bb012Textonotaid,
                           Bb012GrauRisco = _get_bb01201.Bb012GrauRisco,
                           Bb012ClasseCredito = _get_bb01201.Bb012ClasseCredito,
                           Bb012Dtvalidcadastro = _get_bb01201.Bb012Dtvalidcadastro,
                           Bb012PercIcms = _get_bb01201.Bb012PercIcms,
                           Bb012Codgcategoria = _get_bb01201.Bb012Codgcategoria,
                           Bb012Categoriaid = _get_bb01201.Bb012Categoriaid,
                           Bb012Limitecredparcela = _get_bb01201.Bb012Limitecredparcela,
                           Bb012NumUltFatura = _get_bb01201.Bb012NumUltFatura,
                           Bb012Totcompracarnet = _get_bb01201.Bb012Totcompracarnet,
                           Bb012ValorEntrada = _get_bb01201.Bb012ValorEntrada,
                           Bb012MaiorCompra = _get_bb01201.Bb012MaiorCompra,
                           Bb012MenorCompra = _get_bb01201.Bb012MenorCompra,
                           Bb012Totdiasatraso = _get_bb01201.Bb012Totdiasatraso,
                           Bb012MaiorAtraso = _get_bb01201.Bb012MaiorAtraso,
                           Bb012MenorAtraso = _get_bb01201.Bb012MenorAtraso,
                           Bb012Mediadeatraso = _get_bb01201.Bb012Mediadeatraso,
                           Bb012Maiorsaldo = _get_bb01201.Bb012Maiorsaldo,
                           Bb012Numcompras = _get_bb01201.Bb012Numcompras,
                           Bb012Dtprimcompra = _get_bb01201.Bb012Dtprimcompra,
                           Bb012Dtultcompra = _get_bb01201.Bb012Dtultcompra,
                           Bb012Vlrmaiorpagto = _get_bb01201.Bb012Vlrmaiorpagto,
                           Bb012Numpagtodia = _get_bb01201.Bb012Numpagtodia,
                           Bb012Numpagtoatraso = _get_bb01201.Bb012Numpagtoatraso,
                           Bb012Saldodevedor = _get_bb01201.Bb012Saldodevedor,
                           Bb012Saldopedido = _get_bb01201.Bb012Saldopedido,
                           Bb012Qtdtitprotestado = _get_bb01201.Bb012Qtdtitprotestado,
                           Bb012Ultprotesto = _get_bb01201.Bb012Ultprotesto,
                           Bb012Qtdchqdevolvido = _get_bb01201.Bb012Qtdchqdevolvido,
                           Bb012Ultchqdevolvido = _get_bb01201.Bb012Ultchqdevolvido,
                           Bb012ConvenioId = _get_bb01201.Bb012ConvenioId,
                           Bb012TipogeracaoId = _get_bb01201.Bb012TipogeracaoId,
                           Bb012SitespecialId = _get_bb01201.Bb012SitespecialId,
                           Bb012Entmtgrotaid = _get_bb01201.Bb012Entmtgrotaid,
                           Bb012Vendarotaid = _get_bb01201.Bb012Vendarotaid,
                           Bb012Diavenctoid = _get_bb01201.Bb012Diavenctoid,
                           Bb012Codgbcodebconta = _get_bb01201.Bb012Codgbcodebconta,
                       } : null

                   };
        }

        private IQueryable<CSICP_BB01202> CriaQueryBB1202Login()
        {
            return from _get_bb01202 in _appDbContext.OsusrE9aCsicpBb01202s

                   join _get_bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   on _get_bb01202.Id equals _get_bb012.Id into _get_bb012_join
                   from _get_bb012 in _get_bb012_join.DefaultIfEmpty()

                   join _get_bb01206 in _appDbContext.OsusrE9aCsicpBb01206s
                   on _get_bb012.Id equals _get_bb01206.Bb012Id into _get_bb016_join
                   from _get_bb01206 in _get_bb016_join.DefaultIfEmpty()

                   where _get_bb012.Bb012IsActive == true


                   select new CSICP_BB01202
                   {
                       TenantId = _get_bb01202.TenantId,
                       Id = _get_bb01202.Id,
                       Bb012Cnpj = _get_bb01202.Bb012Cnpj,
                       Bb012Inscestadual = _get_bb01202.Bb012Inscestadual,
                       Bb012Suframa = _get_bb01202.Bb012Suframa,
                       Bb012Regsuframavalido = _get_bb01202.Bb012Regsuframavalido,
                       Bb012Regjuntacomercial = _get_bb01202.Bb012Regjuntacomercial,
                       Bb012Dataregjunta = _get_bb01202.Bb012Dataregjunta,
                       Bb012Patrimonio = _get_bb01202.Bb012Patrimonio,
                       Bb012CapitalSocial = _get_bb01202.Bb012CapitalSocial,
                       Bb012Cpf = _get_bb01202.Bb012Cpf,
                       Bb012Rg = _get_bb01202.Bb012Rg,
                       Bb012Complementorg = _get_bb01202.Bb012Complementorg,
                       Bb012Emissaorg = _get_bb01202.Bb012Emissaorg,
                       Bb012Pis = _get_bb01202.Bb012Pis,
                       Bb012Residedesde = _get_bb01202.Bb012Residedesde,
                       Bb012Nrodependentes = _get_bb01202.Bb012Nrodependentes,
                       Bb012Empadmissao = _get_bb01202.Bb012Empadmissao,
                       Bb012EmpProfissao = _get_bb01202.Bb012EmpProfissao,
                       Bb012Valorremuneracao = _get_bb01202.Bb012Valorremuneracao,
                       Bb012Outrosrendimentos = _get_bb01202.Bb012Outrosrendimentos,
                       Bb012Origemoutrosrend = _get_bb01202.Bb012Origemoutrosrend,
                       Bb012InscEstSniId = _get_bb01202.Bb012InscEstSniId,
                       Bb012SexoId = _get_bb01202.Bb012SexoId,
                       Bb012EstadocivilId = _get_bb01202.Bb012EstadocivilId,
                       Bb012TipodomicilioId = _get_bb01202.Bb012TipodomicilioId,
                       Bb012Compresid01Id = _get_bb01202.Bb012Compresid01Id,
                       Bb012Compresid02Id = _get_bb01202.Bb012Compresid02Id,
                       Bb012GescolaridadeId = _get_bb01202.Bb012GescolaridadeId,
                       Bb012OcupacaoId = _get_bb01202.Bb012OcupacaoId,
                       Bb012NaturaldeId = _get_bb01202.Bb012NaturaldeId,
                       Bb012TptributacaoId = _get_bb01202.Bb012TptributacaoId,
                       Bb012IdentEstrangeiro = _get_bb01202.Bb012IdentEstrangeiro,
                       Bb012Empresa = _get_bb01202.Bb012Empresa,
                       Bb012EmpEndereco = _get_bb01202.Bb012EmpEndereco,
                       Bb012EmpGrupoId = _get_bb01202.Bb012EmpGrupoId,
                       Bb012Motdesoneracaoid = _get_bb01202.Bb012Motdesoneracaoid
                   };
        }


        private static bool EhCnpj(string Prm_Codigo_Conta)
        {
            return Prm_Codigo_Conta.Length == 14 || Prm_Codigo_Conta.Length > 11;
        }

        private static bool EhCPF(string Prm_Codigo_Conta)
        {
            return Prm_Codigo_Conta.Length == 11 || Prm_Codigo_Conta.Length == 10;
        }

    }
}


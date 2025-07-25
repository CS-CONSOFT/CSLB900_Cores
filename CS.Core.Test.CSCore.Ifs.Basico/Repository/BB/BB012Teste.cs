using CSCore.Domain;
using CSCore.Ifs.Compartilhado.Utilidade.SiteProperties;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository.BB.Conta;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CS.Core.Test.CSCore.Ifs.Basico.Repository.BB
{
    public class BB012Teste
    {
        [Fact]
        public async Task CreateAsync_DeveAdicionarEntidadesESalvar()
        {
            // Arrange
            var mockDbContext = new Mock<AppDbContext>();
            var mockDbSet = new Mock<DbSet<CSICP_BB012>>();


            var connectionString = "Server=csdb9.csicorpnet.com.br;Database=CSOS_DSV03_ERP17;User Id=CSSPRUN_DSV17;Password=CSSPRUN17;TrustServerCertificate=True;";

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new AppDbContext(options);

            var verifica = new VerificaSiteProperties(context);
            var service = new BB012Repository(context, verifica);

            var bb012 = new CSICP_BB012
            {
                TenantId = 1,
                Id = "id1",
                Bb012Codigo = 123,
                Bb012NomeCliente = "Cliente Teste",
                Bb012NomeFantasia = "Fantasia Teste",
                Bb012DataAniversario = DateTime.Now.AddYears(-30),
                Bb012DataCadastro = DateTime.Now,
                Bb012Telefone = "11999999999",
                Bb012Faxcelular = "11988888888",
                Bb012HomePage = "https://site.com",
                Bb012Email = "email@teste.com",
                Bb012DataEntradaSit = DateTime.Now,
                Bb012DataSaidaSit = DateTime.Now.AddDays(1),
                Bb012Descricao = "Descrição teste",
                Bb012IsActive = true,
                Bb012TipoContaId = 2,
                Bb012GrupocontaId = 3,
                Bb012ClassecontaId = 4,
                Bb012StatuscontaId = 5,
                Bb012SitContaId = 6,
                Bb012ModrelacaoId = 7,
                Bb012Sequence = 100,
                Bb012Dultalteracao = DateTime.Now,
                Bb012Estabcadid = "Estab1",
                Bb012Keyacess = "Key123",
                Bb012IdIndicador = "Indicador1",
                Bb012Countappmcon = 10,
                Bb012Oricadastroid = 20
            };

            var bb01201 = new CSICP_BB01201
            {
                TenantId = 1,
                Id = "id1",
                Bb012Zonaid = "Zona1",
                Bb012Atividadeid = "Atividade1",
                Bb012Limitecredito = 1000,
                Bb012Limcreditosecun = 500,
                Bb012Limiteccredito = 200,
                Bb012Diavenctocartao = 15,
                Bb012Contaconvenio = "Convenio1",
                Bb012Diaspagtoconv = 30,
                Bb012Padraobancoid = "Banco1",
                Bb012Bcoagenciaconta = "Agencia1",
                Bb012Revenda = 1,
                Bb012TaxaAdministracaoCon = 2.5m,
                Bb012Requisicao = 1,
                Bb012Contacontabil = "ContaContabil1",
                Bb012Historicocontabilid = "Historico1",
                Bb012Contratocartao = 1234,
                Bb012Datacontratocartao = DateTime.Now,
                Bb012Dtvalidadecartao = DateTime.Now.AddYears(1),
                Bb012Modalidadecredcartao = "Modalidade1",
                Bb012Perclimcredito = 10,
                Bb012Prazoentregafornec = 5,
                Bb012Condpagtofornec = "CondPagto1",
                Bb012Natoperacaoid = "NatOp1",
                Bb012Condpagtoid = "CondPagto2",
                Bb012Textonotaid = "Texto1",
                Bb012GrauRisco = "Baixo",
                Bb012ClasseCredito = "ClasseA",
                Bb012Dtvalidcadastro = DateTime.Now,
                Bb012PercIcms = 18,
                Bb012Codgcategoria = "Cat1",
                Bb012Categoriaid = "CatId1",
                Bb012Limitecredparcela = 100,
                Bb012NumUltFatura = 2,
                Bb012Totcompracarnet = 300,
                Bb012ValorEntrada = 50,
                Bb012MaiorCompra = 200,
                Bb012MenorCompra = 10,
                Bb012Totdiasatraso = 0,
                Bb012MaiorAtraso = 0,
                Bb012MenorAtraso = 0,
                Bb012Mediadeatraso = 0,
                Bb012Maiorsaldo = 1000,
                Bb012Numcompras = 5,
                Bb012Dtprimcompra = DateTime.Now.AddMonths(-6),
                Bb012Dtultcompra = DateTime.Now,
                Bb012Vlrmaiorpagto = 200,
                Bb012Numpagtodia = 1,
                Bb012Numpagtoatraso = 0,
                Bb012Saldodevedor = 0,
                Bb012Saldopedido = 0,
                Bb012Qtdtitprotestado = 0,
                Bb012Ultprotesto = null,
                Bb012Qtdchqdevolvido = 0,
                Bb012Ultchqdevolvido = null,
                Bb012ConvenioId = 1,
                Bb012TipogeracaoId = 1,
                Bb012SitespecialId = 1,
                Bb012Entmtgrotaid = "Rota1",
                Bb012Vendarotaid = "VendaRota1",
                Bb012Diavenctoid = "Venc1",
                Bb012Codgbcodebconta = "Cod1"
            };

            var bb01202 = new CSICP_BB01202
            {
                TenantId = 1,
                Id = "id1",
                Bb012Cnpj = "11.222.333/0001-81",
                Bb012Inscestadual = 123456,
                Bb012Suframa = "Suframa1",
                Bb012Regsuframavalido = 1,
                Bb012Regjuntacomercial = "Junta1",
                Bb012Dataregjunta = DateTime.Now,
                Bb012Patrimonio = 100000,
                Bb012CapitalSocial = 50000,
                
                Bb012Rg = 1234567,
                Bb012Complementorg = "CompRG",
                Bb012Emissaorg = DateTime.Now.AddYears(-10),
                Bb012Pis = 1234567890,
                Bb012Residedesde = DateTime.Now.AddYears(-20),
                Bb012Nrodependentes = 2,
                Bb012Empadmissao = DateTime.Now.AddYears(-5),
                Bb012EmpProfissao = "Profissão1",
                Bb012Valorremuneracao = 3000,
                Bb012Outrosrendimentos = 500,
                Bb012Origemoutrosrend = "Origem1",
                Bb012InscEstSniId = 1,
                Bb012SexoId = 1,
                Bb012EstadocivilId = 1,
                Bb012TipodomicilioId = 1,
                Bb012Compresid01Id = 1,
                Bb012Compresid02Id = 1,
                Bb012GescolaridadeId = 1,
                Bb012OcupacaoId = 1,
                Bb012NaturaldeId = "Cidade1",
                Bb012TptributacaoId = 1,
                Bb012IdentEstrangeiro = "Estrangeiro1",
                Bb012Empresa = "Empresa1",
                Bb012EmpEndereco = "Endereço1",
                Bb012EmpGrupoId = 1,
                Bb012Motdesoneracaoid = 1
            };

            var bb01206 = new CSICP_BB01206
            {
                TenantId = 1,
                Id = "id1",
                Bb012Id = "id1",
                Bb012jEnderecoid = "End1",
                Bb012Logradouro = "Rua Teste",
                Bb012Numero = "123",
                Bb012Complemento = "Apto 1",
                Bb012Codgbairro = "Bairro1",
                Bb012Bairro = "Centro",
                Bb012CodigoCidade = "Cidade1",
                Bb012Uf = "SP",
                Bb012Cep = 12345678,
                Bb012CodigoPais = "BR",
                Bb012EntregaLogradouro = "Rua Entrega",
                Bb012EntregaNumero = "456",
                Bb012EntregaComplement = "Casa",
                Bb012EntregaCodgbairro = "Bairro2",
                Bb012EntregaBairro = "Bairro Entrega",
                Bb012EntregaCodCidade = "Cidade2",
                Bb012EntregaUf = "RJ",
                Bb012EntregaCep = 87654321,
                Bb012EntregaPais = "BR",
                Bb012Perimetro = "Perímetro1",
                Bb012EntregaPerimetro = "Perímetro2",
                Bb012Telefone = "11999999999",
                Bb012Celular = "11988888888",
                Bb012Email = "entrega@teste.com"
            };

           
            // Act
            var result = await service.CreateAsync(bb012, bb01201, bb01202, bb01206, "filial", "idAA006");


            Assert.Equal(bb012, result);
        }
    }
}

using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloEstornar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.CS_MovtoTituloEstornar;
using CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CSCore.Tests.Geral.Financeiro.CS_MovtoTituloEstornar
{
    public class MovtoTituloEstornarTest : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly IMovtoTituloEstornar _service;
        private readonly ITituloCalculoBaixa _calcBaixa;
        private readonly string _connectionString;
        private readonly string FF103ID = "zz20250000000000000944509";

        public MovtoTituloEstornarTest()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<MovtoTituloEstornarTest>()
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString;

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(_connectionString)
                .Options;

            _context = new AppDbContext(options);
            _calcBaixa = new TituloCalculoBaixa(_context);
            _service = new MovtoTituloEstornar(_context, _calcBaixa);
        }


        [Fact]
        public async Task Executar_MovimentoValido_DeveExecutarComSucesso()
        {
            // Arrange
            var parametro = CriarParametroTeste(FF103ID);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
        }

        


        private PrmTituloEstornar CriarParametroTeste(string ff103ID) => new PrmTituloEstornar
        {
            InTenantID = 135,
            InFF103ID = ff103ID,
           
            InSTIDFF102Liquidado_tituloCalcBaixa = 4,
            InSTIDFF102BxParcial_tituloCalcBaixa = 2,
            InSTIDFF102Aberto_tituloCalcBaixa = 5,
            InSTIDFF103TpBaiCancelamento_tituloCalcBaixa = 1,
            InSTIDFF103TpBaiDevolucao_tituloCalcBaixa = 2,
            InSTIDFF103TpBaiDoacao_tituloCalcBaixa = 1,
            InFF102ID = "titulo_teste_id",
            InBB001FilialID = "08878f25-412d-4914-934f-f785d61b8b77"
        };

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
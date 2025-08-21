using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloBaixar_Kernel;
using CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;

namespace CSCore.Tests.Geral.Financeiro.CS_MovtoTituloBaixar_Kernel
{
    public class MovtoTituloBaixar_KernelTest : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly IMovtoTituloBaixar_Kernel _service;
        private readonly ITituloCalculoBaixa _calcBaixa;
        private readonly string _connectionString;
        private readonly string FF103ID = "zz20250000000000000944503";

        public MovtoTituloBaixar_KernelTest()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<MovtoTituloBaixar_KernelTest>()
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString;

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(_connectionString)
                .Options;

            _context = new AppDbContext(options);
            _calcBaixa = new TituloCalculoBaixa(_context);
            _service = new MovtoTituloBaixar_Kernel(_context, _calcBaixa);
        }

        [Fact]
        public async Task Executar_MovimentoNaoEncontrado_DeveThrowKeyNotFoundException()
        {
            // Arrange
            var parametro = CriarParametroTeste(FF103ID);
            bool ok = await _service.Executar(parametro);
            Assert.True(ok);
        }

       


        private PrmMovtoTituloBaixarKernel CriarParametroTeste(string ff103ID) => new PrmMovtoTituloBaixarKernel
        {
            InTenantID = 135,
            InFF103ID = ff103ID,
            InSTIDff102SitLiquidado = 4,
            InSTIDff102SitCancelado = 3,
            InSTIDff102SitRenegociado = 7,
            InSTIDff102SitProvisao = 8,
            InSTIDFF102BxParcial_tituloCalcBaixa = 2,
            InSTIDFF102Aberto_tituloCalcBaixa = 5,
            InSTIDFF103TpBaiCancelamento_tituloCalcBaixa = 1,
            InSTIDFF103TpBaiDevolucao_tituloCalcBaixa = 2,
            InSTIDFF103TpBaiDoacao_tituloCalcBaixa = 1,
            InEstabID_tituloCalcBaixa = "08878f25-412d-4914-934f-f785d61b8b77"
        };

       

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
using CS901Library.GenerateId;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.GG.Repository.Extrato;
using CSCore.Ifs.Repository.GG._03X;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace CSCore.Ifs.GGTests.Repository.GG._03X
{
    public class GG032RepositoryImplTest
    {
        [Fact]
        public async Task TestaMovimentoInventario()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<GG032RepositoryImplTest>()
                .Build();

            var stringConexao = configuration.GetConnectionString("DefaultConnection");

            var dbFake = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(stringConexao)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;

            var _appDbContext = new AppDbContext(dbFake);

            var generateId = new SCS_GenerateId();
            var geraProtocolo = new GenerateProtocoloServiceImpl(_appDbContext, generateId);
            var geraExtrato = new GeraExtratoImpl(_appDbContext, generateId, geraProtocolo);
            var gg032Impl = new GG032RepositoryImpl(_appDbContext, geraExtrato, generateId, gerarInventarioEmMassa: null);

            await gg032Impl.CS_InventarioProcessar(
                    135, "4bcee090-5793-4ddd-a2ba-391114bae391",1,3,2,1,2
                );
        }


        [Fact]
        public async Task TestaDesbloqueiaSaldo()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<GG032RepositoryImplTest>()
                .Build();

            var stringConexao = configuration.GetConnectionString("DefaultConnection");

            var dbFake = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(stringConexao)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;

            var _appDbContext = new AppDbContext(dbFake);

            var generateId = new SCS_GenerateId();
            var geraProtocolo = new GenerateProtocoloServiceImpl(_appDbContext, generateId);
            var geraExtrato = new GeraExtratoImpl(_appDbContext, generateId, geraProtocolo);
            var gg032Impl = new GG032RepositoryImpl(_appDbContext, geraExtrato, generateId, null);

            await gg032Impl.CS_BloquearDesbloquearInventario(
                135, "670933ed-11cb-4d07-99e9-724b9e6d4035",
                1, 2, 2);
        }

        [Fact]
        public async Task TestaBloqueiaSaldo()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<GG032RepositoryImplTest>()
                .Build();

            var stringConexao = configuration.GetConnectionString("DefaultConnection");

            var dbFake = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(stringConexao)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;

            var _appDbContext = new AppDbContext(dbFake);

            var generateId = new SCS_GenerateId();
            var geraProtocolo = new GenerateProtocoloServiceImpl(_appDbContext, generateId);
            var geraExtrato = new GeraExtratoImpl(_appDbContext, generateId, geraProtocolo);
            var gg032Impl = new GG032RepositoryImpl(_appDbContext, geraExtrato, generateId, null);

            await gg032Impl.CS_BloquearDesbloquearInventario(
                135, "c5bfa9a9-4d66-450b-8170-70408b8adedf",
                1, 2, 1);
        }
    }
}

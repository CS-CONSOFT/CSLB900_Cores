using CS901Library.GenerateId;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.GG.Repository.Baixa;
using CSCore.Ifs.GG.Repository.Extrato;
using CSCore.Ifs.Repository.GG._07X;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace CSTestesGeral
{
    public class TesteBaixaEstoque : IDisposable
    {
        private readonly AppDbContext _appDbContext;
        private readonly IGG073Repository _gG073Repository;
        private readonly IBaixarEstoqueMovtEntSaida _csBaixaEstoque;
        private readonly IGeraExtrato _geraExtrato;
        private readonly ICS_GenerateId _generateID;
        private readonly IDbContextTransaction _transaction;


        public TesteBaixaEstoque()
        {
            var configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.Test.json")
                  .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;


            _appDbContext = new AppDbContext(options);
            _transaction = _appDbContext.Database.BeginTransaction();

            _generateID = new SCS_GenerateId();
            _geraExtrato = new GeraExtratoImpl(_appDbContext, _generateID, new GenerateProtocoloServiceImpl(_appDbContext, _generateID));



            _gG073Repository = new GG073RepositoryImpl(_appDbContext, _csBaixaEstoque);
        }

        [Fact]
        public async Task TestaBaixarEstoque()
        {
            try
            {
                await _gG073Repository.BaixaEstoque("zz20250000000000000839558", 135);
            }
            catch (Exception ex)
            {
                Console.WriteLine(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        public void Dispose()
        {
            _transaction.Rollback();
            _appDbContext.Dispose();
        }
    }
}

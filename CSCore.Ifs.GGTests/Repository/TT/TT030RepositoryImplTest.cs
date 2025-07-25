using CSCore.Ifs.Compartilhado.Utilidade.Excel;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.TT.TT0XX;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace CSCore.Ifs.GGTests.Repository.TT
{
    public class TT030RepositoryImplTest
    {

        [Fact]
        public async Task TesteExcel()
        {
            var context = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            var _appDbContext = new AppDbContext(context);


            var mock = new Mock<IExcel>();

            var tt030 = new TT030RepositoryImpl(_appDbContext, mock.Object);

        }

        [Fact]
        public async Task TesteCreateTT030()
        {
            var context = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            var _appDbContext = new AppDbContext(context);


            var mock = new Mock<IExcel>();

            var tt030 = new TT030RepositoryImpl(_appDbContext, mock.Object);

        }
    }
}


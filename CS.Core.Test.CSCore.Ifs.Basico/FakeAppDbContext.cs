using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CS.Core.Test.CSCore.Ifs.Basico
{
    public static class FakeAppDbContext
    {
        public static AppDbContext CreateFakeContext(string dbName = "FakeDB")
        {
            var op = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            return new AppDbContext(op);
        }
    }
}

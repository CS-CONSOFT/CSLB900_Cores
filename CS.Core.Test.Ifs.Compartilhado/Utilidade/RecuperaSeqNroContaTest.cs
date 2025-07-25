using CSCore.Domain;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace CSCore.Test.Ifs.Compartilhado.Utilidade
{

    public class RecuperaSeqNroContaTest
    {
        [Fact]
        public async Task Teste01()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDB")
                .Options;

            var context = new AppDbContext(options);

            context.OsusrE9aCsicpAa006s.Add(new CSICP_AA006
            {
                Id = "meuID",
                TenantId = 135,
                Aa006Filial = 0,
                Aa006Arquivo = "BB012",
                Aa006Ci = 8563,
                Aa006Filialid = "08878f25-412d-4914-934f-f785d61b8b77",
                Aa006Dataultcaptura = DateTime.UtcNow.ToLocalTime(),
                Aa006Circular = 1,
                Aa006Maxcircular = 99999999,
                Aa006CircularNavigation = null,
                FilialBB001 = null
            });

            context.E9ACSICP_BB001s.Add(new CSICP_BB001
            {
                Id = "08878f25-412d-4914-934f-f785d61b8b77",
                TenantId = 135,
                Bb001Codigoempresa = 88,
                Bb001Nomefantasia = "Filial Teste"
            });

            await context.SaveChangesAsync();

            string result = await RecuperaSeqNroConta.Get_SeqNroConta(context, 135,
                in_filialID: "08878f25-412d-4914-934f-f785d61b8b77",
                in_novoIdAA006: "novoIDAA006");

            Assert.Equal("0888563", result);
        }

        [Fact]
        public async Task Teste02()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDB")
                .Options;

            var context = new AppDbContext(options);

            context.E9ACSICP_BB001s.Add(new CSICP_BB001
            {
                Id = "08878f25-412d-4914-934f-f785d61b8b77",
                TenantId = 135,
                Bb001Codigoempresa = 88,
                Bb001Nomefantasia = "Filial Teste"
            });

            await context.SaveChangesAsync();

            string result = await RecuperaSeqNroConta.Get_SeqNroConta(context, 135,
                in_filialID: "08878f25-412d-4914-934f-f785d61b8b77",
                in_novoIdAA006: "novoIDAA006");

            Assert.Equal("880000001", result);
        }
    }
}


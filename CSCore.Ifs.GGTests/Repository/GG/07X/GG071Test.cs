using CS901Library.GenerateId;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.GG.Repository.BaixaSaldo;
using CSCore.Ifs.GG.Repository.Extrato;
using CSCore.Ifs.GG.Repository.GG.Saldo;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace CSCore.Ifs.GGTests.Repository.GG._07X
{
    public class GG071Test
    {
        private readonly AppDbContext _appDbContext;
        private readonly IGG071Repository _gg071Repo;
        private readonly IComparaSaldo _comparaSaldo;
        private readonly ICS_GenerateId generateID;
        private readonly IGeraExtrato _iGeraExtrato;
        private readonly IBaixaSaldo _baixaSaldo;

        public GG071Test(AppDbContext appDbContext)
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
            generateID = new SCS_GenerateId();
            _iGeraExtrato = new GeraExtratoImpl(_appDbContext, generateID, new GenerateProtocoloServiceImpl(appDbContext, generateID));
            _baixaSaldo = new BaixaSaldoImpl(_appDbContext, _iGeraExtrato);
            _comparaSaldo = new ComparaSaldo(_appDbContext, _baixaSaldo, _iGeraExtrato);
            //_gg071Repo = new GG071RepositoryImpl(_appDbContext, _comparaSaldo,);
        }

        [Fact]
        public async Task Deve_Passar_No_Teste()
        {
            //var idGG054_STA_ABERTO = 1;
            //var idGG054_STA_INVENTARIADO = 3;
            //var idcc081cd_criar = 1;
            //var id_gg032_tpinv_normal = 2;
            //var id_gg032_sta_concluido = 3;
            //var id_gg032_sta_solicitado = 2;

            //var prmgg032_protocolo = "";
            //var docInventario = "2020";
            //var usuarioID_SY001 = "59bd9971-31e5-4a0b-a7f2-a88ed5d7056b";

            //await _gg071Repo.CS_RI_Processa_Baixa(
            //    ,,,,,,,,,,,135
            //    );
        }
    }
}

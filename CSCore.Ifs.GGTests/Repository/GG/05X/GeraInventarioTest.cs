using CS901Library.GenerateId;
using CSCore.Domain.Interfaces.GG._05X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.Repository.GG._05X;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace CSCore.Ifs.GGTests.Repository.GG._05X
{
    public class GeraInventarioTest
    {
        private readonly AppDbContext _appDbContext;
        private readonly IGG054Repository _gg054Repo;
        private readonly ICS_GenerateId _generateID;
        private readonly IGenerateProtocolo _generateProtocolo;
        public GeraInventarioTest()
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
            _generateID = new SCS_GenerateId();
            _generateProtocolo = new GenerateProtocoloServiceImpl(_appDbContext, _generateID);
            _gg054Repo = new GG054RepositoryImpl(_appDbContext, _generateID, _generateProtocolo);
        }


        [Fact]
        public async Task Deve_Passar_No_Teste_Teste_GG054_GeraInventario()
        {
            var idGG054_STA_ABERTO = 1;
            var idGG054_STA_INVENTARIADO = 3;
            var idcc081cd_criar = 1;
            var id_gg032_tpinv_normal = 2;
            var id_gg032_sta_concluido = 3;
            var id_gg032_sta_solicitado = 2;

            var prmgg032_protocolo = "";
            var docInventario = "2020";
            var usuarioID_SY001 = "59bd9971-31e5-4a0b-a7f2-a88ed5d7056b";

            //await _gg054Repo.GerarInventario(135, idGG054_STA_ABERTO, docInventario,
            //    idcc081cd_criar, prmgg032_protocolo, usuarioID_SY001,
            //    id_gg032_tpinv_normal, id_gg032_sta_concluido, id_gg032_sta_solicitado,
            //    idGG054_STA_INVENTARIADO);
        }
    }
}

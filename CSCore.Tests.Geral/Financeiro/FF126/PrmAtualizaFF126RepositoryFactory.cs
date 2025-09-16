using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Estatica.Repository.Statica;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.FF1XX.FF127;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Tests.Geral.Financeiro.FF126
{
    public static class PrmAtualizaFF126RepositoryFactory
    {
        public static async  Task<PrmAtualizaFF127Repository>  Create(AppDbContext appDbContext)
        {
            return await PrmAtualizaFF127Repository.CreateInstanceAsync(
                new StaticaLabelRepositoryImpl(appDbContext),
                new SCS_GenerateId(),
                new GenerateProtocoloServiceImpl(appDbContext, new SCS_GenerateId()),
                UtilAuxTestes.EstabID_CS,
                UtilAuxTestes.UsuarioIDSY001Agnaldo,
                135,
                UtilAuxTestes.UsuarioAgnaldo_BB012,
                "MENSAGEM TESTE UNITARIO",
                DateTime.UtcNow.AddDays(15),
                DateTime.UtcNow.AddDays(-15),
                UtilAuxTestes.ff002_motivoid);
        }
    }
}

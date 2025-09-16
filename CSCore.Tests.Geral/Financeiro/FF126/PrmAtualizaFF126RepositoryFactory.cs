using CSCore.Ifs.FF.Repository.FF1XX.FF126;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Tests.Geral.Financeiro.FF126
{
    public static class PrmAtualizaFF126RepositoryFactory
    {
        public static PrmAtualizaFF126Repository Create()
        {
            return new PrmAtualizaFF126Repository
            {
                InCS_GenerateID = new SCS_GenerateId(),
                InNovoProtocoloFF127 = "20250000000069",
                InSY001Id = UtilAuxTestes.UsuarioIDSY001Agnaldo,
                InTenantID = 135,
                InSTIDFF102SitAberto = UtilAuxTestes.InStIDFF102_Sit_Aberto,
                InSTIDFF102SitBxParcial = UtilAuxTestes.InStIDFF102_Sit_BxParcial,
                InBB012_ID = UtilAuxTestes.UsuarioAgnaldo_BB012,
                InMensagem = "MENSAGEM TESTE UNITARIO",
                InDataPrevisao = DateTime.UtcNow.AddDays(15),
                InDataVisita = DateTime.UtcNow.AddDays(-15),
                InFF002_ID_Motivo = UtilAuxTestes.ff002_motivoid,
            };
        }
    }
}

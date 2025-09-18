using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX.FF128;
using CSCore.Ifs.CS_Context;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF128
{
    public class FF128RepositoryImpl : IFF128Repository
    {
        private readonly AppDbContext appDbContext;

        public FF128RepositoryImpl(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public void CriaHistoricoRegistroCobrador(PrmCriaHistoricoRegistroCobrador prm, int InTenant)
        {
            var novoHistorico = CSICP_FF128.Create(
                prm.InNovoId,
                prm.InFF102TituloId,
                prm.InDataPrevisao,
                prm.InDataLimitePrevisao,
                prm.InFF128Mensagem,
                prm.InFF127Id,
                prm.InDiasAtrasoEnt,
                prm.InSitCobrancaEntId,
                prm.InSituacaoSaiId,
                prm.InCobradorId,
                agCobradorId: null,
                tenantID: InTenant

                );

            appDbContext.Add(novoHistorico);
        }
    }
}

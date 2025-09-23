using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX.FF128;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

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

        public async Task<(IEnumerable<CSICP_FF128>, int)> ObterHistoricoRegistroCobradorPorTituloId(PrmGetHistoricoRegistroCobradorPorTitulo prm)
        {
            var query = appDbContext.OsusrE9aCsicpFf128s
                .AsNoTracking()
                .Include(e => e.NavBB0029CategoriaRegistro)
                .Include(e => e.NavBB006AgenteCobrador)
                .Include(e => e.NavBB012SituacaodeCobranca)
                .Include(e => e.NavBB012SituacaoSaidaCobranca)
                .Include(e => e.NavFF102Titulo)
                .Include(e => e.NavFF127Cobranca)
                .Include(e => e.NavFF998SituacaoSai)
                .Include(e => e.NavSy001Cobrador)
                .AsSplitQuery()
                .Where(e => e.TenantId == prm.InTenant && e.Ff128Tituloid == prm.InFF102TituloId);

            var queryCount = query;
            int count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            query = query.OrderByDescending(e => e.Ff128Id);

            return (await query.ToListAsync(), count);
        }
    }
}

using CSCore.Ifs.CS_Context;
using CSCore.Ifs.NN.CSICP_NN015.Interface;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.NN.CSICP_NN015
{
    public class NN015RepositoryImpl : RepositorioBaseImpl<Domain.CS_Models.CSICP_NN.CSICP_NN015>, INN015Repository
    {
        private readonly AppDbContext _appDbContext;

        public NN015RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CS_AtualizaValoresBaixaTesouraria(int tenant, string NN015_id)
        {
            var historicoTeste = "Historico atualizado na baixa de tesouraria";
            FormattableString sql = $@"
                UPDATE OSUSR_E9A_CSICP_NN015
                SET 
                    NN015_TOTAL_DESCONTOS = nn015.NN015_TOTAL_DESCONTOS + nn016.NN016_VALOR_DESCONTO,
                    NN015_TOTAL_TITULO = nn015.NN015_TOTAL_TITULO + nn016.NN016_VLRABERTOTITULOS,
                    NN015_TOTAL_JUROS = nn015.NN015_TOTAL_JUROS + nn016.NN016_VALOR_JUROS,
                    NN015_TOTAL_MULTA = nn015.NN015_TOTAL_MULTA + nn016.NN016_VALOR_MULTA,
                    NN015_TOTAL_TAXA = nn015.NN015_TOTAL_TAXA + nn016.NN016_VALOR_TAXA,
                    NN015_TOTAL_PAGO = nn015.NN015_TOTAL_PAGO + nn016.NN016_VALOR_PAGO,
                    NN015_TOTALJUROS_CALC = nn015.NN015_TOTALJUROS_CALC + nn016.NN016_VALOR_JUROS_CALC,
                    NN015_TOTALMULTA_CALC = nn015.NN015_TOTALMULTA_CALC + nn016.NN016_VALOR_MULTA_CALC,
                    NN015_HISTORICO = {historicoTeste},
                    NN015_TOTALTAXA_CALC = nn015.NN015_TOTALTAXA_CALC + nn016.NN016_VALOR_TAXA_CALC
                FROM OSUSR_E9A_CSICP_NN015 nn015
                INNER JOIN OSUSR_E9A_CSICP_NN016 nn016
                    ON nn015.NN015_CRCP_ID = nn016.NN016_CRCP_ID
                WHERE nn015.TENANT_ID = {tenant} AND nn015.NN015_CRCP_ID = {NN015_id}";

            //ja executa
            await this._appDbContext.Database.ExecuteSqlInterpolatedAsync(sql);

        }

        public Task<Domain.CS_Models.CSICP_NN.CSICP_NN015?> GetByIdAsync(int tenant, string id)
        {
            var query = _appDbContext.OsusrE9aCsicpNn015s
                .AsNoTracking();
            query = query.Where(e => e.TenantId == tenant && e.Nn015CrcpId == id);
            return query.FirstOrDefaultAsync();

        }

        public async Task<(IEnumerable<Domain.CS_Models.CSICP_NN.CSICP_NN015>, int)> GetListAsync(int tenant, int page, int pageSize)
        {
            var query = _appDbContext.OsusrE9aCsicpNn015s.Where(e => e.TenantId == tenant)
                   .AsNoTracking();

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Nn015CrcpId);
            query = query.PaginacaoNoBanco(page, pageSize);
            return (await query.ToListAsync(), count);
        }
    }
}

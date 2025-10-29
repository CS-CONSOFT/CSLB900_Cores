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
            FormattableString sql = $@"
                UPDATE nn015
                SET 
                    Nn015TotalDescontos = nn015.Nn015TotalDescontos + nn016.Nn016ValorDesconto,
                    Nn015TotalTitulo = nn015.Nn015TotalTitulo + nn016.Nn016Vlrabertotitulos,
                    Nn015TotalJuros = nn015.Nn015TotalJuros + nn016.Nn016ValorJuros,
                    Nn015TotalMulta = nn015.Nn015TotalMulta + nn016.Nn016ValorMulta,
                    Nn015TotalTaxa = nn015.Nn015TotalTaxa + nn016.Nn016ValorTaxa,
                    Nn015TotalPago = nn015.Nn015TotalPago + nn016.Nn016ValorPago,
                    Nn015TotaljurosCalc = nn015.Nn015TotaljurosCalc + nn016.Nn016ValorJurosCalc,
                    Nn015TotalmultaCalc = nn015.Nn015TotalmultaCalc + nn016.Nn016ValorMultaCalc,
                    Nn015TotaltaxaCalc = nn015.Nn015TotaltaxaCalc + nn016.Nn016ValorTaxaCalc, 
                FROM CSICP_NN015 nn015
                INNER JOIN CSICP_NN016 nn016
                    ON nn015.TenantId = nn016.TenantId
                    AND nn015.Nn015CrcpId = nn016.Nn016CrcpId
                WHERE nn015.TenantId = {tenant} AND nn015.Nn015CrcpId = {NN015_id}";

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

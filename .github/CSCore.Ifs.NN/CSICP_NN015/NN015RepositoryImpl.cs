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
            /*
                Autor: Valter e Agnaldo
                Data:  30/10/2025
                Obs:   A query abaixo está desenvolvida para MSSQL Server.
             */
            FormattableString sql = $@"
               UPDATE OSUSR_E9A_CSICP_NN015
                    SET 
                        NN015_TOTAL_DESCONTOS     = agg.NN016_VALOR_DESCONTO,
                        NN015_TOTAL_TITULO        = agg.NN016_VLRABERTOTITULOS,
                        NN015_TOTAL_JUROS         = agg.NN016_VALOR_JUROS,
                        NN015_TOTAL_MULTA         = agg.NN016_VALOR_MULTA,
                        NN015_TOTAL_TAXA          = agg.NN016_VALOR_TAXA,
                        NN015_TOTAL_PAGO          = agg.NN016_VALOR_PAGO,
                        NN015_TOTALJUROS_CALC     = agg.NN016_VALOR_JUROS_CALC,
                        NN015_TOTALMULTA_CALC     = agg.NN016_VALOR_MULTA_CALC
                    FROM (
                        SELECT
                            SUM(NN016_VALOR_DESCONTO)      AS NN016_VALOR_DESCONTO,
                            SUM(NN016_VLRABERTOTITULOS)    AS NN016_VLRABERTOTITULOS,
                            SUM(NN016_VALOR_JUROS)         AS NN016_VALOR_JUROS,
                            SUM(NN016_VALOR_MULTA)         AS NN016_VALOR_MULTA,
                            SUM(NN016_VALOR_TAXA)          AS NN016_VALOR_TAXA,
                            SUM(NN016_VALOR_PAGO)          AS NN016_VALOR_PAGO,
                            SUM(NN016_VALOR_JUROS_CALC)    AS NN016_VALOR_JUROS_CALC,
                            SUM(NN016_VALOR_MULTA_CALC)    AS NN016_VALOR_MULTA_CALC
                        FROM OSUSR_E9A_CSICP_NN016
                        WHERE TENANT_ID = {tenant} AND NN016_CRCP_ID = {NN015_id}
                    ) agg
                    WHERE TENANT_ID = {tenant} AND NN015_CRCP_ID = {NN015_id}";

            //ja executa
            await this._appDbContext.Database.ExecuteSqlInterpolatedAsync(sql);
        }

        public Task<Domain.CS_Models.CSICP_NN.CSICP_NN015?> GetByIdAsync(int tenant, string id)
        {
            var query = _appDbContext.OsusrE9aCsicpNn015s
                 .Include(e => e.NavNN015Rp)
                     .Include(e => e.NavNN015Status)
                     .Include(e => e.NavNN001)
                .AsNoTracking();
            query = query.Where(e => e.TenantId == tenant && e.Nn015CrcpId == id);
            return query.FirstOrDefaultAsync();

        }

        public async Task<(IEnumerable<Domain.CS_Models.CSICP_NN.CSICP_NN015>, int)> GetListAsync(
            int tenant,
            int page, 
            int pageSize,
            int? TipoRegistro,
            int? statusNN015,
            DateTime? InDataInit,
            DateTime? InDataFim,
            string? estabelecimento)
        {
            var query = _appDbContext.OsusrE9aCsicpNn015s
                     .Where(e => e.TenantId == tenant)
                     .Include(e => e.NavNN015Rp)
                     .Include(e => e.NavNN015Status)
                     .Include(e => e.NavNN001)
                     .Include(e => e.NavNN015Filial)
                   .AsNoTracking();

            if(TipoRegistro != null)
                query = query.Where(e => e.Nn015TipoMovtoid == TipoRegistro);
            if (statusNN015 != null)
                query = query.Where(e => e.Nn015Status == statusNN015);
            if (InDataInit != null)
                query = query.Where(e => e.Nn015DataMovimento >= InDataInit);
            if (InDataFim != null)
                query = query.Where(e => e.Nn015DataMovimento <= InDataFim);
            if (estabelecimento != null)
                query = query.Where(e => e.Nn015FilialId == estabelecimento);



            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Nn015CrcpId);
            query = query.PaginacaoNoBanco(page, pageSize);
            return (await query.ToListAsync(), count);
        }
    }
}

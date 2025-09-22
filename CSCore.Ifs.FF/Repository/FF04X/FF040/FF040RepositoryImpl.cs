using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._04X;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040
{
    public class FF040RepositoryImpl : RepositorioBaseImpl<CSICP_FF040>, IFF040Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF040RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_FF040?> GetByIdAsync(int InTenantID, long InIDFF040)
        {
            return await _appDbContext.OsusrE9aCsicpFf040s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Ff040Id == InIDFF040)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_FF040>, int)> GetListAsync(int InTenantID, PrmFiltrosFF040Repo parametros)
        {
            IQueryable<CSICP_FF040> query = _appDbContext.OsusrE9aCsicpFf040s
                .AsNoTracking()
                .AsSplitQuery();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, parametros));
            query = AplicaIncludes(query, GetIncludesParaAplicar());

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Ff040Id);
            query = query.PaginacaoNoBanco(parametros.PageNumber, parametros.PageSize);

            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_FF040>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosFF040Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroEstabIDFF040(filtros.InEstabID)
            ];
        }
    }
}
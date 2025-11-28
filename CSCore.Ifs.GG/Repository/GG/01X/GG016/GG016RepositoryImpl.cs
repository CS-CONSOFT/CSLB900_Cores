using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG016RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG016>(appDbContext, "Id", "TenantId"),
        IGG016Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG016?> GetByIdAsync(string id, int tenant)
        {
            IQueryable<CSICP_GG016> query = CriandoQueryDaGG016ComFiltroDeTenant(tenant);
            query = query.Where(e => e.Id == id);
            return await query.FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG016>, int)> GetListAsync(
            int tenant, int? tipoGrade_LincolID,string? inGradeDesc, int pageSize, int page, string? search)
        {
            IQueryable<CSICP_GG016> query = CriandoQueryDaGG016ComFiltroDeTenant(tenant);

            query = FiltraQuandoExisteFiltros(search, tipoGrade_LincolID, inGradeDesc, query);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG016> CriandoQueryDaGG016ComFiltroDeTenant(int tenant)
        {
            return from gg016 in _appDbContext.OsusrE9aCsicpGg016s

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on gg016.Gg016Filialid equals bb001.Id

                   join gg016b in _appDbContext.OsusrE9aCsicpGg016bs
                   on gg016.Gg016Lincolid equals gg016b.Id

                   where gg016.TenantId == tenant

                   select new CSICP_GG016
                   {
                       Id = gg016.Id,
                       TenantId = gg016.TenantId,
                       Gg016Filialid = gg016.Gg016Filialid,
                       Gg016Filial = gg016.Gg016Filial,
                       Gg016Grade = gg016.Gg016Grade,
                       Gg016Descricao = gg016.Gg016Descricao,
                       Gg016Lincolid = gg016.Gg016Lincolid,
                       Gg016Ismarcado = gg016.Gg016Ismarcado,
                       NavFilialBB001 = new CSICP_BB001
                       {
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                           Bb001Nomefantasia = bb001.Bb001Nomefantasia
                       },
                       NavCSICP_GG016b = gg016b
                   };
        }

        private static IQueryable<CSICP_GG016> FiltraQuandoExisteFiltros
            (string? search, int? tipoGrade_LincolID, string? inGradeDesc, IQueryable<CSICP_GG016> query)
        {
            if (tipoGrade_LincolID != null) query = query.Where(e => e.NavCSICP_GG016b.Id == tipoGrade_LincolID);
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg016Descricao ?? "").Contains(search ?? ""));
            }
            if (inGradeDesc != null)
            {
                query = query.Where(e => e.Gg016Grade == inGradeDesc);
            }

            return query;
        }

    }
}

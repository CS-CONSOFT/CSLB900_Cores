using CSCore.Domain.CS_Models.CSICP_TT;
using CSCore.Domain.Interfaces.TT.TT0XX;
using CSCore.Ifs.Compartilhado.Utilidade.Excel.ValidaInsertTT031Cesta;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.TT.TT0XX
{
    public class TT031RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_TT031>(appDbContext, "Tt031Id"), ITT031Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;


 

        public async Task<(IEnumerable<RepoTT031>, int)> GetListAsync(
            int tenant, long in_tt030_id, int pageSize, int page)
        {
            IQueryable<RepoTT031> q1 = from tt031 in _appDbContext.OsusrE9aCsicpTt031s
                                         where tt031.TenantId == tenant &&
                                               tt031.Tt030Id == in_tt030_id

                                        join gg520 in _appDbContext.OsusrE9aCsicpGg520s
                                        on tt031.Gg520Id equals gg520.Id into gg520Join
                                        from gg520 in gg520Join.DefaultIfEmpty()

                                        join gg001 in _appDbContext.CSICP_GG001s
                                        on gg520.Gg520Almoxid equals gg001.Id into gg001Join
                                        from gg001 in gg001Join.DefaultIfEmpty()

                                        join gg008 in _appDbContext.OsusrE9aCsicpGg008s
                                        on tt031.Gg008Id equals gg008.Id into gg008Join
                                        from gg008 in gg008Join.DefaultIfEmpty()

                                        //join gg007 in _appDbContext.OsusrE9aCsicpGg007s
                                        //on tt031.gg007_UnID equals gg007.Id into gg007Join
                                        //from gg007 in gg007Join.DefaultIfEmpty()
                                       

  
                                       select new RepoTT031
                                         {
                                            TenantId = tt031.TenantId,
                                            Tt031Id = tt031.Tt031Id,
                                            Tt030Id = tt031.Tt030Id,
                                            CsCodgproduto = tt031.CsCodgproduto,
                                            CsQtd = tt031.CsQtd,
                                            CsValor = tt031.CsValor,
                                            CsDesc = tt031.CsDesc,
                                            Gg008Id = tt031.Gg008Id,
                                            Gg008kdxId = tt031.Gg008kdxId,
                                            Gg520Id = tt031.Gg520Id,
                                            Campoespecial1 = tt031.Campoespecial1,
                                            Campoespecial2 = tt031.Campoespecial2,
                                            Gg001Descalmox = gg001 != null ? gg001.Gg001Descalmox : null,
                                            Gg008Descreduzida = gg008 != null ? gg008.Gg008Descreduzida : null,
                                            Gg520NsNumerosaldo = gg520 != null ? gg520.Gg520NsNumerosaldo : null,
                                            gg007_UnID = tt031.gg007_UnID
                                       };


            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }
    }
}

using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG016fRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG016f>(appDbContext, "Gg016fId"),
        IGG016fRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;


        public async Task<CSICP_GG016f> CreateAsync(CSICP_GG016f entity)
        {
            IQueryable<CSICP_GG016f> salvarGG016f = from _gg016F in _appDbContext.OsusrE9aCsicpGg016fs
                                                    where _gg016F.TenantId == entity.TenantId
                                                    where _gg016F.Gg016eId == entity.Gg016eId
                                                    where _gg016F.Gg016fGradelinhaid == entity.Gg016fGradelinhaid
                                                    where _gg016F.Gg016fGradecolunaid == entity.Gg016fGradecolunaid
                                                    select _gg016F;


            CSICP_GG016f? cSICP_GG016f = await salvarGG016f.FirstOrDefaultAsync();


            if (cSICP_GG016f is null)
            {
                base.Create(entity);
                return entity;
            }
            else return entity;
        }

        public async Task<CSICP_GG016f?> GetByIdAsync(long id, int tenant)
        {
            IQueryable<CSICP_GG016f> query = CriaQueryBaseFiltrandoPorTenant(tenant);

            return await query.Where(e => e.Gg016fId == id).FirstOrDefaultAsync();
        }


        public async Task<IEnumerable<CSICP_GG016f>> GetListAsync(int tenant, long gg016e_id)
        {
            IQueryable<CSICP_GG016f> query = CriaQueryBaseFiltrandoPorTenant(tenant);
            return await query.Where(e => e.Gg016eId == gg016e_id).ToListAsync();
        }



        public override Task<CSICP_GG016f?> UpdateAsync(string id, int tenant, CSICP_GG016f entity)
        {
            throw new MethodAccessException(HandlerReturnMessages.METHOD_NOT_ALLOWED);
        }

        public override Task<CSICP_GG016f?> UpdateAsync(long id, int tenant, CSICP_GG016f entity)
        {
            throw new MethodAccessException(HandlerReturnMessages.METHOD_NOT_ALLOWED);
        }
        private IQueryable<CSICP_GG016f> CriaQueryBaseFiltrandoPorTenant(int tenant)
        {
            IQueryable<CSICP_GG016f> query = from _gg016F in _appDbContext.OsusrE9aCsicpGg016fs
                                             where _gg016F.TenantId == tenant

                                             join _gg016_c1 in _appDbContext.OsusrE9aCsicpGg016s
                                             on _gg016F.Gg016fGradelinhaid equals _gg016_c1.Id into g016_c1_join
                                             from _gg016_c1 in g016_c1_join.DefaultIfEmpty()

                                             join _gg016_c2 in _appDbContext.OsusrE9aCsicpGg016s
                                             on _gg016F.Gg016fGradecolunaid equals _gg016_c2.Id into g016_c2_join
                                             from _gg016_c2 in g016_c2_join.DefaultIfEmpty()

                                             join _bb001filial in _appDbContext.E9ACSICP_BB001s
                                             on _gg016_c1.Gg016Filialid equals _bb001filial.Id into bb001_join
                                             from _bb001filial in bb001_join.DefaultIfEmpty()

                                             select new CSICP_GG016f
                                             {
                                                 TenantId = _gg016F.TenantId,
                                                 Gg016fId = _gg016F.Gg016fId,
                                                 Gg016eId = _gg016F.Gg016eId,
                                                 Gg016fGradelinhaid = _gg016F.Gg016fGradelinhaid,
                                                 Gg016fGradecolunaid = _gg016F.Gg016fGradecolunaid,
                                                 NavGg016fGradelinha = new CSICP_GG016
                                                 {
                                                     TenantId = _gg016_c1.TenantId,
                                                     Id = _gg016_c1.Id,
                                                     Gg016Filialid = _gg016_c1.Gg016Filialid,
                                                     Gg016Filial = _gg016_c1.Gg016Filial,
                                                     Gg016Grade = _gg016_c1.Gg016Grade,
                                                     Gg016Descricao = _gg016_c1.Gg016Descricao,
                                                     Gg016Lincolid = _gg016_c1.Gg016Lincolid,
                                                     Gg016Ismarcado = _gg016_c1.Gg016Ismarcado,
                                                     NavFilialBB001 = new CSICP_BB001
                                                     {
                                                         Id = _bb001filial.Id,
                                                         Bb001Codigoempresa = _bb001filial.Bb001Codigoempresa,
                                                         Bb001Razaosocial = _bb001filial.Bb001Razaosocial,
                                                         Bb001Nomefantasia = _bb001filial.Bb001Nomefantasia,
                                                     }
                                                 },
                                                 NavGg016fGradecoluna = new CSICP_GG016
                                                 {
                                                     TenantId = _gg016_c2.TenantId,
                                                     Id = _gg016_c2.Id,
                                                     Gg016Filialid = _gg016_c2.Gg016Filialid,
                                                     Gg016Filial = _gg016_c2.Gg016Filial,
                                                     Gg016Grade = _gg016_c2.Gg016Grade,
                                                     Gg016Descricao = _gg016_c2.Gg016Descricao,
                                                     Gg016Lincolid = _gg016_c2.Gg016Lincolid,
                                                     Gg016Ismarcado = _gg016_c2.Gg016Ismarcado,
                                                     NavFilialBB001 = new CSICP_BB001
                                                     {
                                                         Id = _bb001filial.Id,
                                                         Bb001Codigoempresa = _bb001filial.Bb001Codigoempresa,
                                                         Bb001Razaosocial = _bb001filial.Bb001Razaosocial,
                                                         Bb001Nomefantasia = _bb001filial.Bb001Nomefantasia,
                                                     }
                                                 }
                                             };
            return query;
        }

    }
}

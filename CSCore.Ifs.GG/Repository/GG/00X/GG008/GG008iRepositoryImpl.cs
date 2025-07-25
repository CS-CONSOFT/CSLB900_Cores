using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X.GG008;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._00X.GG008
{
    public class GG008iRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG008i>(appDbContext), IGG008iRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG008i> GetByIdAsync(string GG008i_id, string? kardexGG008_ID, int tenant)
        {
            IQueryable<CSICP_GG008i> query = CriaQueryBaseParaGG008i(tenant);
            query = query.Where(e => e.Id == GG008i_id);

            if (kardexGG008_ID != null) query = query.Where(e => e.Gg008iKardexId == kardexGG008_ID);

            CSICP_GG008i? csicpGG008iEntity = await query.FirstOrDefaultAsync();

            if (csicpGG008iEntity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGG008iEntity;
        }



        public async Task<(IEnumerable<CSICP_GG008i>, int)> GetListAsync(
            int in_tenant, string? in_kardexGG008_ID, string? in_ncmID, string in_filialID, int pageSize, int page)
        {
            IQueryable<CSICP_GG008i> query = CriaQueryBaseParaGG008i(in_tenant);
            query = query.Where(e => e.Gg008iFilialid == in_filialID);

            if (in_ncmID != null) query = query.Where(e => e.Gg008iNcmId == in_ncmID);
            if (in_kardexGG008_ID != null) query = query.Where(e => e.Gg008iKardexId == in_kardexGG008_ID);

            var queryCount = query;
            int count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG008i> CriaQueryBaseParaGG008i(int tenant)
        {
            IQueryable<CSICP_GG008i> query = from GG008i in _appDbContext.OsusrE9aCsicpGg008is

                                             join bb027Tran in _appDbContext.OsusrE9aCsicpBb027s
                                             on GG008i.Gg008iTransacaoid equals bb027Tran.Id into bb027TranJoin
                                             from bb027Tran in bb027TranJoin.DefaultIfEmpty()

                                             join gg008Trans in _appDbContext.OsusrE9aCsicpGg008Trans
                                             on GG008i.Gg008iTiporegistro equals gg008Trans.Id into gg008TransJoin
                                             from gg008Trans in gg008TransJoin.DefaultIfEmpty()

                                             where GG008i.TenantId == tenant


                                             orderby bb027Tran.Bb027Descricao descending

                                             select new CSICP_GG008i
                                             {
                                                 TenantId = GG008i.TenantId,
                                                 Id = GG008i.Id,
                                                 Gg008iFilialid = GG008i.Gg008iFilialid,
                                                 Gg008iKardexId = GG008i.Gg008iKardexId,
                                                 Gg008iProdutoid = GG008i.Gg008iProdutoid,
                                                 Gg008iTransacaoid = GG008i.Gg008iTransacaoid,
                                                 Gg008iTiporegistro = GG008i.Gg008iTiporegistro,
                                                 Gg008iNcmId = GG008i.Gg008iNcmId,
                                                 NavBB027Transacao = new CSICP_Bb027
                                                 {
                                                     Id = bb027Tran.Id,
                                                     Bb027Filial = bb027Tran.Bb027Filial,
                                                     Bb027Codigo = bb027Tran.Bb027Codigo,
                                                     Bb027Descricao = bb027Tran.Bb027Descricao,
                                                     Bb027Descnatoper = bb027Tran.Bb027Descnatoper
                                                 },
                                                 NavGG008Trans = gg008Trans ?? null
                                             };
            return query;
        }
    }
}

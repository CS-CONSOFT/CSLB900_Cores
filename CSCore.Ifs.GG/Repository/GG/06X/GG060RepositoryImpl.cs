using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._06X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.GG.Repository.GG._06X
{
    public class GG060RepositoryImpl : IGG060Repository
    {
        private readonly AppDbContext _appDbContext;
        public GG060RepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_GG060> CreateAsync(CSICP_GG060 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<CSICP_GG060> UpdateAsync(CSICP_GG060 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<int> CreateAsyncParaGrupo(IEnumerable<CSICP_BB001> listaTodosEstabelecimentos,
            int tenant, string grupoID)
        {
            using (var transiction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    int entidadesSalvar = 0;
                    CSICP_GG060 entidadeTrabalhoGG060 = new()
                    {
                        Gg060Id = 0,
                        TenantId = tenant,
                        Gg060EstabId = null,
                        Gg060Grupoid = grupoID,
                        Gg060Subgrupoid = null,
                        Gg060Plucro = 0,
                        Gg060Isactive = true,
                        Gg060Dregistro = DateTime.UtcNow.ToLocalTime(),
                        Gg060Pmaxdesconto = 0,
                        Gg060Ispadrao = true,
                    };

                    _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;

                    int saveChangesCount = await _appDbContext.SaveChangesAsync();

                    _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;

                    foreach (var currentBB001 in listaTodosEstabelecimentos)
                    {
                        entidadeTrabalhoGG060.Gg060Id = 0;
                        entidadeTrabalhoGG060.Gg060EstabId = currentBB001.Id;
                        entidadeTrabalhoGG060.Gg060Dregistro = DateTime.UtcNow.ToLocalTime();

                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;

                        int saveChangesResult = await _appDbContext.SaveChangesAsync();
                        entidadesSalvar = entidadesSalvar + saveChangesResult;

                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;
                    }
                    await transiction.CommitAsync();
                    return entidadesSalvar + saveChangesCount;
                }
                catch (Exception ex)
                {
                    await transiction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }


        public async Task<int> CreateAsyncParaSubGrupo(IEnumerable<CSICP_BB001> listaTodosEstabelecimentos,
           int tenant, string subGrupoID)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    int entidadesSalvar = 0;
                    CSICP_GG060 entidadeTrabalhoGG060 = new()
                    {
                        Gg060Id = 0,
                        TenantId = tenant,
                        Gg060EstabId = null,
                        Gg060Grupoid = null,
                        Gg060Subgrupoid = subGrupoID,
                        Gg060Plucro = 0,
                        Gg060Isactive = true,
                        Gg060Dregistro = DateTime.UtcNow.ToLocalTime(),
                        Gg060Pmaxdesconto = 0,
                        Gg060Ispadrao = true,
                    };

                    _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;

                    int saveChangesCount = await _appDbContext.SaveChangesAsync();

                    _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;

                    foreach (var currentBB001 in listaTodosEstabelecimentos)
                    {
                        entidadeTrabalhoGG060.Gg060Id = 0;
                        entidadeTrabalhoGG060.Gg060EstabId = currentBB001.Id;
                        entidadeTrabalhoGG060.Gg060Dregistro = DateTime.UtcNow.ToLocalTime();

                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;

                        int saveChangesResult = await _appDbContext.SaveChangesAsync();
                        entidadesSalvar = entidadesSalvar + saveChangesResult;

                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;
                    }
                    await transaction.CommitAsync();
                    return entidadesSalvar + saveChangesCount;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }

        public async Task DeleteRange(IEnumerable<CSICP_GG060> listaGG060ParaDeletar)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    IEnumerable<CSICP_GG060> listaSubGrupoDistinct
                        = listaGG060ParaDeletar.DistinctBy(e => e.Gg060Subgrupoid);

                    foreach (var currentGG060 in listaSubGrupoDistinct)
                    {
                        if (currentGG060.Gg060Subgrupoid != null)
                        {
                            CSICP_GG015? subGrupoEncontrado = await _appDbContext.OsusrE9aCsicpGg015s
                                .FirstOrDefaultAsync(e => e.Id == currentGG060.Gg060Subgrupoid);

                            if (subGrupoEncontrado is null)
                                continue;

                            //deletando o gg015 deleta o gg060 por cascade
                            _appDbContext.Remove(subGrupoEncontrado);
                        }
                    }

                    IEnumerable<CSICP_GG060> listaGG060SemSubgrupo
                        = listaGG060ParaDeletar.Where(e => e.Gg060Subgrupoid == null);

                    _appDbContext.RemoveRange(listaGG060SemSubgrupo);

                    await _appDbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }

        }

        public async Task DeleteAsync(CSICP_GG060 GG060ParaDeletar)
        {
            _appDbContext.Remove(GG060ParaDeletar);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<CSICP_GG060> GetGG060ByIdAsync(int tenant, long GG060_ID)
        {
            IQueryable<CSICP_GG060> query = from _CSICP_GG060 in _appDbContext.OsusrE9aCsicpGg060s
                                            where _CSICP_GG060.TenantId == tenant

                                            where _CSICP_GG060.Gg060Id == GG060_ID

                                            join _CSICP_GG015 in _appDbContext.OsusrE9aCsicpGg015s
                                            on _CSICP_GG060.Gg060Subgrupoid equals _CSICP_GG015.Id into joined_gg015
                                            from _CSICP_GG015 in joined_gg015.DefaultIfEmpty()

                                            join _CSICP_BB001 in _appDbContext.E9ACSICP_BB001s
                                            on _CSICP_GG060.Gg060EstabId equals _CSICP_BB001.Id into joined_bb001
                                            from _CSICP_BB001 in joined_bb001.DefaultIfEmpty()

                                            select new CSICP_GG060
                                            {
                                                TenantId = _CSICP_GG060.TenantId,
                                                Gg060Id = _CSICP_GG060.Gg060Id,
                                                Gg060EstabId = _CSICP_GG060.Gg060EstabId,
                                                Gg060Grupoid = _CSICP_GG060.Gg060Grupoid,
                                                Gg060Subgrupoid = _CSICP_GG060.Gg060Subgrupoid,
                                                Gg060Plucro = _CSICP_GG060.Gg060Plucro,
                                                Gg060Isactive = _CSICP_GG060.Gg060Isactive,
                                                Gg060Dregistro = _CSICP_GG060.Gg060Dregistro,
                                                Gg060Pmaxdesconto = _CSICP_GG060.Gg060Pmaxdesconto,
                                                Gg060Ispadrao = _CSICP_GG060.Gg060Ispadrao,
                                                NavGg015Subgrupo = _CSICP_GG015,
                                                NavBB001Filial = _CSICP_BB001 != null ? new CSICP_BB001
                                                {
                                                    TenantId = _CSICP_BB001.TenantId,
                                                    Id = _CSICP_BB001.Id,
                                                    Bb001Codigoempresa = _CSICP_BB001.Bb001Codigoempresa,
                                                    Bb001Razaosocial = _CSICP_BB001.Bb001Razaosocial,
                                                    Bb001Nomefantasia = _CSICP_BB001.Bb001Nomefantasia,
                                                } : null

                                            };

            var entity = await query.FirstOrDefaultAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_GG060>> GetGG060List_ByGrupoIDAsync(int tenant, string GG003_ID)
        {
            IQueryable<CSICP_GG060> query = from _CSICP_GG060 in _appDbContext.OsusrE9aCsicpGg060s
                                            where _CSICP_GG060.TenantId == tenant
                                            where _CSICP_GG060.Gg060Grupoid == GG003_ID

                                            join _CSICP_GG015 in _appDbContext.OsusrE9aCsicpGg015s
                                            on _CSICP_GG060.Gg060Subgrupoid equals _CSICP_GG015.Id into joined_gg015
                                            from _CSICP_GG015 in joined_gg015.DefaultIfEmpty()

                                            join _CSICP_BB001 in _appDbContext.E9ACSICP_BB001s
                                            on _CSICP_GG060.Gg060EstabId equals _CSICP_BB001.Id into joined_bb001
                                            from _CSICP_BB001 in joined_bb001.DefaultIfEmpty()

                                            select new CSICP_GG060
                                            {
                                                TenantId = _CSICP_GG060.TenantId,
                                                Gg060Id = _CSICP_GG060.Gg060Id,
                                                Gg060EstabId = _CSICP_GG060.Gg060EstabId,
                                                Gg060Grupoid = _CSICP_GG060.Gg060Grupoid,
                                                Gg060Subgrupoid = _CSICP_GG060.Gg060Subgrupoid,
                                                Gg060Plucro = _CSICP_GG060.Gg060Plucro,
                                                Gg060Isactive = _CSICP_GG060.Gg060Isactive,
                                                Gg060Dregistro = _CSICP_GG060.Gg060Dregistro,
                                                Gg060Pmaxdesconto = _CSICP_GG060.Gg060Pmaxdesconto,
                                                Gg060Ispadrao = _CSICP_GG060.Gg060Ispadrao,
                                                NavGg015Subgrupo = _CSICP_GG015,
                                                NavBB001Filial = _CSICP_BB001 != null ? new CSICP_BB001
                                                {
                                                    TenantId = _CSICP_BB001.TenantId,
                                                    Id = _CSICP_BB001.Id,
                                                    Bb001Codigoempresa = _CSICP_BB001.Bb001Codigoempresa,
                                                    Bb001Razaosocial = _CSICP_BB001.Bb001Razaosocial,
                                                    Bb001Nomefantasia = _CSICP_BB001.Bb001Nomefantasia,
                                                } : null

                                            };

            List<CSICP_GG060> gg060Entities = await query.ToListAsync();
            gg060Entities.OrderBy(e => e.Gg060Subgrupoid);
            gg060Entities.OrderBy(e => e.Gg060EstabId);
            return gg060Entities;
        }

        public async Task<IEnumerable<CSICP_GG060>> GetGG060List_ByGrupoID_Filial_Nulo_NaoNulo_GG003_Async(
            ENUM_GET_GG003_STATUS_FILIAL status_estabelecimento,
            int tenant,
            string GG003_ID)
        {
            IQueryable<CSICP_GG060> query = from _CSICP_GG060 in _appDbContext.OsusrE9aCsicpGg060s

                                            join _CSICP_GG015 in _appDbContext.OsusrE9aCsicpGg015s
                                            on _CSICP_GG060.Gg060Subgrupoid equals _CSICP_GG015.Id into joined_gg015
                                            from _CSICP_GG015 in joined_gg015.DefaultIfEmpty()

                                            join _CSICP_BB001 in _appDbContext.E9ACSICP_BB001s
                                            on _CSICP_GG060.Gg060EstabId equals _CSICP_BB001.Id into joined_bb001
                                            from _CSICP_BB001 in joined_bb001.DefaultIfEmpty()

                                            where _CSICP_GG060.TenantId == tenant
                                            where _CSICP_GG060.Gg060Grupoid == GG003_ID


                                            select new CSICP_GG060
                                            {
                                                TenantId = _CSICP_GG060.TenantId,
                                                Gg060Id = _CSICP_GG060.Gg060Id,
                                                Gg060EstabId = _CSICP_GG060.Gg060EstabId,
                                                Gg060Grupoid = _CSICP_GG060.Gg060Grupoid,
                                                Gg060Subgrupoid = _CSICP_GG060.Gg060Subgrupoid,
                                                Gg060Plucro = _CSICP_GG060.Gg060Plucro,
                                                Gg060Isactive = _CSICP_GG060.Gg060Isactive,
                                                Gg060Dregistro = _CSICP_GG060.Gg060Dregistro,
                                                Gg060Pmaxdesconto = _CSICP_GG060.Gg060Pmaxdesconto,
                                                Gg060Ispadrao = _CSICP_GG060.Gg060Ispadrao,
                                                NavGg015Subgrupo = _CSICP_GG015,
                                                NavBB001Filial = _CSICP_BB001 == null ? null : new CSICP_BB001
                                                {
                                                    TenantId = _CSICP_BB001.TenantId,
                                                    Id = _CSICP_BB001.Id,
                                                    Bb001Codigoempresa = _CSICP_BB001.Bb001Codigoempresa,
                                                    Bb001Razaosocial = _CSICP_BB001.Bb001Razaosocial,
                                                    Bb001Nomefantasia = _CSICP_BB001.Bb001Nomefantasia,
                                                }
                                            };



            if (status_estabelecimento == ENUM_GET_GG003_STATUS_FILIAL.PREENCHIDO)
                query = query.Where(e => e.Gg060EstabId != null);

            if (status_estabelecimento == ENUM_GET_GG003_STATUS_FILIAL.NULO)
                query = query.Where(e => e.Gg060EstabId == null);

            List<CSICP_GG060> gg060Entities = await query.ToListAsync();
            return gg060Entities;
        }


    }
}

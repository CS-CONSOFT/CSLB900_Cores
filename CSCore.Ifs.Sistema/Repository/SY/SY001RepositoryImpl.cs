using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY001RepositoryImpl : ISY001Repository
    {
        private AppDbContext _appDbContext;

        public SY001RepositoryImpl(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy001> CreateAsync(Csicp_Sy001 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy001?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<Csicp_Sy001>> GetListAsync(int tenant, string? search)
        {
            IQueryable<Csicp_Sy001> q1 = 
                CreateBaseQuery(tenant)
                .Include(e => e.OsusrE9aCsicpSy001Imgs.Where(e => e.Ispadrao == true))
                .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task AtualizaSenhasDesseTenant(int tenant)
        {
            var listaSenhasTexto = await this._appDbContext.OsusrE9aCsicpSy001Bios
                .Where(e => e.TenantId == tenant && e.Isactive == true)
                .ToListAsync();

            var listaUsuarios  = await this._appDbContext.OsusrE9aCsicpSy001s
                .Where(e => e.TenantId == tenant && listaSenhasTexto.Select(s => s.UsuarioId).Contains(e.Id))
                .ToListAsync();

            var listaJuntada = from usuario in listaUsuarios
                               join senha in listaSenhasTexto
                               on usuario.Id equals senha.UsuarioId
                               select new {usuario.Id, senha.BiometriaTexto};


            foreach (var current in listaJuntada)
                listaUsuarios.First(e => e.Id == current.Id).Sy001Senhacs = SecureHashUtilitySimple.Hash(current.BiometriaTexto);

            listaSenhasTexto.ForEach(e => e.Isactive = !e.Isactive);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Csicp_Sy001> RemoveAsync(Csicp_Sy001 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy001> UpdateAsync(Csicp_Sy001 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Csicp_Sy001> ChangeActive(Csicp_Sy001 entity)
        {
            entity.Sy001Bloqueado = !entity.Sy001Bloqueado;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
        /*
         * Task que retornam as listas da SY001
         * */

        public async Task<List<Csicp_Sy001Img>> GetAvatares(string id, int tenant)
        {
            //Retorna a lista de Avatares do usuario.
            return await _appDbContext.OsusrE9aCsicpSy001Imgs
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.UsuarioId == id)
            .ToListAsync();
        }

        public async Task<List<Csicp_Sy005>> GetGruposUsuarioList(string id, int tenant)
        {
            //Retorna a lista de Avatares do usuario.
            List<Csicp_Sy005> csicp_Sy005s = await _appDbContext.OsusrE9aCsicpSy005s
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.Sy005Userid == id)
            .Include(e => e.Sy005Grupo)
            .ToListAsync();
            return csicp_Sy005s;
        }


        public async Task<Csicp_Sy001> AlterarSenha(Csicp_Sy001 csicp_Sy001)
        {
            try
            {
                _appDbContext.Update(csicp_Sy001);
                await _appDbContext.SaveChangesAsync();
                return csicp_Sy001;
            }
            catch (Exception ex)
            {

                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }


        public async Task<List<Csicp_Sy006>> GetRegrasUsuarioList(string id, int tenant)
        {
            //Retorna a lista de Avatares do usuario.
            return await _appDbContext.OsusrE9aCsicpSy006s
            .AsNoTracking()
            .Include(e => e.Sy006Regraestatica)
            .Where(e => e.TenantId == tenant && e.Sy006Userid == id)
            .ToListAsync();
        }
        public async Task<List<Csicp_Sy013>> GetEstabsUsuarioList(string id, int tenant)
        {
            List<Csicp_Sy013> csicp_Sy013s = await _appDbContext.OsusrE9aCsicpSy013s
                .AsSplitQuery()
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.Sy013Usuarioid == id)
            .Include(e => e.NavCSICP_BB001)
            .ToListAsync();
            //Retorna a lista de Avatares do usuario.
            return csicp_Sy013s;
        }
        public async Task<List<Csicp_Sy021>> GetChavesAcessoUsuarioList(string id, int tenant)
        {
            //Retorna a lista de Avatares do usuario.
            return await _appDbContext.OsusrE9aCsicpSy021s
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.Sy0221Usuarioid == id)
            .ToListAsync();
        }

        private static IQueryable<Csicp_Sy001> FiltraQuandoExisteFiltros(string? search, IQueryable<Csicp_Sy001> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Sy001Nome ?? "").Contains(search ?? ""));
            }

            return query;
        }
        // Summary: Monta query para retornar os dados da sy001 e seus dados relacionados.


        private IQueryable<Csicp_Sy001> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy001s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .Include(t => t.NavSY001_AlterarSenha)
                .Include(t => t.NavSY001_AlterarSenha)
                .Include(t => t.NavSy001Altsenhapxlogin)
                .Include(t => t.NavSy001ExpiraSenha)
                .Include(t => t.NavSy001IdiomaId)
                .OrderBy(t => t.Sy001Nome);
        }

        private async Task<Csicp_Sy001?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                 .Include(e => e.OsusrE9aCsicpSy001Imgs)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}

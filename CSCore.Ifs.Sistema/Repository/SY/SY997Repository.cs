using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.SY
{
    public class SY997Repository : RepositorioBaseImpl<CSICP_SY997_LOGS>, ISY997Repository
    {
        private readonly AppDbContext _context;

        public SY997Repository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<CSICP_SY997_LOGS?> GetByIdAsync(long id, int tenant)
        {
            return await _context.OsusrE9aCsicpSy997s
                .FirstOrDefaultAsync(x => x.Id == id && x.TenantId == tenant);
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetListAsync(int tenant, string? search = null, int pageSize = 50, int page = 1)
        {
            var query = _context.OsusrE9aCsicpSy997s
                .Where(x => x.TenantId == tenant);

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => 
                    x.Sy997Nomeusuario!.Contains(search) || 
                    x.Sy997Mensagem!.Contains(search) ||
                    x.Sy997Severidade!.Contains(search));
            }

            return await query
                .OrderByDescending(x => x.Sy997Datainc)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetByUsuarioAsync(int tenant, string nomeUsuario)
        {
            return await _context.OsusrE9aCsicpSy997s
                .Where(x => x.TenantId == tenant && x.Sy997Nomeusuario == nomeUsuario)
                .OrderByDescending(x => x.Sy997Datainc)
                .ToListAsync();
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetBySeveridadeAsync(int tenant, string severidade)
        {
            return await _context.OsusrE9aCsicpSy997s
                .Where(x => x.TenantId == tenant && x.Sy997Severidade == severidade)
                .OrderByDescending(x => x.Sy997Datainc)
                .ToListAsync();
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetNaoExibidosAsync(int tenant)
        {
            return await _context.OsusrE9aCsicpSy997s
                .Where(x => x.TenantId == tenant && x.Sy997Isexibiu == false)
                .OrderByDescending(x => x.Sy997Datainc)
                .ToListAsync();
        }

        public async Task<CSICP_SY997_LOGS> MarcarComoExibidoAsync(long id, int tenant)
        {
            var log = await GetByIdAsync(id, tenant);
            if (log != null)
            {
                log.Sy997Isexibiu = true;
                _context.OsusrE9aCsicpSy997s.Update(log);
            }
            return log!;
        }
    }
}
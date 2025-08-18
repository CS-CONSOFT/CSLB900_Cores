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

        public async Task<CSICP_SY997_LOGS?> GetByIdAsync(long id)
        {
            return await _context.OsusrE9aCsicpSy997s
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetListAsync(string? search = null, int pageSize = 50, int page = 1)
        {
            var query = _context.OsusrE9aCsicpSy997s.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                // Divide o termo de busca em palavras individuais
                var searchTerms = search.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                query = query.Where(x =>
                    searchTerms.Any(term =>
                        (x.Sy997Nomeusuario ?? "").Contains(term) ||
                        (x.Sy997Mensagem ?? "").Contains(term) ||
                        (x.Sy997Severidade ?? "").Contains(term)));
            }


            return await query
                .OrderByDescending(x => x.Sy997Datainc)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetByUsuarioAsync(string nomeUsuario)
        {
            return await _context.OsusrE9aCsicpSy997s
                .Where(x => x.Sy997Nomeusuario == nomeUsuario)
                .OrderByDescending(x => x.Sy997Datainc)
                .ToListAsync();
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetBySeveridadeAsync(string severidade)
        {
            return await _context.OsusrE9aCsicpSy997s
                .Where(x =>  x.Sy997Severidade == severidade)
                .OrderByDescending(x => x.Sy997Datainc)
                .ToListAsync();
        }

        public async Task<IEnumerable<CSICP_SY997_LOGS>> GetNaoExibidosAsync()
        {
            return await _context.OsusrE9aCsicpSy997s
                .Where(x =>  x.Sy997Isexibiu == false)
                .OrderByDescending(x => x.Sy997Datainc)
                .ToListAsync();
        }

        public async Task<CSICP_SY997_LOGS> MarcarComoExibidoAsync(long id)
        {
            var log = await GetByIdAsync(id);
            if (log != null)
            {
                log.Sy997Isexibiu = true;
                _context.OsusrE9aCsicpSy997s.Update(log);
            }
            return log!;
        }
    }
}
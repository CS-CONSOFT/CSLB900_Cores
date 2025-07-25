using CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY008Repository : ISY008Repository
    {
        private AppDbContext _appDbContext;

        public SY008Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy008> CreateAsync(Csicp_Sy008 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

    
        public async Task<Csicp_Sy008> RemoveAsync(Csicp_Sy008 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}

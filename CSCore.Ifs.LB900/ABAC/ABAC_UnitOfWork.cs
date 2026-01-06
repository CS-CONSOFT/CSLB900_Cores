using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;

namespace CSSY103.C82Application.Service.UnitOfWork.ABAC
{
    public class ABAC_UnitOfWork : IABAC_UnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly ICS_GenerateId _idGenerator;
        private readonly IRepositorioBaseV2ComGets<OsusrE9aCsicpSy030> _sy030Repository;

        public ABAC_UnitOfWork(
            AppDbContext context,
            ICS_GenerateId idGenerator,
            IRepositorioBaseV2ComGets<OsusrE9aCsicpSy030> sy030Repository)
        {
            _context = context;
            _idGenerator = idGenerator;
            _sy030Repository = sy030Repository;
        }

        public IRepositorioBaseV2ComGets<OsusrE9aCsicpSy030> GetSY030Repository => _sy030Repository;

        public ICS_GenerateId IdGenerator => _idGenerator;

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
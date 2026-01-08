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
        private readonly IRepositorioBaseV2ComGets<OsusrE9aCsicpSy031> _sy031Repository;
        private readonly IRepositorioBaseV2ComGets<OsusrE9aCsicpSy032> _sy032Repository;
        private readonly IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCE> _sy035Repository;
        private readonly IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEACTIONS> _sy036Repository;
        private readonly IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEATRIB> _sy037Repository;
        private readonly IRepositorioBaseV2ComGets<OsusrE9aCsicpSy038> _sy038Repository;
        private readonly IRepositorioBaseV2ComGets<OsusrE9aCsicpSy039> _sy039Repository;
        private readonly IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERS> _sy040Repository;
        private readonly IRepositorioBaseV2ComGets<ABAC_CSSPH_OPERADORES> _sy041Repository;
        private readonly IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSOPERADORES> _sy042Repository;
        private readonly IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSRESOURCE> _sy043Repository;

        public ABAC_UnitOfWork(
            AppDbContext context,
            ICS_GenerateId idGenerator,
            IRepositorioBaseV2ComGets<OsusrE9aCsicpSy030> sy030Repository,
            IRepositorioBaseV2ComGets<OsusrE9aCsicpSy031> sy031Repository,
            IRepositorioBaseV2ComGets<OsusrE9aCsicpSy032> sy032Repository,
            IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCE> sy035Repository,
            IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEACTIONS> sy036Repository,
            IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEATRIB> sy037Repository,
            IRepositorioBaseV2ComGets<OsusrE9aCsicpSy038> sy038Repository,
            IRepositorioBaseV2ComGets<OsusrE9aCsicpSy039> sy039Repository,
            IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERS> sy040Repository,
            IRepositorioBaseV2ComGets<ABAC_CSSPH_OPERADORES> sy041Repository,
            IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSOPERADORES> sy042Repository,
            IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSRESOURCE> sy043Repository)
        {
            _context = context;
            _idGenerator = idGenerator;
            _sy030Repository = sy030Repository;
            _sy031Repository = sy031Repository;
            _sy032Repository = sy032Repository;
            _sy035Repository = sy035Repository;
            _sy036Repository = sy036Repository;
            _sy037Repository = sy037Repository;
            _sy038Repository = sy038Repository;
            _sy039Repository = sy039Repository;
            _sy040Repository = sy040Repository;
            _sy041Repository = sy041Repository;
            _sy042Repository = sy042Repository;
            _sy043Repository = sy043Repository;
        }

        public IRepositorioBaseV2ComGets<OsusrE9aCsicpSy030> GetSY030Repository => _sy030Repository;

        public IRepositorioBaseV2ComGets<OsusrE9aCsicpSy031> GetSY031Repository => _sy031Repository;

        public IRepositorioBaseV2ComGets<OsusrE9aCsicpSy032> GetSY032Repository => _sy032Repository;

        public IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCE> GetSY035Repository => _sy035Repository;

        public IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEACTIONS> GetSY036Repository => _sy036Repository;

        public IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEATRIB> GetSY037Repository => _sy037Repository;

        public IRepositorioBaseV2ComGets<OsusrE9aCsicpSy038> GetSY038Repository => _sy038Repository;

        public IRepositorioBaseV2ComGets<OsusrE9aCsicpSy039> GetSY039Repository => _sy039Repository;

        public IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERS> GetSY040Repository => _sy040Repository;

        public IRepositorioBaseV2ComGets<ABAC_CSSPH_OPERADORES> GetSY041Repository => _sy041Repository;

        public IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSOPERADORES> GetSY042Repository => _sy042Repository;

        public IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSRESOURCE> GetSY043Repository => _sy043Repository;

        public ICS_GenerateId IdGenerator => _idGenerator;

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
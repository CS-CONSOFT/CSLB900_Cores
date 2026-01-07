using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.GG._00X.GG008;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._00X.GG008
{
    /// <summary>
    /// Implementação do repositório para GG008RFTransacao - Transação Reforma Tributária
    /// </summary>
    public class GG008RFTransacaoRepositoryImpl :
        RepositorioBaseImpl<OsusrE9aCsicpGg008rftransacao>, IGG008RFTransacaoRepository
    {
        private readonly AppDbContext _appDbContext;

        public GG008RFTransacaoRepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrE9aCsicpGg008rftransacao> GetByIdAsync(string inGG008RFTID, string? inKardexGG008ID, int inTenantID)
        {
            IQueryable<OsusrE9aCsicpGg008rftransacao> query = _appDbContext.OsusrE9aCsicpGg008rftransacao
                .Where(e => e.TenantId == inTenantID && e.Id == inGG008RFTID);

            if (inKardexGG008ID != null) 
                query = query.Where(e => e.Gg008tKardexId == inKardexGG008ID);

            OsusrE9aCsicpGg008rftransacao? entity = await query.FirstOrDefaultAsync();

            if (entity is null) 
                throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return entity;
        }

        public async Task<(IEnumerable<OsusrE9aCsicpGg008rftransacao>, int)> GetListAsync(
            int inTenantID, string? inKardexGG008ID, string? inNcmID, string inFilialID, int inPageSize, int inPageNumber)
        {
            IQueryable<OsusrE9aCsicpGg008rftransacao> query = _appDbContext.OsusrE9aCsicpGg008rftransacao
                .Where(e => e.TenantId == inTenantID && e.Gg008tFilialid == inFilialID);

            if (inNcmID != null) 
                query = query.Where(e => e.Gg008tNcmId == inNcmID);
            
            if (inKardexGG008ID != null) 
                query = query.Where(e => e.Gg008tKardexId == inKardexGG008ID);

            int count = await query.CountAsync();

            query = query.PaginacaoNoBanco(inPageNumber, inPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}
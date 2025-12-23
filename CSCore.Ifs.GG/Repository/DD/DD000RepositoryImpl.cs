using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.DD;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.DD
{
    public class DD000RepositoryImpl : RepositorioBaseImpl<CSICP_DD000>, IDD000Repository
    {
        private readonly AppDbContext _appDbContext;

        public DD000RepositoryImpl(AppDbContext context)
            : base(context, IdIdentifierName: "Dd000ConfigId", TenantIdentifierName: "TenantId")
        {
            _appDbContext = context;
        }

        public async Task<CSICP_DD000?> GetByIdAsync(string InDD000ID, int InTenantID)
        {
            IQueryable <CSICP_DD000> query = GetQueryWithIncludes(InTenantID);
            return await query.FirstOrDefaultAsync(e => e.Dd000ConfigId == InDD000ID);
        }

        /*public async Task<(List<CSICP_DD000>, int)> GetListAsync(int InTenantID, string? InEstabID, int InPageNumber, int InPageSize)
        {
            IQueryable<CSICP_DD000> query = GetQueryWithIncludes(InTenantID);
            if (!string.IsNullOrWhiteSpace(InEstabID))
                query = query.Where(e => e.Dd000FilialId == InEstabID);

            var queryCount = query;
            var count = await queryCount.CountAsync();
            query = query.OrderBy(e => e.Dd000ConfigId);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            List<CSICP_DD000> resultList = await query.ToListAsync();
            return (resultList, count);
        }*/

        public async Task<(List<CSICP_DD000>, int)> GetListAsync(int InTenantID, string? InEstabID, int InPageNumber, int InPageSize)
        {
            IQueryable<CSICP_DD000> query = _appDbContext.OsusrTeiCsicpDd000s
                .Where(e => e.TenantId == InTenantID)
                .AsNoTracking()
                .Include(e => e.NavDD000FormaPcom)
                .Include(e => e.NavDD000Filial)
                .Include(e => e.NavDD000PvCcusto)
                .Include(e => e.NavDD000PdCcusto)
                .Include(e => e.NavDD000PdvCcusto)
                .Include(e => e.NavDD000CtCcusto)
                .Include(e => e.NavDD000NdCcusto)
                .Include(e => e.NavDD000DcCcusto)
                .Include(e => e.NavDD000DisCcusto)
                .Include(e => e.NavDD000CpCcusto)
                .Include(e => e.NavDD000PvAgcobrador)
                .Include(e => e.NavDD000PdAgcobrador)
                .Include(e => e.NavDD000PdvAgcobrador)
                .Include(e => e.NavDD000CtAgcobrador)
                .Include(e => e.NavDD000NdAgcobrador)
                .Include(e => e.NavDD000DcAgcobrador)
                .Include(e => e.NavDD000DisAgcobrador)
                .Include(e => e.NavDD000CpAgcobrador)
                .Include(e => e.NavDD000PvNatoperacao)
                .Include(e => e.NavDD000PdNatoperacao)
                .Include(e => e.NavDD000PdvNatoperacao)
                .Include(e => e.NavDD000CtNatoperacao)
                .Include(e => e.NavDD000NdNatoperacao)
                .Include(e => e.NavDD000DcNatoperacao)
                .Include(e => e.NavDD000DisNatoperacao)
                .Include(e => e.NavDD000PvConta)
                ;

            if (!string.IsNullOrWhiteSpace(InEstabID))
                query = query.Where(e => e.Dd000FilialId == InEstabID);

            var count = await query.CountAsync();
            
            query = query.OrderBy(e => e.Dd000ConfigId)
                .PaginacaoNoBanco(InPageNumber, InPageSize);

            List<CSICP_DD000> resultList = await query.ToListAsync();
            return (resultList, count);
        }

        
        private IQueryable<CSICP_DD000> GetQueryWithIncludes(int InTenantID)
        {
            return _appDbContext.OsusrTeiCsicpDd000s
                .Where(e => e.TenantId == InTenantID)
                .AsNoTracking()
                .Include(e => e.NavDD000FormaPcom)
                .Include(e => e.NavDD000Filial)
                .Include(e => e.NavDD000PvCcusto)
                .Include(e => e.NavDD000PdCcusto)
                .Include(e => e.NavDD000PdvCcusto)
                .Include(e => e.NavDD000CtCcusto)
                .Include(e => e.NavDD000NdCcusto)
                .Include(e => e.NavDD000DcCcusto)
                .Include(e => e.NavDD000DisCcusto)
                .Include(e => e.NavDD000CpCcusto)
                .Include(e => e.NavDD000PvAgcobrador)
                .Include(e => e.NavDD000PdAgcobrador)
                .Include(e => e.NavDD000PdvAgcobrador)
                .Include(e => e.NavDD000CtAgcobrador)
                .Include(e => e.NavDD000NdAgcobrador)
                .Include(e => e.NavDD000DcAgcobrador)
                .Include(e => e.NavDD000DisAgcobrador)
                .Include(e => e.NavDD000CpAgcobrador)
                .Include(e => e.NavDD000PvNatoperacao)
                .Include(e => e.NavDD000PdNatoperacao)
                .Include(e => e.NavDD000PdvNatoperacao)
                .Include(e => e.NavDD000CtNatoperacao)
                .Include(e => e.NavDD000NdNatoperacao)
                .Include(e => e.NavDD000DcNatoperacao)
                .Include(e => e.NavDD000DisNatoperacao)
                .Include(e => e.NavDD000PvConta)
                .Include(e => e.NavDD000CtrlSerieNf)
                .Include(e => e.NavDD000CtrlSerieCf)
                .Include(e => e.NavDD000CtrlSerieNfce)
                .Include(e => e.NavDD000CtrlContigenciaNfce)
                .Include(e => e.NavDD000CpCondpagto)
                .Include(e => e.NavDD000CpFormapagto)
                .Include(e => e.NavDD000Formapgt)
                .Include(e => e.NavDD000UfOrgao)
                .Include(e => e.NavDD000ComEspecie)
                .Include(e => e.NavDD000AlmoxPadraoTroca)
                .Include(e => e.NavDD000QualRegraAplicar)
                .Include(e => e.NavDD000AmbNfe)
                .Include(e => e.NavDD000VersaoNfe)
                .Include(e => e.NavDD000LcertDigital)
                .Include(e => e.NavDD000ZoneTime)
                .Include(e => e.NavDD000OrigPcomissao)
                .Include(e => e.NavDD000NfsPadrao)
                .Include(e => e.NavDD000NfsRegEspTrib)
                .Include(e => e.NavDD000NfsOtpSN)
                .Include(e => e.NavDD000NfsIncCult)
                .Include(e => e.NavDD000NfsNatOp)
                .Include(e => e.NavDD000RegraLimiteDesconto);
        }
    }
}
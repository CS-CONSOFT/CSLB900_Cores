using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.DD
{
    public class DD000RepositoryImpl : RepositorioBaseImpl<CSICP_DD000>, IDD000Repository
    {
        private readonly AppDbContext _context;

        public DD000RepositoryImpl(AppDbContext context)
            : base(context, IdIdentifierName: "Dd000ConfigId", TenantIdentifierName: "TenantId")
        {
            _context = context;
        }

        public async Task<CSICP_DD000?> GetByIdAsync(string InDD000ID, int InTenantID)
        {
            return await GetQueryWithIncludes()
                .FirstOrDefaultAsync(e => e.Dd000ConfigId == InDD000ID && e.TenantId == InTenantID);
        }

        public async Task<IEnumerable<CSICP_DD000>> GetListAsync(int InTenantID, string? InEstabID)
        {
            var query = GetQueryWithIncludes()
                .Where(e => e.TenantId == InTenantID);

            if (!string.IsNullOrWhiteSpace(InEstabID))
                query = query.Where(e => e.Dd000FilialId == InEstabID);

            return await query.ToListAsync();
        }

        private IQueryable<CSICP_DD000> GetQueryWithIncludes()
        {
            return _context.OsusrTeiCsicpDd000s
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
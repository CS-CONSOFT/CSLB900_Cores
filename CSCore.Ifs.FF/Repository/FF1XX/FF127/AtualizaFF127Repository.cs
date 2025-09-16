using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127
{
    class InternalGetTitulos
    {
        public CSICP_FF125 ff125 { get; set; } = null!;
        public CSICP_FF102 ff102 { get; set; } = null!;
        public CSICP_FF126 ff126 { get; set; } = null!;
        public CSICP_Bb006 bb006 { get; set; } = null!;
    }
    public class AtualizaFF127Repository : IAtualizarFF127Repository
    {
        private readonly AppDbContext _appDbContext;

        public AtualizaFF127Repository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<bool> Atualiza_FF127(PrmAtualizaFF127Repository prmAtualizaFF126Repository)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_FF011? WorkFF011 = await GetWorkFF011(prmAtualizaFF126Repository);

                var WorkGetTitulos = await GetTitulos(prmAtualizaFF126Repository, WorkFF011?.Ff011DiasAtrasosDe ?? 0);

                var WorkFF127 = await GetQueryWorkFF127(prmAtualizaFF126Repository)
                    .AsNoTracking()
                    .Where(e => e.Ff127AgcobradorId != null)
                    .FirstOrDefaultAsync();

                if (WorkFF127 != null && !TemPrevisao(WorkFF127))
                    await InativaHistorico(prmAtualizaFF126Repository);

                var novoIdFF127 = await CriaHistoricoFF127(prmAtualizaFF126Repository, WorkGetTitulos[0].bb006);
                await AtualizaDadosTitulos(prmAtualizaFF126Repository, WorkGetTitulos);
                await CriaHistoricoFF128(prmAtualizaFF126Repository, WorkGetTitulos, novoIdFF127);
                //await transaction.CommitAsync();
                return true;
            }
            catch(Exception ex)
            {
                await transaction.RollbackAsync();
                
                throw new Exception($"Erro ao atualizar FF126: {ex.Message}", ex);
            }
        }

        private async Task CriaHistoricoFF128(PrmAtualizaFF127Repository prmAtualizaFF126Repository, List<InternalGetTitulos> WorkGetTitulos, string novoIdFF127)
        {
            var WorkAddFF128 = CSICP_FF128.Create(
                prmAtualizaFF126Repository.InCS_GenerateID.GenerateUuId(),
                WorkGetTitulos[0].ff126.Ff126TituloId ?? string.Empty,
                prmAtualizaFF126Repository.InDataPrevisao,
                prmAtualizaFF126Repository.InMensagem,
                novoIdFF127,
                WorkGetTitulos[0].ff126.Ff126Diasatrasoent ?? 0,
                WorkGetTitulos[0].ff126.Ff126Sitcobranca ?? 0,
                WorkGetTitulos[0].ff126.Ff126SituacaosaiId ?? 0,
                prmAtualizaFF126Repository.InSY001Id,
                WorkGetTitulos[0].bb006?.Id);

            _appDbContext.OsusrE9aCsicpFf128s.Add(WorkAddFF128);
            await _appDbContext.SaveChangesAsync();
        }

        private async Task AtualizaDadosTitulos(PrmAtualizaFF127Repository prmAtualizaFF126Repository,
            List<InternalGetTitulos> WorkGetTitulos)
        {
            foreach (var currentTitulo in WorkGetTitulos)
            {
                _appDbContext.OsusrE9aCsicpFf126s.Attach(currentTitulo.ff126);
                _appDbContext.OsusrE9aCsicpFf125s.Attach(currentTitulo.ff125);

                currentTitulo.ff126.Ff126Mensagem = prmAtualizaFF126Repository.InMensagem;
                currentTitulo.ff125.Ff125Dtprevisaogeral = prmAtualizaFF126Repository.InDataPrevisao;
                currentTitulo.ff125.Ff125Iscobrado = true;
                currentTitulo.ff125.Ff125Dtcobranca = prmAtualizaFF126Repository.InDataVisita;
                currentTitulo.ff125.Ff125Motivoid = prmAtualizaFF126Repository.InFF002_ID_Motivo;

                _appDbContext.Entry(currentTitulo.ff126).Property(e => e.Ff126Mensagem).IsModified = true;
                _appDbContext.Entry(currentTitulo.ff125).Property(e => e.Ff125Dtprevisaogeral).IsModified = true;
                _appDbContext.Entry(currentTitulo.ff125).Property(e => e.Ff125Iscobrado).IsModified = true;
                _appDbContext.Entry(currentTitulo.ff125).Property(e => e.Ff125Dtcobranca).IsModified = true;
                _appDbContext.Entry(currentTitulo.ff125).Property(e => e.Ff125Motivoid).IsModified = true;
            }

            await _appDbContext.SaveChangesAsync();
        }

        private async Task<CSICP_FF011?> GetWorkFF011(PrmAtualizaFF127Repository prmAtualizaFF126Repository)
        {
            return await _appDbContext.OsusrE9aCsicpFf011s
                .Where(e => e.TenantId == prmAtualizaFF126Repository.InTenantID)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        private IQueryable<CSICP_FF127> GetQueryWorkFF127(PrmAtualizaFF127Repository prmAtualizaFF126Repository)
        {
            return _appDbContext.OsusrE9aCsicpFf127s
                            .Where(x => x.TenantId == prmAtualizaFF126Repository.InTenantID
                            && x.Ff127Isactive == true
                            && x.Ff127ContaId == prmAtualizaFF126Repository.InBB012_ID);
        }

        private async Task<string> CriaHistoricoFF127(PrmAtualizaFF127Repository prm, CSICP_Bb006? InBB006)
        {
            string novoId = prm.InCS_GenerateID.GenerateUuId();
            var WorkNewFF127 = CSICP_FF127.CreateInstance(
                    prm.InTenantID,
                    novoId,
                    prm.InNovoProtocoloFF127,
                    prm.InBB012_ID,
                    prm.InDataPrevisao,
                    prm.InMensagem,
                    prm.InSY001Id,
                    InBB006?.Id ?? "",
                    prm.InDataVisita,
                    prm.InSY001Id,
                    prm.InFF002_ID_Motivo);
            
            _appDbContext.OsusrE9aCsicpFf127s.Add(WorkNewFF127);
            await _appDbContext.SaveChangesAsync();
            return novoId;
        }

        private async Task InativaHistorico(PrmAtualizaFF127Repository prmAtualizaFF126Repository)
        {
            var WorkFF127List = await GetQueryWorkFF127(prmAtualizaFF126Repository)
                .ToListAsync();

            var WorkFF127Ids = WorkFF127List.DistinctBy(x => x.Ff127Id).Select(x => x.Ff127Id).ToList();

            var WorkFF128List = await _appDbContext.OsusrE9aCsicpFf128s
                .Where(x => x.TenantId == prmAtualizaFF126Repository.InTenantID
                    && WorkFF127Ids.Contains(x.Ff127Id)
                    && x.Ff128Isactive == true)
                .ToListAsync();

            // Crie um dicionário para lookup rápido dos FF128 por Ff128Id (que corresponde ao Ff127Id)
            var WorkDictionaryFF128 = WorkFF128List.ToDictionary(x => x.Ff127Id);

            foreach (var currentFF127 in WorkFF127List)
            {
                currentFF127.Ff127Isactive = false;

                // Inativa o FF128 relacionado, se existir
                if (WorkDictionaryFF128.TryGetValue(currentFF127.Ff127Id, out var ff128))
                {
                    ff128.Ff128Isactive = false;
                }
            }

            await _appDbContext.SaveChangesAsync();
        }

        private async Task<List<InternalGetTitulos>> GetTitulos(PrmAtualizaFF127Repository prm, int FF011_Dias_Atrasos_De)
        {
            var result = await (from ff125 in _appDbContext.OsusrE9aCsicpFf125s
                          join ff102 in _appDbContext.OsusrE9aCsicpFf102s on ff125.Ff125ContaId equals ff102.Ff102Contaid
                          join ff126 in _appDbContext.OsusrE9aCsicpFf126s on ff102.Id equals ff126.Ff126TituloId
                          join bb006 in _appDbContext.OsusrE9aCsicpBb006s on ff125.Ff125AgcobradorId equals bb006.Id into bb006Left
                          from bb006 in bb006Left.DefaultIfEmpty()
                          where ff125.Ff125ContaId == prm.InBB012_ID
                                && EF.Functions.DateDiffDay(ff102.Ff102DataVencimento, DateTime.UtcNow) >= FF011_Dias_Atrasos_De
                                && (ff102.Ff102Situacaoid == prm.InSTIDFF102SitAberto 
                                || ff102.Ff102Situacaoid == prm.InSTIDFF102SitBxParcial)
                          select new InternalGetTitulos
                          {
                             ff125= ff125,
                             ff102 = ff102,
                             ff126 =  ff126,
                              bb006 = bb006
                          }).ToListAsync();

            return result;
        }

        private static bool TemPrevisao(CSICP_FF127 WorkFF127)
        {
            return WorkFF127.Ff127Dtprevisao >= DateTime.UtcNow;
        }
    }
}

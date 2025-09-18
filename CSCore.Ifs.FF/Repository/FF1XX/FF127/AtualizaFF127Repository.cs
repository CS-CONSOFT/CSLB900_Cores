using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
            CSICP_FF011? WorkFF011 = await GetWorkFF011(prmAtualizaFF126Repository);

            var WorkGetTitulos = await GetTitulos125_102(prmAtualizaFF126Repository, WorkFF011?.Ff011DiasAtrasosDe ?? 0);
            if(WorkGetTitulos.Count == 0)
                throw new KeyNotFoundException("Nenhum título encontrado para o cobrador informado.");

            var WorkFF127 = await GetQueryWorkFF127(prmAtualizaFF126Repository.InTenantID, prmAtualizaFF126Repository.InBB012_ID)
                .AsNoTracking()
                .Where(e => e.Ff127AgcobradorId != null)
                .FirstOrDefaultAsync();

            if(WorkFF127 != null)
            {
                if (DataPrevisaoEhMaiorOuIgualDoQueHoje(WorkFF127))
                    await InativaHistorico(prmAtualizaFF126Repository);
            }

            foreach (var current in WorkGetTitulos)
            {
                var novoIdFF127 = CriaHistoricoFF127(prmAtualizaFF126Repository, current.bb006);
                AtualizaDadosTitulos(prmAtualizaFF126Repository, WorkGetTitulos);
                CriaHistoricoFF128(prmAtualizaFF126Repository, current, novoIdFF127);
            }
            return true;
        }

        private static bool DataPrevisaoEhMaiorOuIgualDoQueHoje(CSICP_FF127 WorkFF127)
        {
            return !TemPrevisao(WorkFF127);
        }

        private  void CriaHistoricoFF128(
            PrmAtualizaFF127Repository prmAtualizaFF126Repository,
            InternalGetTitulos WorkGetTitulos,
            string novoIdFF127)
        {
            var WorkAddFF128 = CSICP_FF128.Create(
                prmAtualizaFF126Repository.InCS_GenerateID.GenerateUuId(),
                WorkGetTitulos.ff126.Ff126TituloId ?? string.Empty,
                prmAtualizaFF126Repository.InDataPrevisao,
                prmAtualizaFF126Repository.InDataVisita,
                prmAtualizaFF126Repository.InMensagem,
                novoIdFF127,
                WorkGetTitulos.ff126.Ff126Diasatrasoent,
                WorkGetTitulos.ff126.Ff126Sitcobranca,
                WorkGetTitulos.ff126.Ff126SituacaosaiId,
                prmAtualizaFF126Repository.InSY001Id,
                WorkGetTitulos.bb006?.Id,
                prmAtualizaFF126Repository.InTenantID);

            _appDbContext.Add(WorkAddFF128);

        }

        private void AtualizaDadosTitulos(PrmAtualizaFF127Repository prmAtualizaFF126Repository,
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


        }

        private async Task<CSICP_FF011?> GetWorkFF011(PrmAtualizaFF127Repository prmAtualizaFF126Repository)
        {
            return await _appDbContext.OsusrE9aCsicpFf011s
                .Where(e => e.TenantId == prmAtualizaFF126Repository.InTenantID)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        private IQueryable<CSICP_FF127> GetQueryWorkFF127(int InTenantID, string InContaID)
        {
            return _appDbContext.OsusrE9aCsicpFf127s
                            .Where(x => x.TenantId == InTenantID
                            && x.Ff127Isactive == true
                            && x.Ff127ContaId == InContaID);
        }

        private string CriaHistoricoFF127(PrmAtualizaFF127Repository prm, CSICP_Bb006? InBB006)
        {
            string novoId = prm.InCS_GenerateID.GenerateUuId();
            var WorkNewFF127 = CSICP_FF127.CreateInstance(
                    prm.InTenantID,
                    novoId,
                    prm.InNovoProtocoloFF127,
                    prm.InBB012_ID,
                    prm.InDataPrevisao,
                    prm.InMensagem,
                    InBB006?.Id ?? "",
                    prm.InDataVisita,
                    prm.InSY001Id,
                    prm.InFF002_ID_Motivo);
            
            _appDbContext.Add(WorkNewFF127);

            return novoId;
        }


        /*FLUXO USADO FORA DO METODO Atualiza_FF127, É USADO EM UMA VARIACAO DE wb_Atualiza_reg_SPC*/
        public async Task<string> CriaHistoricoFF127(
            CSICP_FF125 InFF125,
            CSICP_FF126 InFF126,
            string InNovoIDFF127,
            string? InSY001ID,
            string InNovoProtocoloFF127)
        {
            var WorkFF127 = await GetQueryWorkFF127(InFF125.TenantId, InFF125.Ff125ContaId)
                  .Where(e => e.Ff127AgcobradorId != null)
                  .FirstOrDefaultAsync();

            if(WorkFF127 == null)
            {
                var novoFF127 = CSICP_FF127
                    .CreateInstance(
                        InFF125.TenantId,
                        InNovoIDFF127,
                        InNovoProtocoloFF127,
                        InFF125.Ff125ContaId,
                        InFF125.Ff125Dtprevisaogeral,
                        mensagem: "",
                        agCobradorId: null,
                        dataVisita: null,
                        InSY001ID,
                        ff001IdMotivo: null
                    );
                _appDbContext.OsusrE9aCsicpFf127s.Add(novoFF127);
                return InNovoIDFF127;
            }

            if (WorkFF127 != null && DataPrevisaoEhMaiorOuIgualDoQueHoje(WorkFF127))
                InativaRegistroFF127(WorkFF127, InFF126.Ff126Mensagem);

            return WorkFF127!.Ff127Id;
        }

        private async Task InativaHistorico(PrmAtualizaFF127Repository prmAtualizaFF126Repository)
        {
            var WorkFF127List = await GetQueryWorkFF127(prmAtualizaFF126Repository.InTenantID, prmAtualizaFF126Repository.InBB012_ID)
                .ToListAsync();

            var WorkFF127Ids = WorkFF127List.DistinctBy(x => x.Ff127Id).Select(x => x.Ff127Id).ToList();

            var WorkFF128List = await _appDbContext.OsusrE9aCsicpFf128s
                .Where(x => x.TenantId == prmAtualizaFF126Repository.InTenantID
                    && WorkFF127Ids.Contains(x.Ff127Id)
                    && x.Ff128Isactive == true)
                .ToListAsync();

            var WorkDictionaryFF128 = WorkFF128List
             .GroupBy(x => x.Ff127Id)
             .ToDictionary(g => g.Key, g => g.First());

            foreach (var currentFF127 in WorkFF127List)
            {
                currentFF127.Ff127Isactive = false;

                // Inativa o FF128 relacionado, se existir
                if (WorkDictionaryFF128.TryGetValue(currentFF127.Ff127Id, out var ff128))
                {
                    ff128.Ff128Isactive = false;
                }
            }
        }

        private void InativaRegistroFF127(CSICP_FF127 InFF127, string InFF126Mensagem)
        {
            InFF127.Ff127Isvisitado = false;
            InFF127.Ff127Mensagem = InFF126Mensagem;
        }

        private async Task<List<InternalGetTitulos>> GetTitulos125_102(PrmAtualizaFF127Repository prm, int FF011_Dias_Atrasos_De)
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

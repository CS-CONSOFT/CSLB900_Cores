using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR022;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso
{
    public class RR022RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr022>, IRR022Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR022RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr022?> GetByIdAsync(int In_TenantID, string In_IDRR022)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Animal_RR022)
                .Include(e => e.NavRR021LoteXAnimal_RR022);

            OsusrTo3CsicpRr022? CSICP_RR022 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR022);
            return CSICP_RR022;
        }

        public async Task<(List<OsusrTo3CsicpRr022>, int)> GetListPesoAnimalRR022Async(int In_TenantID, PrmFiltrosRR022 prm)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Include(e => e.NavRR001Animal_RR022)
                .Include(e => e.NavRR021LoteXAnimal_RR022);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr022>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR022;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroLoteIdRR022(filtros.In_LoteId),
                new FiltroDataPesoRR022(filtros.In_DataPeso),
            ];
        }

        public async Task<List<DtoGetCountPesoAnimalRR022>> GetListCountPesoAnimalAsync(int In_TenantID, string In_LoteId)
        {
            var result = await _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .Where(e => e.TenantId == In_TenantID
                    && e.Rr022Loteid == In_LoteId)
                .GroupBy(e => new { e.Rr022Dtpeso, e.Rr022Loteid })
                .Select(g => new DtoGetCountPesoAnimalRR022
                {
                    Data = g.Key.Rr022Dtpeso,
                    Lote = g.Key.Rr022Loteid,
                    QtdReg = g.Count()
                })
                .OrderBy(x => x.Data)
                .ToListAsync();

            return result;
        }

        public async Task<bool> ExisteRegistroPesoAsync(int In_TenantID, string In_LoteId, string In_AnimalId, DateTime In_DataPeso)
        {
            return await _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AnyAsync(e =>
                    e.TenantId == In_TenantID &&
                    e.Rr022Loteid == In_LoteId &&
                    e.Rr022Animalid == In_AnimalId &&
                    e.Rr022Dtpeso.HasValue &&
                    e.Rr022Dtpeso.Value.Date == In_DataPeso.Date);
        }

        public async Task<OsusrTo3CsicpRr022> GetByIdRR022SimplesAsync(int In_TenantID, string In_IDRR022)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr022? CSICP_RR022 = await query.FirstOrDefaultAsync(e => e.Id == In_IDRR022);
            return CSICP_RR022;
        }

        public async Task<CSResult<string>> GetExecutaProcessaPesoAnimalAsync(int InTenantID, string? InLoteId, DateTime? InDataPeso)
        {
            var listRR022 = await GetListPesoAnimalRR022ParaProcessoAsync(InTenantID, InLoteId, InDataPeso);
            if (listRR022.Count == 0)
                return CSResult<string>.Failure("Nenhum registro encontrado para processar");

            var erros = new List<string>();
            int processados = 0;

            foreach (var rr022 in listRR022)
            {
                if (rr022 == null)
                    continue;
                //Faço uma validação para esse NAVAnimal?
                rr022.NavRR001Animal_RR022.DefinirUltimoPesoQuandoOPesoENull(
                    rr022.NavRR001Animal_RR022.Rr001Dtnascimento, rr022.NavRR001Animal_RR022.Rr001Pesonasc);
                
                // Atualizando campo data último peso na tabela RR022 pegando campo data último peso da tabela RR001 (Animal) 
                rr022.Rr001Dtultpeso = rr022.NavRR001Animal_RR022.Rr001Dtultpeso;
                rr022.Rr001Ultpeso = rr022.NavRR001Animal_RR022.Rr001Ultpeso;

                var resultIdadeAtual = rr022.CalcularIdadeDiasAtual();
                if (!resultIdadeAtual.IsSuccess)
                {
                    erros.Add($"Animal {rr022.Rr022Animalid}: {resultIdadeAtual.Message}");
                    continue;
                }

                var resultIdadeUlt = rr022.CalcularIdadeDiasUlt();
                if (!resultIdadeUlt.IsSuccess)
                {
                    erros.Add($"Animal {rr022.Rr022Animalid}: {resultIdadeUlt.Message}");
                    continue;
                }

                var resultGmd = rr022.CalcularGmd();
                if (!resultGmd.IsSuccess)
                {
                    erros.Add($"Animal {rr022.Rr022Animalid}: {resultGmd.Message}");
                    continue;
                }

                var resultGpd = rr022.CalcularGpd();
                if (!resultGpd.IsSuccess)
                {
                    erros.Add($"Animal {rr022.Rr022Animalid}: {resultGpd.Message}");
                    continue;
                }
                rr022.Rr022IsProcessado = true;
                rr022.NavRR001Animal_RR022.Rr001Dtultpeso = rr022.Rr022Dtpeso;
                rr022.NavRR001Animal_RR022.Rr001Ultpeso = rr022.Rr022Peso;
                rr022.NavRR001Animal_RR022.Rr001Ultidadediaspeso = rr022.Rr022Idadediasult;

                processados++;
            }

            await _appDbContext.SaveChangesAsync();

            if (erros.Any())
                return CSResult<string>.Failure(
                    $"Processados {processados} registros com {erros.Count} erros: {string.Join("; ", erros)}");

            return CSResult<string>.Success($"{processados} registros processados com sucesso.");
        }

        public async Task<List<OsusrTo3CsicpRr022>> GetListPesoAnimalRR022ParaProcessoAsync(int InTenantID, string? InLoteId, DateTime? InDataPeso)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsSplitQuery()
                .Where(e => e.TenantId == InTenantID && e.Rr022IsProcessado == false)
                .Include(e => e.NavRR001Animal_RR022);

            // Filtro de lote
            if (!string.IsNullOrWhiteSpace(InLoteId))
                query = query.Where(e => e.Rr022Loteid == InLoteId);

            // Filtro de data
            if (InDataPeso.HasValue)
            {
                var dataInicio = InDataPeso.Value.Date;
                var dataFim = dataInicio.AddDays(1);
                query = query.Where(e => e.Rr022Dtpeso.HasValue &&
                                        e.Rr022Dtpeso.Value >= dataInicio &&
                                        e.Rr022Dtpeso.Value < dataFim);
            }

            // Retorna até 999 registros por vez (ajuste conforme necessário)
            var listItems = await query.Take(999).ToListAsync(); //verificar essa quantidade de registros (Aumenta ou diminui?)

            return listItems;
        }
    }
}
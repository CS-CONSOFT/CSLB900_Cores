using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal
{
    public class RR001RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr001>, IRR001Repository
    {
        private readonly AppDbContext _appDbContext;
        public RR001RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr001?> GetByIdAsync(int In_TenantID, string In_IDRR001)
        {
            IQueryable<OsusrTo3CsicpRr001> query = _appDbContext.OsusrTo3CsicpRr001s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Pai)
                .Include(e => e.NavRR001Mae)
                .Include(e => e.NavRR002Fazenda_RR001)
                .Include(e => e.NavRR003CadastroCat_RR001)
                .Include(e => e.NavRR004Raca_RR001)
                .Include(e => e.NavRR005Situacao_RR001)
                .Include(e => e.NavRR006Ocorrencia_RR001)
                .Include(e => e.NavRR007Proprietario_RR001)
                .Include(e => e.NavRR001Ativo_RR001)
                .Include(e => e.NavRR001Categoria_RR001)
                .Include(e => e.NavRR001Sexo_RR001)
                .Include(e => e.NavSy001_RR001);

            OsusrTo3CsicpRr001? CSICP_RR001 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR001);
            return CSICP_RR001;
        }

        public async Task<(List<OsusrTo3CsicpRr001>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR001 prm)
        {
            IQueryable<OsusrTo3CsicpRr001> query = _appDbContext.OsusrTo3CsicpRr001s
                .AsNoTracking()
                .AsSplitQuery()
                .Include(e => e.NavRR001Pai)
                .Include(e => e.NavRR001Mae)
                .Include(e => e.NavRR002Fazenda_RR001)
                .Include(e => e.NavRR003CadastroCat_RR001)
                .Include(e => e.NavRR004Raca_RR001)
                .Include(e => e.NavRR005Situacao_RR001)
                .Include(e => e.NavRR006Ocorrencia_RR001)
                .Include(e => e.NavRR007Proprietario_RR001)
                .Include(e => e.NavRR001Ativo_RR001)
                .Include(e => e.NavRR001Categoria_RR001)
                .Include(e => e.NavRR001Sexo_RR001)
                .Include(e => e.NavSy001_RR001);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr001>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR001;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroNomeAnimalRR001(filtros.In_Nomeanimal),
                new FiltroNumeroRGNRR001(filtros.In_NumeroRGN),
                new FiltroSerieRR001(filtros.In_Serie),
                new FiltroRacaIDRR001(filtros.In_RacaID),
                new FiltroSexoIDRR001(filtros.In_SexoID),
                new FiltroSituacaoIDRR001(filtros.In_SituacaoID),
                new FiltroApelidoRR001(filtros.In_Apelido),
                new FiltroAtivoIDRR001(filtros.In_AtivoID),
                new FiltroDataNascimentoRR001(filtros.In_DataNascimento),
            ];
        }

        public async Task<(List<OsusrTo3CsicpRr001>, int)> GetListAnimaisSemLoteAsync(int In_TenantID, int pageNumber, int pageSize)
        {
            IQueryable<OsusrTo3CsicpRr001> query = _appDbContext.OsusrTo3CsicpRr001s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Pai)
                .Include(e => e.NavRR001Mae)
                .Include(e => e.NavRR002Fazenda_RR001)
                .Include(e => e.NavRR003CadastroCat_RR001)
                .Include(e => e.NavRR004Raca_RR001)
                .Include(e => e.NavRR005Situacao_RR001)
                .Include(e => e.NavRR006Ocorrencia_RR001)
                .Include(e => e.NavRR007Proprietario_RR001)
                .Include(e => e.NavRR001Ativo_RR001)
                .Include(e => e.NavRR001Categoria_RR001)
                .Include(e => e.NavRR001Sexo_RR001)
                .Include(e => e.NavSy001_RR001)
                .Where(e => !_appDbContext.OsusrTo3CsicpRr021s
                    .Where(rr021 => rr021.TenantId == In_TenantID &&
                                    rr021.Rr021Animalid == e.Id &&
                                    rr021.NavRR020RegLote_RR021 != null &&
                                    rr021.NavRR020RegLote_RR021.Rr020IsActive == true)
                    .Any());

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(pageNumber, pageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        public async Task<bool> ExisteAnimalRR001Async(int In_TenantID, string In_Rr001Id)
        {
            return await _appDbContext.OsusrTo3CsicpRr001s
                .AnyAsync(x => x.TenantId == In_TenantID && x.Id == In_Rr001Id);
        }

        /// <summary>
        /// Busca múltiplos animais por lista de IDs (para ancestrais)
        /// </summary>
        public async Task<List<OsusrTo3CsicpRr001>> GetManyByIdsAsync(int tenantId, List<string> animalIds)
        {
            if (animalIds == null || !animalIds.Any())
                return new List<OsusrTo3CsicpRr001>();

            return await _appDbContext.OsusrTo3CsicpRr001s
                .AsNoTracking()
                .Where(a => a.TenantId == tenantId && animalIds.Contains(a.Id))
                .ToListAsync();
        }

        /// <summary>
        /// Busca todos os filhos de um animal (descendentes diretos)
        /// </summary>
        public async Task<List<OsusrTo3CsicpRr001>> GetFilhosAsync(int tenantId, string animalId)
        {
            return await _appDbContext.OsusrTo3CsicpRr001s
                .AsNoTracking()
                .Where(a => a.TenantId == tenantId && 
                           (a.Rr001PaiId == animalId || a.Rr001MaeId == animalId))
                .ToListAsync();
        }
    }
}

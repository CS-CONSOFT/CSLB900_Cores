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
        public RR001RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr001?> GetByIdAsync(int In_TenantID, string In_IDRR001)
        {
            IQueryable<OsusrTo3CsicpRr001> query = GetQueryBase(In_TenantID);

            OsusrTo3CsicpRr001? CSICP_RR001 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR001);
            return CSICP_RR001;
        }

        public async Task<(List<OsusrTo3CsicpRr001>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR001 prm)
        {
            IQueryable<OsusrTo3CsicpRr001> query = GetQueryBase(In_TenantID);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        private IQueryable<OsusrTo3CsicpRr001> GetQueryBase(int In_TenantID)
        {
            return _appDbContext.OsusrTo3CsicpRr001s
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
    }
}

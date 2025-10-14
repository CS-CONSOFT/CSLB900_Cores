using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X;
using CSCore.Domain.Interfaces.RR._00X.IRR001;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .Include(e => e.NavRR001Ativo)
                .Include(e => e.NavRR001Cat)
                .Include(e => e.NavRR001Categoria)
                .Include(e => e.NavRR001Fazenda)
                .Include(e => e.NavRR001Mae)
                .Include(e => e.NavRR001Ocorrencia)
                .Include(e => e.NavRR001Pai)
                .Include(e => e.NavRR001Proprietario)
                .Include(e => e.NavRR001Raca)
                .Include(e => e.NavRR001Sexo)
                .Include(e => e.NavRR001Situacao);
        }

        protected override ICSFilter<OsusrTo3CsicpRr001>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR001;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroNomeAnimalRR001(filtros.In_Nomeanimal),
                new FiltroNumeroRGNRR001(filtros.In_NumeroRGN),
                new FiltroApelidoRR001(filtros.In_Apelido),
                new FiltroAtivoIDRR001(filtros.In_AtivoID),
                new FiltroDataNascimentoRR001(filtros.In_DataNascimento),
            ];
        }
    }
}

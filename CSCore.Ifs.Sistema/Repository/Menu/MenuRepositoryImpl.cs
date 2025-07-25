using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces;
using CSCore.Domain.Interfaces.Menu;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CSCore.Ifs.Repository.Menu
{
    public class MenuRepositoryImpl(AppDbContext appDbContext,
        ISY014Repository sY014Repository,
        ISY015Repository sY015Repository,
        ISY009Repository sY009Repository) : IMenuRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly ISY009Repository _sY009Repository = sY009Repository;
        private readonly ISY014Repository _sY014Repository = sY014Repository;
        private readonly ISY015Repository _sY015Repository = sY015Repository;


        public async Task<bool> MontaMenu(string currentMenuID,
          string currentSubMenuID, List<string> listaProgramasID, string grupoID, int Tenant_ID)
        {
            foreach (var currentProgramaID in listaProgramasID)
            {
                await SalvaSY009(grupoID, Tenant_ID, currentProgramaID);
            }

            await SalvaSY015(currentSubMenuID, grupoID, Tenant_ID);

            await SalvaSY014(currentMenuID, grupoID, Tenant_ID);

            return true;
        }



        public async Task<bool> DesmontaMenu(string currentMenuID,
            string currentSubMenuID, List<string> listaProgramasID, string grupoID, int Tenant_ID)
        {
            List<Csicp_Sy009> ListaSy009GrupoProgramas = await GetSY009List(grupoID, currentSubMenuID);
            int numeroProgramas = ListaSy009GrupoProgramas.Count;

            foreach (var currentProgramaID in listaProgramasID)
            {
                await RemoveSY009(grupoID, Tenant_ID, currentProgramaID);
            }

            if (numeroProgramas == listaProgramasID.Count)
            {
                await RemoveSY015(currentSubMenuID, grupoID, Tenant_ID);
            }

            List<Csicp_Sy015> ListaSubMenuDoMenuAtual = await GetSY015List(grupoID, currentMenuID);
            int numeroSubMenuNoMenu = ListaSubMenuDoMenuAtual.Count;
            if (numeroSubMenuNoMenu == 0) await RemoveSY014(currentMenuID, grupoID, Tenant_ID);
            return true;
        }



        public async Task<List<CsicpSy902Menu>> GetMenuList()
        {
            List<CsicpSy902Menu> csicpSy902Menus = await _appDbContext.OsusrI4yCsicpSy902Menus
                .AsSplitQuery()
                .Where(e => e.Isactive == true && e.Menutipo == 0)
                .Include(e => e.ListaSubmenus)
                .ThenInclude(sm => sm.ListaSubMenuProgramas)
                .ThenInclude(smp => smp.NavPrograma)
                .ToListAsync();
            return csicpSy902Menus;
        }

        public async Task<List<Csicp_Sy014>> GetSY014List(string grupoID)
        {
            List<Csicp_Sy014> listaSY014ComMenu = await _appDbContext.OsusrE9aCsicpSy014s
                 .Where(e => e.Sy014Grupoid == grupoID)
                 .Include(e => e.CsicpSy902Menu)
                 .OrderBy(e => e.CsicpSy902Menu.Label)
                 .ToListAsync();

            return listaSY014ComMenu;
        }

        public async Task<Csicp_Sy014?> GetSY014PorId(string grupoID, string menuID)
        {
            Csicp_Sy014? SY014 = await _appDbContext.OsusrE9aCsicpSy014s
                 .Where(e => e.Sy014Grupoid == grupoID)
                 .Where(e => e.Sy902MenuId == menuID)
                 .Include(e => e.CsicpSy902Menu)
                 .FirstOrDefaultAsync();

            return SY014;
        }

        public async Task<List<Csicp_Sy015>> GetSY015List(string grupoID, string SY014GrupoMenuId)
        {
            List<Csicp_Sy015> listaSY015ComSubMenu = [];
            listaSY015ComSubMenu = await _appDbContext.OsusrE9aCsicpSy015s
                    .Include(e => e.NavSY903SubMenu)
                    .Where(e => e.NavSY903SubMenu.Isactive == true)
                    .Where(e => e.NavSY903SubMenu.Menu == SY014GrupoMenuId)
                    .Where(e => e.Sy015Grupoid == grupoID).ToListAsync();

            return listaSY015ComSubMenu;
        }

        public async Task<List<Csicp_Sy009>> GetSY009List(string grupoID, string SY015GrupoSubMenuID)
        {
            List<Csicp_Sy009> listaSY009ComPrograma = [];
            listaSY009ComPrograma = await (from sy009 in _appDbContext.OsusrE9aCsicpSy009s

                                           join sy904PRG in _appDbContext.OsusrI4yCsicpSy904Prgs
                                           on sy009.Sy904ProgramaId equals sy904PRG.Id

                                           join sy905SMPrg in _appDbContext.OsusrI4yCsicpSy905Smprgs
                                           on sy904PRG.Id equals sy905SMPrg.Programa

                                           where sy009.Sy009Grupoid == grupoID
                                           where sy904PRG.IsActive == true
                                           where sy905SMPrg.Submenu == SY015GrupoSubMenuID

                                           select new Csicp_Sy009
                                           {
                                               Id = sy009.Id,
                                               TenantId = sy009.TenantId,
                                               Sy009Grupoid = sy009.Sy009Grupoid,
                                               Sy904ProgramaId = sy009.Sy904ProgramaId,
                                               NavSY904Prg = new CsicpSy904Prg
                                               {
                                                   Id = sy904PRG.Id,
                                                   Label = sy904PRG.Label,
                                                   Programa = sy904PRG.Programa,
                                                   Ordem = sy904PRG.Ordem,
                                                   SpacenameId = sy904PRG.SpacenameId,
                                                   Url = sy904PRG.Url,
                                                   Descricao = sy904PRG.Descricao,
                                                   Cor = sy904PRG.Cor,
                                                   Dimensao = sy904PRG.Dimensao,
                                                   Fonticon = sy904PRG.Fonticon,
                                                   IsActive = sy904PRG.IsActive,
                                                   Datacreate = sy904PRG.Datacreate,
                                                   Nivelprograma = sy904PRG.Nivelprograma,
                                                   IdSy804 = sy904PRG.IdSy804,
                                                   PropCsSisproId = sy904PRG.PropCsSisproId,
                                                   LabelEnglish = sy904PRG.LabelEnglish,
                                                   DescricaoEnglish = sy904PRG.DescricaoEnglish,
                                                   LabelSpanish = sy904PRG.LabelSpanish,
                                                   DescricaoSpanish = sy904PRG.DescricaoSpanish,
                                                   Categoriaid = sy904PRG.Categoriaid,
                                                   Menutipo = sy904PRG.Menutipo,
                                               }
                                           }).ToListAsync();

            return listaSY009ComPrograma;
        }

        public async Task<List<Csicp_Sy005>> GetMenuListPorUsuario(string usuarioID)
        {
            List<Csicp_Sy005> csicp_Sy005s = await _appDbContext.OsusrE9aCsicpSy005s
                .Where(e => e.Sy005Userid == usuarioID)
                .Include(e => e.Sy014GrupoMenu)
                    .ThenInclude(e => e.CsicpSy902Menu)
                     .ThenInclude(e => e.ListaSubmenus)
                        .ThenInclude(e => e.ListaSubMenuProgramas)
                            .ThenInclude(e => e.NavPrograma)

                .ToListAsync();
            return csicp_Sy005s;
        }






        private async Task SalvaSY009(string grupoID, int Tenant_ID, string currentProgramaID)
        {
            await SalvaEntidadeCasoSejaMontarERemoveCasoNao(
                    _sY009Repository,
                    _appDbContext.OsusrE9aCsicpSy009s,
                    () => new Csicp_Sy009
                    {
                        Id = GeraIdLocalmente(),
                        Sy009Grupoid = grupoID,
                        Sy904ProgramaId = currentProgramaID,
                        TenantId = Tenant_ID
                    },
                    e => e.Sy009Grupoid == grupoID && e.Sy904ProgramaId == currentProgramaID,
                    true
                );
        }
        private async Task SalvaSY015(string currentSubMenuID, string grupoID, int Tenant_ID)
        {
            await SalvaEntidadeCasoSejaMontarERemoveCasoNao(
                    _sY015Repository,
                    _appDbContext.OsusrE9aCsicpSy015s,
                    () => new Csicp_Sy015
                    {
                        Id = GeraIdLocalmente(),
                        Sy015Grupoid = grupoID,
                        Sy903SubmenuId = currentSubMenuID,
                        TenantId = Tenant_ID
                    },
                    e => e.Sy015Grupoid == grupoID && e.Sy903SubmenuId == currentSubMenuID,
                    true
                );
        }
        private async Task SalvaSY014(string currentMenuID, string grupoID, int Tenant_ID)
        {
            await SalvaEntidadeCasoSejaMontarERemoveCasoNao(
                _sY014Repository,
                _appDbContext.OsusrE9aCsicpSy014s,
                () => new Csicp_Sy014
                {
                    Id = GeraIdLocalmente(),
                    Sy014Grupoid = grupoID,
                    Sy902MenuId = currentMenuID,
                    TenantId = Tenant_ID
                },
                e => e.Sy014Grupoid == grupoID && e.Sy902MenuId == currentMenuID,
                true
            );
        }

        private async Task RemoveSY009(string grupoID, int Tenant_ID, string currentProgramaID)
        {
            await SalvaEntidadeCasoSejaMontarERemoveCasoNao(
                    _sY009Repository,
                    _appDbContext.OsusrE9aCsicpSy009s,
                    () => new Csicp_Sy009
                    {
                        Id = GeraIdLocalmente(),
                        Sy009Grupoid = grupoID,
                        Sy904ProgramaId = currentProgramaID,
                        TenantId = Tenant_ID
                    },
                    e => e.Sy009Grupoid == grupoID && e.Sy904ProgramaId == currentProgramaID,
                    false
                );
        }
        private async Task RemoveSY015(string currentSubMenuID, string grupoID, int Tenant_ID)
        {
            await SalvaEntidadeCasoSejaMontarERemoveCasoNao(
                    _sY015Repository,
                    _appDbContext.OsusrE9aCsicpSy015s,
                    () => new Csicp_Sy015
                    {
                        Id = GeraIdLocalmente(),
                        Sy015Grupoid = grupoID,
                        Sy903SubmenuId = currentSubMenuID,
                        TenantId = Tenant_ID
                    },
                    e => e.Sy015Grupoid == grupoID && e.Sy903SubmenuId == currentSubMenuID,
                    false
                );
        }
        private async Task RemoveSY014(string currentMenuID, string grupoID, int Tenant_ID)
        {
            await SalvaEntidadeCasoSejaMontarERemoveCasoNao(
                _sY014Repository,
                _appDbContext.OsusrE9aCsicpSy014s,
                () => new Csicp_Sy014
                {
                    Id = GeraIdLocalmente(),
                    Sy014Grupoid = grupoID,
                    Sy902MenuId = currentMenuID,
                    TenantId = Tenant_ID
                },
                e => e.Sy014Grupoid == grupoID && e.Sy902MenuId == currentMenuID,
                false
            );
        }


        private static async Task SalvaEntidadeCasoSejaMontarERemoveCasoNao<TEntity>(
            IBaseCD<TEntity> repository,
            DbSet<TEntity> dbSet,
            Func<TEntity> criarEntidade,
            Expression<Func<TEntity, bool>> filtroBusca,
            bool isMonta = true
        ) where TEntity : class
        {
            var entidadeExistente = await dbSet.AsNoTracking().FirstOrDefaultAsync(filtroBusca);
            if (isMonta)
            {
                if (entidadeExistente == null)
                {
                    TEntity? novaEntidade = criarEntidade();
                    await repository.CreateAsync(novaEntidade);
                }
            }
            else
            {
                if (entidadeExistente == null)
                    throw new KeyNotFoundException($"Registro não encontrado para os critérios fornecidos.");
                await repository.RemoveAsync(entidadeExistente);
            }
        }


        private static string GeraIdLocalmente()
        {
            return Guid.CreateVersion7().ToString("N");
        }
    }
}


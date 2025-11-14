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
            // 1️⃣ Busca apenas menus ativos - query leve
            var menusAtivos = await _appDbContext.OsusrI4yCsicpSy902Menus
                .AsNoTracking()
                .Where(e => e.Isactive == true && e.Menutipo == 0)
                .ToListAsync();

            if (menusAtivos.Count == 0)
                return [];

            var menuIds = menusAtivos.Select(m => m.Id).ToList();

            // 2️⃣ Busca submenus ativos em uma query separada
            var submenusAtivos = await _appDbContext.OsusrI4yCsicpSy903Smenus
                .AsNoTracking()
                .Where(sm => menuIds.Contains(sm.Menu) && sm.Isactive == true)
                .ToListAsync();

            var submenuIds = submenusAtivos.Select(sm => sm.Id).ToList();

            // 3️⃣ Busca relações submenu-programa em uma query
            var submenuProgramasAtivos = await _appDbContext.OsusrI4yCsicpSy905Smprgs
                .AsNoTracking()
                .Where(smp => submenuIds.Contains(smp.Submenu) && smp.IsActive == true)
                .ToListAsync();

            var programaIds = submenuProgramasAtivos.Select(smp => smp.Programa).Distinct().ToList();

            // 4️⃣ Busca programas em uma query separada
            var programas = await _appDbContext.OsusrI4yCsicpSy904Prgs
                .AsNoTracking()
                .Where(p => programaIds.Contains(p.Id))
                .ToDictionaryAsync(p => p.Id!);

            // 5️⃣ Monta lookup de programas por submenu - O(1)
            var programasPorSubmenu = submenuProgramasAtivos
                .GroupBy(smp => smp.Submenu)
                .ToDictionary(
                    g => g.Key!,
                    g => g.Select(smp => new CsicpSy905Smprg
                    {
                        Id = smp.Id,
                        Submenu = smp.Submenu,
                        Programa = smp.Programa,
                        IsActive = smp.IsActive,
                        Ordem = smp.Ordem,
                        NavPrograma = programas.TryGetValue(smp.Programa!, out var prog) ? prog : null!
                    })
                    .Where(smp => smp.NavPrograma != null)
                    .ToList()
                );

            // 6️⃣ Monta lookup de submenus por menu - O(1)
            var submenusPorMenu = submenusAtivos
                .GroupBy(sm => sm.Menu)
                .ToDictionary(
                    g => g.Key!,
                    g => g.Select(sm =>
                    {
                        // Atribui programas ao submenu
                        sm.ListaSubMenuProgramas = programasPorSubmenu.TryGetValue(sm.Id!, out var progs)
                            ? progs
                            : [];
                        return sm;
                    })
                    .ToList()
                );

            // 7️⃣ Atribui submenus aos menus - SEM loops aninhados
            foreach (var menu in menusAtivos)
            {
                menu.ListaSubmenus = submenusPorMenu.TryGetValue(menu.Id!, out var submenus)
                    ? submenus
                    : [];
            }

            return menusAtivos;
        }

        public async Task<List<Csicp_Sy014>> GetSY014List(string grupoID)
        {
            List<Csicp_Sy014> listaSY014ComMenu = await _appDbContext.OsusrE9aCsicpSy014s.AsNoTracking()
                 .Where(e => e.Sy014Grupoid == grupoID)
                 .Include(e => e.CsicpSy902Menu)
                 .OrderBy(e => e.CsicpSy902Menu.Label)
                 .ToListAsync();

            return listaSY014ComMenu;
        }

        public async Task<Csicp_Sy014?> GetSY014PorId(string grupoID, string menuID)
        {
            Csicp_Sy014? SY014 = await _appDbContext.OsusrE9aCsicpSy014s.AsNoTracking()
                 .Where(e => e.Sy014Grupoid == grupoID)
                 .Where(e => e.Sy902MenuId == menuID)
                 .Include(e => e.CsicpSy902Menu)
                 .FirstOrDefaultAsync();

            return SY014;
        }

        public async Task<List<Csicp_Sy015>> GetSY015List(string grupoID, string SY014GrupoMenuId)
        {
            List<Csicp_Sy015> listaSY015ComSubMenu = [];
            listaSY015ComSubMenu = await _appDbContext.OsusrE9aCsicpSy015s.AsNoTracking()
                    .Include(e => e.NavSY903SubMenu)
                    .Where(e => e.NavSY903SubMenu.Isactive == true)
                    .Where(e => e.NavSY903SubMenu.Menu == SY014GrupoMenuId)
                    .Where(e => e.Sy015Grupoid == grupoID).ToListAsync();

            return listaSY015ComSubMenu;
        }

        public async Task<List<Csicp_Sy009>> GetSY009List(string grupoID, string SY015GrupoSubMenuID)
        {
            List<Csicp_Sy009> listaSY009ComPrograma = [];
            listaSY009ComPrograma = await (from sy009 in _appDbContext.OsusrE9aCsicpSy009s.AsNoTracking()

                                           join sy904PRG in _appDbContext.OsusrI4yCsicpSy904Prgs.AsNoTracking()
                                           on sy009.Sy904ProgramaId equals sy904PRG.Id

                                           join sy905SMPrg in _appDbContext.OsusrI4yCsicpSy905Smprgs.AsNoTracking()
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
            // 1️⃣ Query única com todas as relações necessárias - SEM múltiplas queries
            var sy005Data = await (
                from sy005 in _appDbContext.OsusrE9aCsicpSy005s.AsNoTracking().AsNoTracking()
                where sy005.Sy005Userid == usuarioID

                join sy014 in _appDbContext.OsusrE9aCsicpSy014s.AsNoTracking().AsNoTracking()
                    on sy005.Sy005Grupoid equals sy014.Sy014Grupoid

                join sy902 in _appDbContext.OsusrI4yCsicpSy902Menus.AsNoTracking().AsNoTracking()
                    on sy014.Sy902MenuId equals sy902.Id
                where sy902.Isactive == true

                select new { sy005, sy014, sy902, sy005.Sy005Grupoid })
                .ToListAsync();

            if (sy005Data.Count == 0)
                return [];

            // 2️⃣ Extrai IDs para busca em batch
            var menuIds = sy005Data.Select(x => x.sy902.Id).Distinct().ToList();
            var grupoIds = sy005Data.Select(x => x.Sy005Grupoid).Distinct().ToList();

            // 3️⃣ Busca TODOS os submenus e programas em UMA ÚNICA query com split
            var submenusCompletos = await _appDbContext.OsusrI4yCsicpSy903Smenus.AsNoTracking()
                .AsNoTracking()
                .Where(sm => menuIds.Contains(sm.Menu) && sm.Isactive == true)
                .Select(sm => new
                {
                    Submenu = sm,
                    Programas = sm.ListaSubMenuProgramas
                        .Where(smp => smp.IsActive == true)
                        .Select(smp => smp.NavPrograma)
                        .ToList()
                })
                .AsSplitQuery()
                .ToListAsync();

            // 4️⃣ Cria lookup O(1) de submenus por menuId
            var submenusPorMenuId = submenusCompletos
                .GroupBy(x => x.Submenu.Menu)
                .ToDictionary(
                    g => g.Key!,
                    g => g.Select(x =>
                    {
                        x.Submenu.ListaSubMenuProgramas = x.Programas
                            .Select(p => new CsicpSy905Smprg
                            {
                                NavPrograma = p,
                                IsActive = true
                            })
                            .ToList();
                        return x.Submenu;
                    }).ToList()
                );

            // 5️⃣ Cria lookup O(1) de sy014 por sy005.Id
            var sy014PorSy005Id = sy005Data
                .GroupBy(x => x.sy005.Id)
                .ToDictionary(g => g.Key!, g => g.First());

            // 6️⃣ Monta estrutura final usando LINQ - ZERO loops aninhados
            var resultado = sy005Data
                .GroupBy(x => x.sy005.Id)
                .Select(g =>
                {
                    var sy005 = g.First().sy005;
                    var item = sy014PorSy005Id[sy005.Id!];

                    // Atribui sy014
                    sy005.Sy014GrupoMenu = item.sy014;
                    sy005.Sy014GrupoMenu.CsicpSy902Menu = item.sy902;

                    // Atribui submenus do lookup O(1)
                    if (submenusPorMenuId.TryGetValue(item.sy902.Id!, out var submenus))
                    {
                        sy005.Sy014GrupoMenu.CsicpSy902Menu.ListaSubmenus = submenus;
                    }
                    else
                    {
                        sy005.Sy014GrupoMenu.CsicpSy902Menu.ListaSubmenus = [];
                    }

                    return sy005;
                })
                .ToList();

            return resultado;
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


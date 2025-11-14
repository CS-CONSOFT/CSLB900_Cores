using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSSY103.C82Application.Dto.Menu;
using CSSY103.C82Application.Dto.SY902;
using CSSY103.C82Application.Dto.SY903;
using CSSY103.C82Application.Dto.SY904;

namespace CSSY103.C82Application.Mapper
{
    public static class MenuMapper
    {
        public static CsicpSy902Menu ToEntity(this DtoMontaMenu dtoMonta)
        {
            return new CsicpSy902Menu
            {
                Id = dtoMonta.IdSY902Menu,

            };
        }
        public static DtoSY902 ToDto(this CsicpSy902Menu entity)
        {
            return new DtoSY902
            {
                Id = entity.Id,
                IdSy802 = entity.IdSy802,
                Label = entity.Label,
                Menu = entity.Menu,
                Descricao = entity.Descricao,
                Url = entity.Url,
                Ordem = entity.Ordem,
                Isactive = entity.Isactive,
                NavListSY903_SMenu = entity.ListaSubmenus.Select(e => e.ToDto()).ToList()
            };
        }

        public static DtoSY902_V2 ToDto_v2(this CsicpSy902Menu entity)
        {
            return new DtoSY902_V2
            {
                NavListSY903_SMenu = entity.ListaSubmenus.Select(e => e.ToDto_v2()).ToList()
            };
        }

        public static DtoSY902_V2 ToDtoSemListSubMenu(this CsicpSy902Menu entity)
        {
            return new DtoSY902_V2
            {
               
            };
        }

        public static DtoSY902 ToGetDtoByGroup(this Csicp_Sy014 entity, List<Csicp_Sy015> listaSY015ComSubMenu, List<Csicp_Sy009> listaSY009ComPrograma)
        {
            return entity.CsicpSy902Menu != null ? new DtoSY902
            {
                Id = entity.CsicpSy902Menu.Id,
                IdSy802 = entity.CsicpSy902Menu.IdSy802,
                Label = entity.CsicpSy902Menu.Label,
                Menu = entity.CsicpSy902Menu.Menu,
                Descricao = entity.CsicpSy902Menu.Descricao,
                Url = entity.CsicpSy902Menu.Url,
                Ordem = entity.CsicpSy902Menu.Ordem,

                Isactive = entity.CsicpSy902Menu.Isactive,

                NavListSY903_SMenu = listaSY015ComSubMenu.Select(e => e.ToDto(listaSY009ComPrograma)).ToList()
            } : new DtoSY902();
        }

        public static DtoSY902 ToGetDtoByUsuario(this Csicp_Sy005 entity)
        {
            return entity.Sy014GrupoMenu != null && entity.Sy014GrupoMenu.CsicpSy902Menu != null ? new DtoSY902
            {
                Id = entity.Sy014GrupoMenu.CsicpSy902Menu.Id,
                IdSy802 = entity.Sy014GrupoMenu.CsicpSy902Menu.IdSy802,
                Label = entity.Sy014GrupoMenu.CsicpSy902Menu.Label,
                Menu = entity.Sy014GrupoMenu.CsicpSy902Menu.Menu,
                Descricao = entity.Sy014GrupoMenu.CsicpSy902Menu.Descricao,
                Url = entity.Sy014GrupoMenu.CsicpSy902Menu.Url,
                Ordem = entity.Sy014GrupoMenu.CsicpSy902Menu.Ordem,

                Isactive = entity.Sy014GrupoMenu.CsicpSy902Menu.Isactive,

                NavListSY903_SMenu = entity.Sy014GrupoMenu.CsicpSy902Menu.ListaSubmenus.Select(e => e.ToDto()).ToList()
            } : new DtoSY902();
        }

        public static DtoSY902_V2 ToGetDtoByUsuario_v2(this Csicp_Sy005 entity)
        {
            return entity.Sy014GrupoMenu != null && entity.Sy014GrupoMenu.CsicpSy902Menu != null ? new DtoSY902_V2
            {
                NavListSY903_SMenu = entity.Sy014GrupoMenu.CsicpSy902Menu.ListaSubmenus.Select(e => e.ToDto_v2()).ToList()
            } : new DtoSY902_V2();
        }

        public static DtoSY903 ToDto(this CsicpSy903Smenu entity)
        {
            return new DtoSY903
            {
                Id = entity.Id,
                Label = entity.Label,
                Descricao = entity.Descricao,
                Submenu = entity.Submenu,
                Url = entity.Url,
                Menu = entity.Menu,

                Ordem = entity.Ordem,
                Datacreate = entity.Datacreate,
                Isactive = entity.Isactive,

                NavListSY904Programa = entity.ListaSubMenuProgramas.Select(e => e.ToDto()).ToList()
            };
        }

        public static DtoSY903_V2 ToDto_v2(this CsicpSy903Smenu entity)
        {
            return new DtoSY903_V2
            {
                title = entity.Label ?? "",
                icon = entity.DescricaoSpanish,
                to = entity.Url,
                children = entity.ListaSubMenuProgramas.Select(e => e.ToDto_v2()).ToList()
            };
        }

        public static DtoSY903_V2 ToDto_v2(this CsicpSy903Smenu entity, List<CsicpSy904Prg> listaProgramas)
        {
            return new DtoSY903_V2
            {
                title = entity.Label ?? "",
                icon = entity.DescricaoSpanish,
                to = entity.Url,  
                children = listaProgramas.Select(e => e.ToDto_v2()).ToList()
            };
        }


        public static DtoSY903 ToDto(this CsicpSy903Smenu entity, List<CsicpSy904Prg> listaProgramas)
        {
            return new DtoSY903
            {
                Id = entity.Id,
                Label = entity.Label,
                Descricao = entity.Descricao,
                Submenu = entity.Submenu,
                Url = entity.Url,
                Menu = entity.Menu,

                Ordem = entity.Ordem,
                Datacreate = entity.Datacreate,
                Isactive = entity.Isactive,

                NavListSY904Programa = listaProgramas.Select(e => e.ToDto()).ToList()
            };
        }

        public static DtoSY903 ToDto(this Csicp_Sy015 entity, List<Csicp_Sy009> listaSY009ComPrograma)
        {
            return new DtoSY903
            {
                Id = entity.NavSY903SubMenu.Id,
                Label = entity.NavSY903SubMenu.Label,
                Descricao = entity.NavSY903SubMenu.Descricao,
                Submenu = entity.NavSY903SubMenu.Submenu,
                Url = entity.NavSY903SubMenu.Url,
                Menu = entity.NavSY903SubMenu.Menu,
                Ordem = entity.NavSY903SubMenu.Ordem,
                Datacreate = entity.NavSY903SubMenu.Datacreate,
                Isactive = entity.NavSY903SubMenu.Isactive,
                NavListSY904Programa = listaSY009ComPrograma.Select(e => e.ToDto()).ToList()
            };
        }

        public static DtoSY904 ToDto(this CsicpSy905Smprg entity)
        {
            return new DtoSY904
            {
                Id = entity.NavPrograma?.Id,
                //IdSY905 = entity.Id,
                Label = entity.NavPrograma?.Label,
                Programa = entity.NavPrograma?.Programa,
                Ordem = entity.NavPrograma?.Ordem,
                Url = entity.NavPrograma?.Url,
                Descricao = entity.NavPrograma?.Descricao,
                IsActive = entity.NavPrograma?.IsActive,

            };
        }

        public static DtoSY904_V2 ToDto_v2(this CsicpSy905Smprg entity)
        {
            return new DtoSY904_V2
            {
                title = entity.NavPrograma?.Label,
                icon = "",
                to = entity.NavPrograma?.Url,
            };
        }


        public static DtoSY904 ToDto(this CsicpSy904Prg entity)
        {
            return new DtoSY904
            {
                Id = entity.Id,
                //IdSY905 = entity.Id,
                Label = entity.Label,
                Programa = entity.Programa,
                Ordem = entity.Ordem,
                Url = entity.Url,
                Descricao = entity.Descricao,
                IsActive = entity.IsActive,

            };
        }

        public static DtoSY904_V2 ToDto_v2(this CsicpSy904Prg entity)
        {
            return new DtoSY904_V2
            {
                title = entity.Label,
                icon = "",
                to = entity.Url,

            };
        }

        public static DtoSY904 ToDto(this Csicp_Sy009 entity)
        {
            return new DtoSY904
            {
                Id = entity.NavSY904Prg.Id,
                //IdSY905 = entity.NavSY904Prg.NavSY905SMprg.Id,
                Label = entity.NavSY904Prg.Label,
                Programa = entity.NavSY904Prg.Programa,
                Ordem = entity.NavSY904Prg.Ordem,
                Url = entity.NavSY904Prg.Url,
                Descricao = entity.NavSY904Prg.Descricao,
                IsActive = entity.NavSY904Prg.IsActive,

            };
        }
    }
}

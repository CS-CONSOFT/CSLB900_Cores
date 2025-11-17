using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.Menu
{
    public interface IMenuRepository
    {
        public Task<List<CsicpSy902Menu>> GetMenuList(string ProdutoLabel);

        public Task<List<Csicp_Sy005>> GetMenuListPorUsuario(string usuarioID);


        public Task<List<Csicp_Sy014>> GetSY014List(string grupoID);
        public Task<List<Csicp_Sy015>> GetSY015List(string grupoID, string SY014GrupoMenuID);
        public Task<List<Csicp_Sy009>> GetSY009List(string grupoID, string SY015GrupoSubMenuID);

        public Task<bool> DesmontaMenu(string currentMenuID,
            string currentSubMenuID, List<string> listaProgramasID, string grupoID, int Tenant_ID);

        public Task<bool> MontaMenu(string currentMenuID,
           string currentSubMenuID, List<string> listaProgramasID, string grupoID, int Tenant_ID);

    }
}

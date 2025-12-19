using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY;



public interface ISY001Repository : IBaseCrud<Csicp_Sy001>
{
    Task<Csicp_Sy001?> GetByIdAsync(string id, int tenant);

    Task<IEnumerable<Csicp_Sy001>> GetListAsync(int tenant, string? search);

    Task<List<Csicp_Sy001Img>> GetAvatares(string id, int tenant);
    Task<List<Csicp_Sy005>> GetGruposUsuarioList(string id, int tenant);
    Task<List<Csicp_Sy006>> GetRegrasUsuarioList(string id, int tenant);
    Task<List<Csicp_Sy021>> GetChavesAcessoUsuarioList(string id, int tenant);
    Task<List<Csicp_Sy013>> GetEstabsUsuarioList(string id, int tenant);
    Task<Csicp_Sy001> AlterarSenha(Csicp_Sy001 csicp_Sy001);
    Task<int> AtualizaSenhasDesseTenant(int tenant);
    Task<UsuarioPosLoginResponse> GetDadosPosLogin(string Dominio, string InUsuarioID);

}

public class UsuarioPosLoginResponse
{
    public bool IsOk { get; set; }
    public string Msg { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty;
    public UsuarioPosLoginModel? Model { get; set; }
    public List<EstabelecimentoUsuarioModel> Lista_Estabs_Usuario { get; set; } = new();
}
public class UsuarioPosLoginModel
{
    public int TenantId { get; set; }
    public string UsuarioId { get; set; } = string.Empty;
    public string NomeUsuario { get; set; } = string.Empty;
    public string Avatar_Path_Img { get; set; } = string.Empty;
    public string Estab_Img { get; set; } = string.Empty;
    public string Estab_Path_Img { get; set; } = string.Empty;
    public string EstabelecimentoId { get; set; } = string.Empty;
    public string NomeEstabelecimento { get; set; } = string.Empty;
    public int UserID { get; set; }
}

public class EstabelecimentoUsuarioModel
{
    public string EstabelecimentoId { get; set; } = string.Empty;
    public string CodigoEstab { get; set; } = string.Empty;
    public string NomeEstabelecimento { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
}








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

}


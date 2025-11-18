using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Application.Dto.Dtos;

namespace CSCore.Domain.Interfaces.RR._00X.IRR022
{
    public interface IRR022Repository : IRepositorioBaseV2<OsusrTo3CsicpRr022>
    {
        Task<OsusrTo3CsicpRr022?> GetByIdAsync(int In_TenantID, string In_IDRR022);
        Task<(List<OsusrTo3CsicpRr022>, int)> GetListPesoAnimalRR022Async(int In_TenantID, string In_UsuarioId, PrmFiltrosRR022 prm);
        Task<List<DtoGetCountPesoAnimalRR022>> GetListCountPesoAnimalAsync(int In_TenantID, string In_UsuarioId, string In_LoteId);
        Task<bool> ExisteRegistroPesoAsync(int In_TenantID, string In_LoteId, string In_AnimalId, DateTime In_DataPeso);


    }
}
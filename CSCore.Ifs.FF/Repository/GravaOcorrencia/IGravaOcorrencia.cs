using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Ifs.FF.Repository.GravaOcorrencia
{
    public interface IGravaOcorrencia
    {
        Task GravaOcorrenciaPrms(CSICP_FF116 entidade);
    }
}
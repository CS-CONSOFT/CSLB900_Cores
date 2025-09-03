using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.GravaOcorrencia
{
    public class GravaOcorrencia : IGravaOcorrencia
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IGenerateProtocolo _generateProtocolo;


        public GravaOcorrencia(AppDbContext appDbContext, ICS_GenerateId generateId, IGenerateProtocolo generateProtocolo)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _generateProtocolo = generateProtocolo;
        }

        public async Task GravaOcorrenciaPrms(CSICP_FF116 entidade)
        {
            _appDbContext.Add(entidade);
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;

namespace CSCore.Ifs.FF.Repository.GravaOcorrencia
{
    public class GravaOcorrencia : IGravaOcorrencia
    {
        private readonly AppDbContext _appDbContext;


        public GravaOcorrencia(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task GravaOcorrenciaPrms(CSICP_FF116 entidade)
        {
            _appDbContext.Add(entidade);
        }
    }
}
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.Eventos.Repository
{
    public class GerarTreeImpl(AppDbContext appDbContext, ICS_GenerateId cS_GenerateId) : IGerarTree
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly ICS_GenerateId _cS_GenerateId = cS_GenerateId;
        public async Task<string?> CriarDocTree(
             int tenant,
             string docID_dd040,
             string docProtocolo,
        int docTIpo_nat28ID,
             string? docParentID)
        {
            var id = _cS_GenerateId.GenerateUuId();
            CSICP_GG028Tree novoDocTree = new CSICP_GG028Tree
            {
                Gg028TreeId = id,
                TenantId = tenant,
                Gg028DoctoId = docID_dd040,
                Gg028DoctoProtocolnumber = docProtocolo,
                Gg028DoctoTipo = docTIpo_nat28ID,
                Gg028DoctoParentId = docParentID,
                Gg028Datahora = DateTime.Now,
                //Gg028DoctoTipoNavigation = null
            };

            _appDbContext.Add(novoDocTree);
            await _appDbContext.SaveChangesAsync();
            return id;
        }
    }
}

using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._01X
{
    public class GG100RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG100>(appDbContext),
        IGG100Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG100?> GetByIdAsync(long id, int tenant)
        {
            IQueryable<CSICP_GG100> query = CriaQueryBaseGG100(tenant);

            return await query.AsNoTracking()
                 .Where(e => e.Gg100Id == id)
                 .AsSplitQuery()
                 .FirstOrDefaultAsync();
        }


        public async Task<(IEnumerable<CSICP_GG100>, int)> GetListAsync(int tenant, int pageSize, int page)
        {
            IQueryable<CSICP_GG100> query = CriaQueryBaseGG100(tenant);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);
            query = query.AsNoTracking().AsSplitQuery();

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG100> CriaQueryBaseGG100(int tenant)
        {
            return from _gg100 in _appDbContext.OsusrE9aCsicpGg100s
                   where _gg100.TenantId == tenant

                   join _gg002 in _appDbContext.OsusrE9aCsicpGg002s
                   on _gg100.Gg100Pdtipoprodutoid equals _gg002.Id

                   join _gg002Sped in _appDbContext.OsusrNnxSpedInTipoItems
                   on _gg002.Gg002TipoprodId equals _gg002Sped.Id

                   join _gg001_venda in _appDbContext.CSICP_GG001s
                   on _gg100.Gg100PdvendaAlmoxid equals _gg001_venda.Id

                   join _gg001_trans in _appDbContext.CSICP_GG001s
                   on _gg100.Gg100Pdtransfalmoxid2 equals _gg001_trans.Id

                   select new CSICP_GG100
                   {
                       TenantId = _gg100.TenantId,
                       Gg100Id = _gg100.Gg100Id,
                       Gg100Estabid = _gg100.Gg100Estabid,
                       Gg100PdvendaAlmoxid = _gg100.Gg100PdvendaAlmoxid,
                       Gg100Pdtransfalmoxid2 = _gg100.Gg100Pdtransfalmoxid2,
                       Gg100Pdtipoprodutoid = _gg100.Gg100Pdtipoprodutoid,
                       Gg100Iscopia = _gg100.Gg100Iscopia,
                       Gg100AwsBucket = _gg100.Gg100AwsBucket,
                       Gg100Awsregion = _gg100.Gg100Awsregion,
                       Gg100Awsaccesskeyid = _gg100.Gg100Awsaccesskeyid,
                       Gg100Awssecretaccesskey = _gg100.Gg100Awssecretaccesskey,
                       Gg100Pdtipoproduto = new CSICP_GG002
                       {
                           Id = _gg002.Id,
                           Gg002Filial = _gg002.Gg002Filial,
                           Gg002Filialid = _gg002.Gg002Filialid,
                           Gg002Desctipoproduto = _gg002.Gg002Desctipoproduto,
                           Gg002PermiteVendas = _gg002.Gg002PermiteVendas,
                           Gg002PermiteCompras = _gg002.Gg002PermiteCompras,
                           Gg002Isactive = _gg002.Gg002Isactive,
                           Gg002TipoprodId = _gg002.Gg002TipoprodId,
                           NavSpedTipoItem = _gg002Sped
                       },
                       Gg100PdvendaAlmox = new CSICP_GG001
                       {
                           Id = _gg001_venda.Id,
                           Gg001Filial = _gg001_venda.Gg001Filial,
                           Gg001Filialid = _gg001_venda.Gg001Filialid,
                           Gg001Codigoalmox = _gg001_venda.Gg001Codigoalmox,
                           Gg001Descalmox = _gg001_venda.Gg001Descalmox,
                       },
                       Gg100Pdtransfalmoxid2Navigation = new CSICP_GG001
                       {
                           Id = _gg001_trans.Id,
                           Gg001Filial = _gg001_trans.Gg001Filial,
                           Gg001Filialid = _gg001_trans.Gg001Filialid,
                           Gg001Codigoalmox = _gg001_trans.Gg001Codigoalmox,
                           Gg001Descalmox = _gg001_trans.Gg001Descalmox,
                       }
                   };
        }

    }
}

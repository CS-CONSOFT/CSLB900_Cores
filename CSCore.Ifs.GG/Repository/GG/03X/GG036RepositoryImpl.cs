using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._03X
{
    public class GG036RepositoryImpl(AppDbContext appDbContext) : RepositorioBaseImpl<CSICP_GG036>(appDbContext), IGG036Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<(IEnumerable<CSICP_GG036>, int)> GetListAsync
            (int tenant,
            string IDEstabelecimento,
            string IDProduto,
            string IDGrupo,
            DateTime? data,
            int pageSize, int page)
        {
            IQueryable<CSICP_GG036> query = RecuperaGG036ComOsRespectivosFiltrosERetornaQuery(tenant, IDEstabelecimento, IDProduto, IDGrupo);

            var queryCount = query;
            int count = queryCount.Count();

          
            query = query.PaginacaoNoBanco(page, pageSize);
            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG036> RecuperaGG036ComOsRespectivosFiltrosERetornaQuery(
            int tenant, string IDEstabelecimento, string IDProduto, string IDGrupo)
        {
            return from gg016 in _appDbContext.OsusrE9aCsicpGg036s

                   join gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                   on gg016.Gg036KardexId equals gg008Kdx.Gg008Kardexid

                   join gg008 in _appDbContext.OsusrE9aCsicpGg008s
                   on gg008Kdx.Gg008Produtoid equals gg008.Id

                   join gg003 in _appDbContext.OsusrE9aCsicpGg003s
                   on gg008.Gg008Grupoid equals gg003.Id

                   where gg016.TenantId == tenant
                   where gg016.Gg036Filialid == IDEstabelecimento
                   where gg008Kdx.Gg008Produtoid == IDProduto
                   where gg008.Gg008Grupoid == IDGrupo

                   select new CSICP_GG036
                   {
                       TenantId = gg016.TenantId,
                       Id = gg016.Id,
                       Gg036Filialid = gg016.Gg036Filialid,
                       Gg036Ordem = gg016.Gg036Ordem,
                       Gg036KardexId = gg016.Gg036KardexId,
                       Gg036Codigobarras = gg016.Gg036Codigobarras,
                       Gg036Dataregistro = gg016.Gg036Dataregistro,
                       Gg036Saldoid = gg016.Gg036Saldoid,
                       Gg036QtdEstoque = gg016.Gg036QtdEstoque,
                       Gg036Saldoestoque = gg016.Gg036Saldoestoque,
                       Gg036Precocusto = gg016.Gg036Precocusto,
                       Gg036Precocustoreal = gg016.Gg036Precocustoreal,
                       Gg036Precocustomedio = gg016.Gg036Precocustomedio,
                       Gg036Precovenda = gg016.Gg036Precovenda,
                       Gg036Naoinventariar = gg016.Gg036Naoinventariar,
                       Gg036Inventariado = gg016.Gg036Inventariado,
                       Gg036Mensagem = gg016.Gg036Mensagem,
                       Gg036Codbarrasalfa = gg016.Gg036Codbarrasalfa
                   };
        }
    }
}

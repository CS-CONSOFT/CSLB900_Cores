using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.Consumidor;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CSCore.Ifs.Repository.Consumidor
{
    internal class ProdutoObjComparer : IEqualityComparer<CSICP_GG008c>
    {
        public bool Equals(CSICP_GG008c? x, CSICP_GG008c? y)
        {
            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.Gg008cProdutoid == y.Gg008cProdutoid;
        }

        public int GetHashCode([DisallowNull] CSICP_GG008c obj)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(obj, null)) return 0;

            //Get hash code for the Code field.
            int hashProductCode = obj.Gg008cProdutoid.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductCode;
        }
    }
    public class MinhasComprasRepositoryImpl(AppDbContext appDbContext) : IMinhasComprasRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<(List<CSICP_DD040>, List<CSICP_DD060>, List<CSICP_GG008c>)> Get_MinhasCompras(string bb012_contaID, int tenant_id)
        {
            IQueryable<CSICP_DD040Sit> querySituacaoDD040Sit = from _dd040Sit in _appDbContext.OsusrTeiCsicpDd040Sits
                                                               where _dd040Sit.Label!.Equals("Faturada")
                                                               select _dd040Sit;
            CSICP_DD040Sit? situacaoFaturadaDD040 = await querySituacaoDD040Sit.FirstOrDefaultAsync();


            var listaConteudo = new List<int?> { 1, 8 };
            //Filtrando os tipos de notas que serão exibidos de venda.
            IQueryable<CSICP_DD040Tnt> queryDd040Tnt = from _dd040Tnt in _appDbContext.OsusrTeiCsicpDd040Tnts
                                                       where listaConteudo.Contains(_dd040Tnt.CsCodg)
                                                       select _dd040Tnt;

            List<CSICP_DD040Tnt> listaDD040Tnt = await queryDd040Tnt.ToListAsync();


            IQueryable<CSICP_DD040> queryListaDD040 = from _dd040 in _appDbContext.OsusrTeiCsicpDd040s

                                                      join _dd040Tnt in _appDbContext.OsusrTeiCsicpDd040Tnts
                                                      on _dd040.Dd040TiponotaId equals _dd040Tnt.Id

                                                      where _dd040.TenantId == tenant_id
                                                      where _dd040.Dd040ContaId == bb012_contaID
                                                      where _dd040.Dd040Situacao == situacaoFaturadaDD040!.Id

                                                      where _dd040.Dd040DataEmissao <= DateTime.UtcNow
                                                      && _dd040.Dd040DataEmissao >= DateTime.UtcNow.AddYears(-5)

                                                      where listaDD040Tnt.Select(curr => curr.Id).Contains(_dd040.Dd040TiponotaId)

                                                      orderby _dd040.Dd040DataEmissao descending, _dd040.Dd040NoNf descending

                                                      select _dd040;


            List<CSICP_DD040> listaDD040 = await queryListaDD040.ToListAsync();


            IQueryable<CSICP_DD060> queryListaDD060 = from _dd060 in _appDbContext.OsusrTeiCsicpDd060s
                                                      where _dd060.TenantId == tenant_id
                                                      where listaDD040.Select(currDD40 => currDD40.Dd040Id).Contains(_dd060.Dd040Id)

                                                      join _gg007 in _appDbContext.OsusrE9aCsicpGg007s
                                                      on _dd060.Dd060UnId equals _gg007.Id

                                                      join _gg008 in _appDbContext.OsusrE9aCsicpGg008s
                                                      on _dd060.Dd060Produtoid equals _gg008.Id

                                                      orderby _dd060.Dd040Id descending, _dd060.Dd060Sequencia descending

                                                      select new CSICP_DD060
                                                      {
                                                          TenantId = _dd060.TenantId,
                                                          Dd060Id = _dd060.Dd060Id,
                                                          Dd040Id = _dd060.Dd040Id,
                                                          Dd060Produtoid = _dd060.Dd060Produtoid,
                                                          Dd060Saldoid = _dd060.Dd060Saldoid,
                                                          Dd060CodigoProduto = _dd060.Dd060CodigoProduto,
                                                          Dd060Quantidade = _dd060.Dd060Quantidade,
                                                          Dd060TotalLiquido = _dd060.Dd060TotalLiquido,
                                                          NavGG008Produto = new CSICP_GG008
                                                          {
                                                              Id = _gg008.Id,
                                                              Gg008Filialid = _gg008.Gg008Filialid,
                                                              Gg008Filial = _gg008.Gg008Filial,
                                                              Gg008Codgproduto = _gg008.Gg008Codgproduto,
                                                              Gg008Descreduzida = _gg008.Gg008Descreduzida
                                                          },
                                                          NavGG007Unidade = new CSICP_GG007
                                                          {
                                                              Id = _gg007.Id,
                                                              Gg007Unidade = _gg007.Gg007Unidade
                                                          }
                                                      };

            List<CSICP_DD060> listaDD060 = await queryListaDD060.ToListAsync();




            IQueryable<CSICP_GG008c> queryGG008c = from _gg008c in _appDbContext.OsusrE9aCsicpGg008cs
                                                   where _gg008c.TenantId == tenant_id
                                                   where _gg008c.Gg008cTiporegistro == "3"
                                                   where _gg008c.Gg008cIspadrao == true

                                                   where listaDD060.Select(x => x.Dd060Produtoid).Contains(_gg008c.Gg008cProdutoid)
                                                   select new CSICP_GG008c
                                                   {
                                                       TenantId = _gg008c.TenantId,
                                                       Id = _gg008c.Id,
                                                       Gg008cProdutoid = _gg008c.Gg008cProdutoid,
                                                       Gg008cPath = _gg008c.Gg008cPath,
                                                   };

            //queryGG008c = queryGG008c.Distinct(new ProdutoObjComparer());

            List<CSICP_GG008c> listaGG008c = await queryGG008c.ToListAsync();

            return (listaDD040, listaDD060, listaGG008c);

        }



        public async Task Get_MinhasEntregas(string bb012_contaID)
        {

        }

    }
}


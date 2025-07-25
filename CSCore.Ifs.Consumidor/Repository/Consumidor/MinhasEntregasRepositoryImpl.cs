using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.Consumidor;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Consumidor.Repository.Consumidor
{
    public class MinhasEntregasRepositoryImpl(AppDbContext appDbContext) : IMinhasEntregasRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<List<CSICP_DD101>> GetList_MinhasEntregas(
            string bb012_contaID,
            int tenant_id,
            int page,
            int pageSize)
        {
            IQueryable<CSICP_DD101> queryListaDD101 = from _dd101 in _appDbContext.OsusrTeiCsicpDd101s

                                                      join _dd102 in _appDbContext.OsusrTeiCsicpDd102s
                                                      on _dd101.Dd101EntregaId equals _dd102.Dd102CargaId into leftJoinDD102
                                                      from _dd102 in leftJoinDD102.DefaultIfEmpty()

                                                      join _dd110 in _appDbContext.OsusrTeiCsicpDd110s
                                                      on _dd102.Dd102CargaId equals _dd110.Dd110CargaId into leftJoinDD110
                                                      from _dd110 in leftJoinDD110.DefaultIfEmpty()

                                                      join _dd060 in _appDbContext.OsusrTeiCsicpDd060s
                                                      on _dd101.Dd101VendaId equals _dd060.Dd060Id into leftJoinDD060
                                                      from _dd060 in leftJoinDD060.DefaultIfEmpty()

                                                      join _dd040 in _appDbContext.OsusrTeiCsicpDd040s
                                                      on _dd060.Dd040Id equals _dd040.Dd040Id into leftJoinDD40
                                                      from _dd040 in leftJoinDD40.DefaultIfEmpty()

                                                      join _gg008 in _appDbContext.OsusrE9aCsicpGg008s
                                                      on _dd060.Dd060Produtoid equals _gg008.Id into leftJoinDD008
                                                      from _gg008 in leftJoinDD008.DefaultIfEmpty()

                                                      join _gg007 in _appDbContext.OsusrE9aCsicpGg007s
                                                      on _dd060.Dd060UnId equals _gg007.Id into leftJoinDD007
                                                      from _gg007 in leftJoinDD007.DefaultIfEmpty()

                                                      join _dd110status in _appDbContext.OsusrTeiCsicpDd110Statuses
                                                      on _dd110.Dd110StatusId equals _dd110status.Id into leftJoinDD110st
                                                      from _dd110status in leftJoinDD110st.DefaultIfEmpty()

                                                      join _dd110mod in _appDbContext.OsusrTeiCsicpDd110Mods
                                                      on _dd110.Dd110Modentregaid equals _dd110mod.Id into leftJoinDD110mod
                                                      from _dd110mod in leftJoinDD110mod.DefaultIfEmpty()

                                                      where _dd101.TenantId == tenant_id
                                                      where _dd101.Dd101ContaId == bb012_contaID

                                                      orderby _dd101.Dd101Protocolnumber descending

                                                      select new CSICP_DD101
                                                      {
                                                          Dd101Protocolnumber = _dd101.Dd101Protocolnumber,
                                                          Dd101QtdVenda = _dd101.Dd101QtdVenda,
                                                          NavDD060_ProdutosNF = new CSICP_DD060
                                                          {
                                                              NavGG008Produto = new CSICP_GG008
                                                              {
                                                                  Gg008Codgproduto = _gg008.Gg008Codgproduto,
                                                                  Gg008Descreduzida = _gg008.Gg008Descreduzida
                                                              },
                                                              NavGG007Unidade = new CSICP_GG007
                                                              {
                                                                  Gg007Unidade = _gg007.Gg007Unidade
                                                              },
                                                              NavDD040NF = new CSICP_DD040
                                                              {
                                                                  Dd040Serie = _dd040.Dd040Serie,
                                                                  Dd040NoNf = _dd040.Dd040NoNf,
                                                                  Dd040DataEmissao = _dd040.Dd040DataEmissao
                                                              }
                                                          },
                                                          NavDD102Entrega = new CSICP_DD102
                                                          {
                                                              Dd102DataEntrega = _dd102.Dd102DataEntrega,
                                                              NavDD110Carga = new CSICP_DD110
                                                              {
                                                                  NavDD110Status = new CSICP_DD110Status
                                                                  {
                                                                      Label = _dd110status.Label
                                                                  }
                                                              }
                                                          },
                                                      };


            queryListaDD101 = queryListaDD101.PaginacaoNoBanco(page, pageSize);
            List<CSICP_DD101> listaDD101 = await queryListaDD101.ToListAsync();

            return listaDD101;

        }

    }

}
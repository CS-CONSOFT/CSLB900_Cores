using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._07X
{
    public class GG072RepositoryImpl(AppDbContext appDbContext) : RepositorioBaseImpl<CSICP_GG072>(appDbContext, "Gg072Id"), IGG072Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG072?> GetByIdAsync(int tenant, long id)
        {
            IQueryable<CSICP_GG072> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg072Id == id);

            CSICP_GG072? csicpGg030Entity = await query.FirstOrDefaultAsync();

            return csicpGg030Entity;
        }


        public async Task<(IEnumerable<CSICP_GG072>, int)> GetListAsync(int tenant, long? InGG071_ID, int pageSize, int page)
        {
            IQueryable<CSICP_GG072> query = CriaQueryBase(tenant);



            if(InGG071_ID != null)
                query = query.Where(e => e.Gg071Id == InGG071_ID);  

            int count = query.GetCountTotal();
            query = query.PaginacaoNoBanco(page, pageSize);
            List<CSICP_GG072> listaCSICP_GG072 = await query.ToListAsync();
            return (listaCSICP_GG072, count);
        }

        private IQueryable<CSICP_GG072> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG072> query = from _CSICP_GG072 in _appDbContext.OsusrE9aCsicpGg072s
                                            where _CSICP_GG072.TenantId == tenant

                                            join gg071 in _appDbContext.OsusrE9aCsicpGg071s
                                            on _CSICP_GG072.Gg071Id equals gg071.Gg071Id into gg071_join
                                            from gg071 in gg071_join.DefaultIfEmpty()

                                            join gg520SaldoOrigem in _appDbContext.OsusrE9aCsicpGg520s
                                            on _CSICP_GG072.Gg072Entradasaldoid equals gg520SaldoOrigem.Id into gg520SaldoOrigem_join
                                            from gg520SaldoOrigem in gg520SaldoOrigem_join.DefaultIfEmpty()

                                            join gg520SaldoSaida in _appDbContext.OsusrE9aCsicpGg520s
                                            on _CSICP_GG072.Gg072Saidasaldoid equals gg520SaldoSaida.Id into gg520SaldoSaida_join
                                            from gg520SaldoSaida in gg520SaldoSaida_join.DefaultIfEmpty()

                                            join gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                            on _CSICP_GG072.Gg072KardexId equals gg008Kdx.Gg008Kardexid into gg008Kdx_join
                                            from gg008Kdx in gg008Kdx_join.DefaultIfEmpty()

                                            join gg008 in _appDbContext.OsusrE9aCsicpGg008s
                                            on gg008Kdx.Gg008Produtoid equals gg008.Id into gg008_join
                                            from gg008 in gg008_join.DefaultIfEmpty()

                                            join gg072stq in _appDbContext.OsusrE9aCsicpGg072Stqs
                                            on _CSICP_GG072.Gg072Statusestqid equals gg072stq.Id into gg072stq_join
                                            from gg072stq in gg072stq_join.DefaultIfEmpty()

                                            select new CSICP_GG072
                                            {
                                                TenantId = _CSICP_GG072.TenantId,
                                                Gg072Id = _CSICP_GG072.Gg072Id,
                                                Gg071Id = _CSICP_GG072.Gg071Id,
                                                Gg072Codbarrasalfa = _CSICP_GG072.Gg072Codbarrasalfa,
                                                Gg072KardexId = _CSICP_GG072.Gg072KardexId,
                                                Gg072Saidasaldoid = _CSICP_GG072.Gg072Saidasaldoid,
                                                Gg072UnId = _CSICP_GG072.Gg072UnId,
                                                Gg072Quantidade = _CSICP_GG072.Gg072Quantidade,
                                                Gg072ValorUnitario = _CSICP_GG072.Gg072ValorUnitario,
                                                Gg072QtdAnterior = _CSICP_GG072.Gg072QtdAnterior,
                                                Gg072Entradasaldoid = _CSICP_GG072.Gg072Entradasaldoid,
                                                Gg072UnSecId = _CSICP_GG072.Gg072UnSecId,
                                                Gg072UnSecTipoconvId = _CSICP_GG072.Gg072UnSecTipoconvId,
                                                Gg072UnSecFatorconv = _CSICP_GG072.Gg072UnSecFatorconv,
                                                Gg072UnSecQtde = _CSICP_GG072.Gg072UnSecQtde,
                                                Gg072Statusestqid = _CSICP_GG072.Gg072Statusestqid,
                                                Dd080Id = _CSICP_GG072.Dd080Id,
                                                Gg072Qtdsolicitada = _CSICP_GG072.Gg072Qtdsolicitada,
                                                Gg071 = gg071,
                                                Gg072Entradasaldo = gg520SaldoOrigem,
                                                NavGG520Saidasaldo = gg520SaldoSaida,
                                                GG008ProdutoDescricao = gg008.Gg008Descreduzida,
                                                NavCSICP_GG072Stq = gg072stq
                                            };
            return query;
        }


    }
}



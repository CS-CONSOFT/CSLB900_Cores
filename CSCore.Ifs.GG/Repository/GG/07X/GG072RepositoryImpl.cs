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
    public class GG072RepositoryImpl(AppDbContext appDbContext) : RepositorioBaseImpl<CSICP_GG072>(appDbContext), IGG072Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG072?> GetByIdAsync(int tenant, long id)
        {
            IQueryable<CSICP_GG072> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg072Id == id);

            CSICP_GG072? csicpGg030Entity = await query.FirstOrDefaultAsync();

            return csicpGg030Entity;
        }


        public async Task<(IEnumerable<CSICP_GG072>, int)> GetListAsync(int tenant, int pageSize, int page)
        {
            IQueryable<CSICP_GG072> query = CriaQueryBase(tenant);


            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG072> listaCSICP_GG072 = await query.ToListAsync();
            return (listaCSICP_GG072, count);
        }

        private IQueryable<CSICP_GG072> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG072> query = from _CSICP_GG072 in _appDbContext.OsusrE9aCsicpGg072s
                                            where _CSICP_GG072.TenantId == tenant
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
                                            };
            return query;
        }


    }
}



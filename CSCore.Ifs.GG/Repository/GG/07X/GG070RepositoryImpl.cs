using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._07X
{
    public class GG070RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_GG070>(appDbContext), IGG070Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG070?> GetByIdAsync(int tenant, long id)
        {
            IQueryable<CSICP_GG070> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg070Id == id);

            CSICP_GG070? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }

        public async Task<(IEnumerable<CSICP_GG070>, int)> GetListAsync
            (int tenant, int pageSize, int page, DateTime DataInicio, DateTime DataFinal)
        {
            IQueryable<CSICP_GG070> query = CriaQueryBase(tenant);

            query = FiltrosNecessariosEntidade(query, DataInicio, DataFinal);
            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG070> listaCSICP_GG070 = await query.ToListAsync();
            return (listaCSICP_GG070, count);
        }

        private IQueryable<CSICP_GG070> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG070> query = from _CSICP_GG070 in _appDbContext.OsusrE9aCsicpGg070s
                                            where _CSICP_GG070.TenantId == tenant
                                            select new CSICP_GG070
                                            {
                                                TenantId = _CSICP_GG070.TenantId,
                                                Gg070Id = _CSICP_GG070.Gg070Id,
                                                Gg070EstabId = _CSICP_GG070.Gg070EstabId,
                                                Gg070Produtoid = _CSICP_GG070.Gg070Produtoid,
                                                Gg070Motivoid = _CSICP_GG070.Gg070Motivoid,
                                                Gg070Grupoid = _CSICP_GG070.Gg070Grupoid,
                                                Gg070Subgrupoid = _CSICP_GG070.Gg070Subgrupoid,
                                                Gg070Classeid = _CSICP_GG070.Gg070Classeid,
                                                Gg070Marcaid = _CSICP_GG070.Gg070Marcaid,
                                                Gg070Artigoid = _CSICP_GG070.Gg070Artigoid,
                                                Gg070Peso = _CSICP_GG070.Gg070Peso,
                                                Gg070Usuariopropid = _CSICP_GG070.Gg070Usuariopropid,
                                                Gg070Nomecliente = _CSICP_GG070.Gg070Nomecliente,
                                                Gg070Qtdregistrada = _CSICP_GG070.Gg070Qtdregistrada,
                                                Gg070Unvendavarejoid = _CSICP_GG070.Gg070Unvendavarejoid,
                                                Gg070Pvenda = _CSICP_GG070.Gg070Pvenda,
                                                Gg070Pcusto = _CSICP_GG070.Gg070Pcusto,
                                                Gg070Pcreal = _CSICP_GG070.Gg070Pcreal,
                                                Gg070Dregistro = _CSICP_GG070.Gg070Dregistro,
                                                Gg070Saldoprod = _CSICP_GG070.Gg070Saldoprod,
                                                Gg070Descproduto = _CSICP_GG070.Gg070Descproduto,
                                            };
            return query;
        }

        private static IQueryable<CSICP_GG070> FiltrosNecessariosEntidade(IQueryable<CSICP_GG070> query, DateTime DataInicio, DateTime DataFinal)
        {
            query = query.Where(e => e.Gg070Dregistro >= DataInicio && e.Gg070Dregistro <= DataFinal);


            return query;
        }
    }
}

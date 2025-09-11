using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF132RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF132>(appDbContext, "Ff132Id"), IFF132Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<CSICP_FF132>, int)> GetListAsync
            (int in_tenant, long in_ff131Id, int in_pageNumber, int in_pageSize)
        {
            IQueryable<CSICP_FF132> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff131Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF132> FiltraQuandoExisteFiltro
            (long? in_ff131Id, IQueryable<CSICP_FF132> query)
        {
            if (in_ff131Id != null)
                query = query.Where(e => e.Ff131Id == in_ff131Id);

            // Filtra apenas registros onde FF131_ISEFETIVADO é false
            query = query.Where(e => e.NavFF131.Ff131Isefetivado == false);

            return query;
        }

        private IQueryable<CSICP_FF132> GetQueryBase(int in_tenant)
        {
            return from ff132 in _appDbContext.OsusrE9aCsicpFf132s
                   .AsNoTracking()

                   join ff131 in _appDbContext.OsusrE9aCsicpFf131s
                   on ff132.Ff131Id equals ff131.Ff131Id into ff131_ff132_join
                   from ff131 in ff131_ff132_join.DefaultIfEmpty()

                   join ff102 in _appDbContext.OsusrE9aCsicpFf102s
                   on ff132.Ff102Id equals ff102.Id into ff102_ff132_join
                   from ff102 in ff102_ff132_join.DefaultIfEmpty()

                   where ff132.TenantId == in_tenant

                   select new CSICP_FF132
                   {
                       TenantId = ff132.TenantId,
                       Ff132Id = ff132.Ff132Id,
                       Ff131Id = ff132.Ff131Id,
                       Ff102Id = ff132.Ff102Id,

                       NavFF131 = ff131 != null ? new CSICP_FF131
                       {
                           TenantId = ff131.TenantId,
                           Ff131Id = ff131.Ff131Id,
                           Ff131Filialid = ff131.Ff131Filialid,
                           Ff131Dregistro = ff131.Ff131Dregistro,
                           Ff131Contaid = ff131.Ff131Contaid,
                           Ff131TomadorContaid = ff131.Ff131TomadorContaid,
                           Ff131Usuarioid = ff131.Ff131Usuarioid,
                           Ff131Observacao = ff131.Ff131Observacao,
                           Ff131Isefetivado = ff131.Ff131Isefetivado,
                           Ff131Protocolo = ff131.Ff131Protocolo
                       } : null,

                       NavFF102 = ff102 != null ? new CSICP_FF102
                       {
                           TenantId = ff102.TenantId,
                           Id = ff102.Id,
                           Ff102Tiporegistro = ff102.Ff102Tiporegistro,
                           Ff102Filialid = ff102.Ff102Filialid,
                           Ff102Pfx = ff102.Ff102Pfx,
                           Ff102NoTitulo = ff102.Ff102NoTitulo,
                           Ff102Sfx = ff102.Ff102Sfx,
                           Ff102Contaid = ff102.Ff102Contaid,
                           Ff102Contarealid = ff102.Ff102Contarealid,
                       } : null
                   };
        }

        public async Task ProcessarTomadorDeDivida(int in_tenant, long in_ff131Id)
        {
            // Busca os dados do repositório FF132 com as informações necessárias
            var (listaDados, _) = await GetListAsync(in_tenant, in_ff131Id, 1, int.MaxValue);

            foreach (var item in listaDados)
            {
                // Verifica se existem os dados necessários para o processamento
                if (item.NavFF131 != null && item.NavFF102 != null &&
                    !string.IsNullOrEmpty(item.Ff102Id))
                {
                    // Busca a entidade FF102 para atualização
                    var ff102Entity = await _appDbContext.OsusrE9aCsicpFf102s
                        .FirstOrDefaultAsync(x => x.Id == item.Ff102Id && x.TenantId == in_tenant);

                    if (ff102Entity != null)
                    {
                        // Atualiza os campos conforme especificado
                        ff102Entity.Ff102Contaid = item.NavFF131.Ff131TomadorContaid;
                        ff102Entity.Ff102Contarealid = item.NavFF131.Ff131Contaid;

                        // Salva as alterações no banco de dados
                        await _appDbContext.SaveChangesAsync();
                    }
                }
            }

            // Atualiza o campo FF131_ISEFETIVADO para true no final do processamento
            var ff131Entity = await _appDbContext.OsusrE9aCsicpFf131s
                .FirstOrDefaultAsync(x => x.Ff131Id == in_ff131Id && x.TenantId == in_tenant);

            if (ff131Entity != null)
            {
                ff131Entity.Ff131Isefetivado = true;
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}

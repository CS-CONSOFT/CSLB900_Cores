using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_TT;
using CSCore.Domain.Interfaces.TT.TT0XX;
using CSCore.Ifs.Compartilhado.Utilidade.Excel;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.TT.TT0XX
{
    public class TT030RepositoryImpl(AppDbContext appDbContext, IExcel excel) :
        RepositorioBaseImpl<CSICP_TT030>(appDbContext, "Tt030Id"), ITT030Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IExcel _excel = excel;


        public async Task<CSICP_TT030?> GetByIdAsync(long id, int tenant)
        {
            return await (from tt030 in _appDbContext.OsusrE9aCsicpTt030s
                         where tt030.TenantId == tenant
                         where tt030.Tt030Id == id
                          join bb001 in _appDbContext.E9ACSICP_BB001s
                         on tt030.Tt030Estabid equals bb001.Id into bb001Join
                         from bb001 in bb001Join.DefaultIfEmpty()

                         join Csicp_Sy001 in _appDbContext.OsusrE9aCsicpSy001s
                         on tt030.Tt030Usuariopropid equals Csicp_Sy001.Id into Csicp_Sy001Join
                         from Csicp_Sy001 in Csicp_Sy001Join.DefaultIfEmpty()



                         select new CSICP_TT030
                         {
                             TenantId = tt030.TenantId,
                             Tt030Id = tt030.Tt030Id,
                             Tt030Estabid = tt030.Tt030Estabid,
                             Tt030Protocolonumber = tt030.Tt030Protocolonumber,
                             Tt030Datahora = tt030.Tt030Datahora,
                             Tt030Usuariopropid = tt030.Tt030Usuariopropid,
                             Tt030Usuariovendedorid = tt030.Tt030Usuariovendedorid,
                             Tt030Observacao = tt030.Tt030Observacao,
                             Tt030Protocolnumber = tt030.Tt030Protocolnumber,
                             CSICP_BB001 = bb001 != null ? new CSICP_BB001
                             {
                                 Bb001Nomefantasia = bb001.Bb001Nomefantasia,
                             } : null,
                             Csicp_Sy001 = Csicp_Sy001 != null ? new Domain.Csicp_Sy001
                             {
                                 Sy001Usuario = Csicp_Sy001.Sy001Usuario,
                             } : null,
                         }).FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_TT030>, int)> GetListAsync(int tenant,
            string? in_estabId,
            int? in_protocoloNumber,
            string? in_observacao,
            string? in_usuarioVendedorId,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal,
            int pageSize,
            int page)
        {
            IQueryable<CSICP_TT030> q1 = from tt030 in _appDbContext.OsusrE9aCsicpTt030s
                                         where tt030.TenantId == tenant

                                         join bb001 in _appDbContext.E9ACSICP_BB001s
                                         on tt030.Tt030Estabid equals bb001.Id into bb001Join
                                         from bb001 in bb001Join.DefaultIfEmpty()

                                         join Csicp_Sy001 in _appDbContext.OsusrE9aCsicpSy001s
                                         on tt030.Tt030Usuariopropid equals Csicp_Sy001.Id into Csicp_Sy001Join
                                         from Csicp_Sy001 in Csicp_Sy001Join.DefaultIfEmpty()

                                         select new CSICP_TT030
                                        {
                                            TenantId = tt030.TenantId,
                                            Tt030Id = tt030.Tt030Id,
                                            Tt030Estabid = tt030.Tt030Estabid,
                                            Tt030Protocolonumber = tt030.Tt030Protocolonumber,
                                            Tt030Datahora = tt030.Tt030Datahora,
                                            Tt030Usuariopropid = tt030.Tt030Usuariopropid,
                                            Tt030Usuariovendedorid = tt030.Tt030Usuariovendedorid,
                                            Tt030Observacao = tt030.Tt030Observacao,
                                            Tt030Protocolnumber = tt030.Tt030Protocolnumber,
                                            CSICP_BB001 = bb001 != null ? new CSICP_BB001
                                             {
                                               Bb001Nomefantasia = bb001.Bb001Nomeoficial,
                                             } : null,
                                              Csicp_Sy001 = Csicp_Sy001 != null ? new Domain.Csicp_Sy001
                                              {
                                                Sy001Usuario = Csicp_Sy001.Sy001Usuario,
                                              } : null,
                                        };

            q1 = FiltraDiferenteDeNulo(
                in_estabId, 
                in_protocoloNumber, 
                in_observacao, 
                in_usuarioVendedorId, 
                in_dataInicio, 
                in_dataFinal, 
                q1);
            
            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }

        private static IQueryable<CSICP_TT030> FiltraDiferenteDeNulo(
            string? in_estabId,
            int? in_protocoloNumber,
            string? in_observacao,
            string? in_usuarioVendedorId,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal,
            IQueryable<CSICP_TT030> q1)
        {
            if (in_estabId is not null) q1 = q1
                    .Where(x => x.Tt030Estabid == in_estabId);
            if (in_protocoloNumber is not null) q1 = q1
                    .Where(x => x.Tt030Protocolonumber == in_protocoloNumber);
            if (in_observacao is not null) q1 = q1
                    .Where(x => x.Tt030Observacao == in_observacao);
            if (in_usuarioVendedorId is not null)  q1 = q1
                    .Where(x => x.Tt030Usuariovendedorid == in_usuarioVendedorId);
            if (in_dataInicio is not null && in_dataFinal is not null)
                q1 = q1
                    .Where(x => x.Tt030Datahora >= in_dataInicio && x.Tt030Datahora <= in_dataFinal);
            return q1;
        }


        public async Task<string> ReadExcelTT031(
            int in_tenant, string in_estabID, long in_tt030_id, IFormFile arquivoExcel)
        {
            var result = await _excel
                .CS001_Import_Arquivo_xls(in_tenant, in_estabID, in_tt030_id, arquivoExcel);

            return result;
        }
    }
}

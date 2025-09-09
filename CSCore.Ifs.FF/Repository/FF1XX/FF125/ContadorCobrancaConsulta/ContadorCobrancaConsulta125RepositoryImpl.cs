using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF125.ContadorCobrancaConsulta
{
    public class ContadorCobrancaConsulta125RepositoryImpl : IContadorCobrancaConsulta125Repository
    {
        private readonly AppDbContext _appDbContext;

        public ContadorCobrancaConsulta125RepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<IEnumerable<RepoDtoContadorCobrancaConsulta>> CalcularContadorCobrancaConsulta(string InSY001_ID, int InTenantID)
        {




            int WorkCountAgenteCobrador = await _appDbContext.OsusrE9aCsicpBb006s
               .Where(e => e.Bb006Isactive == true && e.TenantId == InTenantID)
               .CountAsync();

            var WorkFf012UsuarioSuperId = await (from ff012 in _appDbContext.OsusrE9aCsicpFf012s
                                           where ff012.Ff012Usuariosuperid == InSY001_ID
                                           select ff012.Id).FirstOrDefaultAsync();

            int WorkCountZona = await (from bb010 in _appDbContext.OsusrE9aCsicpBb010s

                                       join ff013 in _appDbContext.OsusrE9aCsicpFf013s
                                       on bb010.Id equals ff013.Ff013Zonaid into ff013_joined
                                       from ff013 in ff013_joined.DefaultIfEmpty()

                                     

                                       where bb010.Bb010Isactive == true
                                       where bb010.TenantId == InTenantID
                                       where ff013.Ff013Grupocobrancaid != null && ff013.Ff013Grupocobrancaid == WorkFf012UsuarioSuperId

                                       select bb010)
                                       .AsNoTracking()
                                       .AsSplitQuery()
                                       .CountAsync();

            int WorkCountSitConta = await _appDbContext.OsusrE9aCsicpBb012Sitcta.CountAsync();

            return
            [
                new RepoDtoContadorCobrancaConsulta
                {
                    NomeTabela = "AGENTE_COBRADOR",
                    Contador = WorkCountAgenteCobrador,
                    TenantID = InTenantID
                },
                new RepoDtoContadorCobrancaConsulta
                {
                   NomeTabela = "ZONA",
                    Contador = WorkCountZona,
                    TenantID = InTenantID
                },
                new RepoDtoContadorCobrancaConsulta
                {
                    NomeTabela = "SITUACAO CONTA",
                    Contador = WorkCountSitConta,
                    TenantID = InTenantID
                }
            ];

        }

    }
}

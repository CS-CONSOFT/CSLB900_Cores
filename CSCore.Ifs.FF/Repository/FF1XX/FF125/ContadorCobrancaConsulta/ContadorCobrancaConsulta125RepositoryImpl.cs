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


        public async Task<ListRepoDtoContadorCobrancaConsulta> CalcularContadorCobrancaConsulta(int InTenantID)
        {
            var resultAgCobrador = await ContarPorAgenteCobradorEBanco(InTenantID);

            var resultSitConta = await ContarPorSituacaoConta(InTenantID);

            var resultZona = await ContarPorZona(InTenantID);


            var listaresultAgCobradorProjedada = resultAgCobrador.Select(e => new RepoDtoContadorCobrancaConsulta
            {
                NomeTabela = "AGENTE_COBRADOR",
                Contador = e.Contador,
                TenantID = InTenantID,
                Id = e.AgCobradorId,
                Label = e.Banco
            });


            var listaresultSitContaProjedada = resultSitConta.Select(e => new RepoDtoContadorCobrancaConsulta
            {
                NomeTabela = "SIT_CTA",
                Contador = e.Contador,
                TenantID = InTenantID,
                Id = e.SituacaoID.ToString(),
                Label = e.SituacaoLabel
            });


            var listaresultZonaProjedada = resultZona.Select(e => new RepoDtoContadorCobrancaConsulta
            {
                NomeTabela = "ZONA",
                Contador = e.Contador,
                TenantID = InTenantID,
                Id = e.ZonaID,
                Label = e.Zona
            });

            return new ListRepoDtoContadorCobrancaConsulta
            {
                ListaCountAgCobrador = listaresultAgCobradorProjedada,
                ListaCountSitCta = listaresultSitContaProjedada,
                ListaCountZona = listaresultZonaProjedada
            };
        }



        // Query 2: Contagem por agente cobrador e banco
        public async Task<IEnumerable<(string AgCobradorId, string Banco, int Contador)>> ContarPorAgenteCobradorEBanco(int tenantId)
        {
            return await (from ff125 in _appDbContext.OsusrE9aCsicpFf125s
                          join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                          on ff125.Ff125AgcobradorId equals bb006.Id
                          where ff125.TenantId == tenantId && ff125.Ff125Isactive == true
                          group ff125 by new { ff125.Ff125AgcobradorId, bb006.Bb006Banco } into g
                          orderby g.Key.Bb006Banco
                          select new ValueTuple<string, string, int>(
                              g.Key.Ff125AgcobradorId,
                              g.Key.Bb006Banco,
                              g.Count()
                          )).ToListAsync();
        }

        // Query 3: Contagem por situação da conta
        public async Task<IEnumerable<(int SituacaoID, string SituacaoLabel, int Contador)>> ContarPorSituacaoConta(int tenantId)
        {
            return await (from ff125 in _appDbContext.OsusrE9aCsicpFf125s

                          join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                          on ff125.Ff125ContaId equals bb012.Id

                          join sitCta in _appDbContext.OsusrE9aCsicpBb012Sitcta
                          on bb012.Bb012SitContaId equals (int?)sitCta.Id

                          where ff125.TenantId == tenantId && ff125.Ff125Isactive == true

                          group ff125 by new { sitCta.Id, sitCta.Label } into g

                          orderby g.Key.Id, g.Key.Label
                          select new ValueTuple<int, string, int>(
                              g.Key.Id,
                              g.Key.Label ?? string.Empty,
                              g.Count()
                          )).ToListAsync();
        }

        // Query 4: Contagem por zona
        public async Task<IEnumerable<(string ZonaID, string Zona, int Contador)>> ContarPorZona(int tenantId)
        {
            return await (from ff125 in _appDbContext.OsusrE9aCsicpFf125s
                          join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                          on ff125.Ff125ContaId equals bb012.Id
                          join bb01201 in _appDbContext.OsusrE9aCsicpBb01201s
                          on bb012.Id equals bb01201.Id
                          join bb010 in _appDbContext.OsusrE9aCsicpBb010s
                          on bb01201.Bb012Zonaid equals bb010.Id
                          where ff125.TenantId == tenantId && ff125.Ff125Isactive == true
                          group ff125 by new { bb010.Id, bb010.Bb010Zona } into g
                          orderby g.Key.Id, g.Key.Bb010Zona
                          select new ValueTuple<string, string, int>(
                              g.Key.Id,
                              g.Key.Bb010Zona ?? string.Empty,
                              g.Count()
                          )).ToListAsync();
        }
    }
}
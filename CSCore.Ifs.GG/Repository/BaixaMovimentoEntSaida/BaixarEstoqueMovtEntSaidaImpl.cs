using CSCore.Application.Dto;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.Baixa;
using CSCore.RabbitMQ;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace CSCore.Ifs.GG.Repository.BaixaMovimentoEntSaida
{
    public class BaixarEstoqueMovtEntSaidaImpl(AppDbContext appDbContext, IBus bus) : IBaixarEstoqueMovtEntSaida
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IBus _bus = bus;
        public async Task CS001_Baixa_Movto_ENTSAI(ParametrosBaixaSaldo parametrosBaixaEstoque, int tenant)
        {
            //se tiver fechado nao faz nada pra baixo, gg073Stat so pode ser aberto ou erro

            IQueryable<CSICP_GG074> queryGG074 = GeraQueryGG074(parametrosBaixaEstoque.GG073_ID);

            List<CSICP_GG074> listaGG074_Produtos_Movimento = await queryGG074.ToListAsync();

            Rbt_CS_BaixaMvto_EntSaida dtoRabbitMensagem = new()
            {
                ListaGG074 = listaGG074_Produtos_Movimento,
                ParametrosBaixaSaldo = parametrosBaixaEstoque,
                Tenant_ID = tenant
            };

            string? urlParaRoutingKey = Environment.GetEnvironmentVariable("API_URL") ?? "http://localhost:9607";
            var routingKey = RoutingKeys.GetRoutingKey(urlParaRoutingKey, RoutingKeys.MovimentoEntradaSaida);

            Log.Debug("RabbitMQ - Enviando movimento entrada saída para Routing Key: " + routingKey);

            await _bus.Publish(dtoRabbitMensagem, ctx =>
            {
                ctx.SetRoutingKey(routingKey);
            });
        }

        private IQueryable<CSICP_GG074> GeraQueryGG074(string GG073_ID)
        {
            return from _GG074 in _appDbContext.OsusrE9aCsicpGg074s
                   where _GG074.Gg073Id == GG073_ID

                   join _GG072Stq in _appDbContext.OsusrE9aCsicpGg072Stqs
                   on _GG074.Gg074Statusestqid equals _GG072Stq.Id into _GG072_join
                   from _GG072Stq in _GG072_join.DefaultIfEmpty()

                       //1 = aberto || 4 = erro || 5 = inventario || 6 = sem saldo
                   where _GG072Stq.Codgcs == 1 || _GG072Stq.Codgcs == 4 || _GG072Stq.Codgcs == 5 || _GG072Stq.Codgcs == 6

                   join _gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                   on _GG074.Gg074KardexId equals _gg008Kdx.Gg008Kardexid into join_gg074_gg008kdx
                   from _gg008Kdx in join_gg074_gg008kdx.DefaultIfEmpty()

                   select new CSICP_GG074
                   {
                       TenantId = _GG074.TenantId,
                       Gg074Id = _GG074.Gg074Id,
                       Gg073Id = _GG074.Gg073Id,
                       Gg074Codbarrasalfa = _GG074.Gg074Codbarrasalfa,
                       Gg074KardexId = _GG074.Gg074KardexId,
                       Gg074Saldoid = _GG074.Gg074Saldoid,
                       Gg074UnId = _GG074.Gg074UnId,
                       Gg074Qtd = _GG074.Gg074Qtd,
                       Gg074Vunitario = _GG074.Gg074Vunitario,
                       Gg074Statusestqid = _GG074.Gg074Statusestqid,
                       Gg074Tmovid = _GG074.Gg074Tmovid,
                       Gg074Tproduto = _GG074.Gg074Tproduto,
                       NavGG008Kdx = _gg008Kdx != null ? new CSICP_GG008Kdx
                       {
                           TenantId = _gg008Kdx.TenantId,
                           Gg008Kardexid = _gg008Kdx.Gg008Kardexid,
                           Gg008Permsldnegativo = _gg008Kdx.Gg008Permsldnegativo
                       } : null
                   };
        }
    }
}


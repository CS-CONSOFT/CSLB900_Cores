using CSCore.Domain.Interfaces.GG._03X;
using CSCore.RabbitMQ.PublishObjetos;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.EstaticasLabel.GG.Entities;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtGerarInventarioEmMassa(IGG032Repository gG032Repository) : IConsumer<Rbt_CS_GerarInventarioEmMassa>
    {
        private readonly IGG032Repository _GG032Repository = gG032Repository;
        public async Task Consume(ConsumeContext<Rbt_CS_GerarInventarioEmMassa> context)
        {
            string result = await _GG032Repository
                 .CS_GeradorInventarioEmMassa(
                context.Message.in_tenantId,
                context.Message.idgg001_talmox_virtual,
                context.Message.isQtdZero,
                context.Message.request);
        }
    }
}

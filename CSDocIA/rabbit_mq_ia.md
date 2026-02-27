# Padrão Corporativo para Criação e Consumo de Processos Assíncronos com RabbitMQ

## Sumário

- Introdução
- Objetivo
- Visão Arquitetural
- Fluxo do Processo
- Padrão Estrutural
  - 1. Definição do DTO de Mensagem
  - 2. Producer (Envio de Mensagem)
  - 3. Consumer (Consumo de Mensagem)
  - 4. Configuração do RabbitMQ
- Exemplos de Código por Responsabilidade
  - Producer
  - Consumer
  - Configuração
- Diagrama Descritivo do Fluxo
- Checklist de Validação
- Requisitos Técnicos

---

## Introdução

Este documento define o padrão corporativo para implementação de processos assíncronos utilizando RabbitMQ na arquitetura da empresa. O objetivo é garantir uniformidade, rastreabilidade, robustez e facilidade de manutenção em todos os fluxos que envolvem mensageria assíncrona.

## Objetivo

Estabelecer diretrizes técnicas e estruturais para criação de Producers e Consumers, configuração de filas, tratamento de logs, notificações e integração com demais sistemas, assegurando que todos os novos processos sigam um padrão único e validado.

## Visão Arquitetural

A arquitetura de mensageria é composta por três principais responsabilidades:

- **Producer:** Responsável por enviar mensagens para uma exchange RabbitMQ, utilizando DTOs padronizados.
- **Consumer:** Responsável por consumir mensagens da fila, processar a lógica de negócio, notificar sistemas externos e registrar logs.
- **Configuração:** Centraliza o registro de exchanges, filas, bindings e consumers, garantindo isolamento e rastreabilidade por domínio/processo.

A comunicação é desacoplada, resiliente e auditável, permitindo escalabilidade horizontal e integração com múltiplos sistemas.

## Fluxo do Processo

1. **Producer** constrói o DTO da mensagem e envia para a exchange RabbitMQ, utilizando a routing key apropriada.
2. **RabbitMQ** roteia a mensagem para a fila configurada.
3. **Consumer** recebe a mensagem da fila, executa a lógica de negócio e registra logs de processamento.
4. **Consumer** notifica sistemas externos (ex: SignalR) sobre o sucesso ou falha do processamento.
5. **Consumer** registra logs detalhados em serviço centralizado.
6. **Respostas** e notificações são disponibilizadas para acompanhamento em tempo real.

## Padrão Estrutural

### 1. Definição do DTO de Mensagem

Todos os processos devem definir um DTO específico para a mensagem, contendo os campos necessários para o processamento.

```csharp
public class Rbt_CS_PRXXX_ProcessoExemplo : IConsumerUsuarioId, ITenantId
{
    public int InTenantID { get; set; }
    public string UsuarioID { get; set; }
    // ... outros campos relevantes
}
```

### 2. Producer (Envio de Mensagem)

O envio de mensagens deve ser realizado por uma classe de serviço que utilize o provider do MassTransit, encapsulando a lógica de roteamento e logging.

```csharp
public interface ISendMsgToRabbit
{
    Task SendMessageV2<T>(T message, string exchangeName, string action);
}

public class SendMsgToRabbit : ISendMsgToRabbit
{
    private readonly ISendEndpointProvider _sendEndpointProvider;

    public async Task SendMessageV2<T>(T message, string exchangeName, string action)
    {
        // ... validações e logging
        var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri($"exchange:{exchangeName}?type=direct"));
        await endpoint.Send(message, ctx => ctx.SetRoutingKey(routingKey));
    }
}
```

### 3. Consumer (Consumo de Mensagem)

O consumer deve herdar de uma classe base padronizada, responsável por logging, notificação e registro de logs centralizados.

```csharp
public abstract class BaseConsumerV3<T> : IConsumer<T> where T : class, IConsumerUsuarioId, ITenantId
{
    // ... injeção de dependências e HttpClient

    public virtual Task Consume(ConsumeContext<T> context)
    {
        LogMessage(context);
        return Task.CompletedTask;
    }

    protected async Task NotificarSucessoProcessamento(ConsumeContext<T> context, string message, ...)
    {
        // ... notificação via SignalR e registro de log
    }

    protected async Task NotificarFalhaProcessamento(ConsumeContext<T> context, string message, ...)
    {
        // ... notificação via SignalR e registro de log
    }
}
```

O consumer específico implementa a lógica de negócio e utiliza os métodos de notificação e logging da base.

```csharp
public class EvtXXX_ProcessoExemplo : BaseConsumerV3<Rbt_CS_PRXXX_ProcessoExemplo>
{
    public override async Task Consume(ConsumeContext<Rbt_CS_PRXXX_ProcessoExemplo> context)
    {
        await base.Consume(context);
        try
        {
            // ... lógica de negócio
            await NotificarSucessoProcessamento(context, "Processo realizado com sucesso!", ...);
        }
        catch (Exception ex)
        {
            await NotificarFalhaProcessamento(context, "Falha ao processar: " + ex.Message, ...);
            throw;
        }
    }
}
```

### 4. Configuração do RabbitMQ

A configuração centraliza o registro de consumers, exchanges, filas e bindings, utilizando métodos padronizados.

```csharp
public static class ConfigureRabbitMQ
{
    public static IServiceCollection ConfigureRabbit(this IServiceCollection services)
    {
        services.AddMassTransit(configurator =>
        {
            configurator.AddConsumer<EvtXXX_ProcessoExemplo>();
            configurator.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(new Uri(rabbitHost), h =>
                {
                    h.Username(rabbitUsername);
                    h.Password(rabbitPassword);
                });

                cfg.CSConfigure<EvtXXX_ProcessoExemplo>(
                    context,
                    RoutingKeys.FilaProcessoExemplo,
                    RoutingKeys.ExchangeProcessoExemplo,
                    RoutingKeys.ActionProcessoExemplo
                );
            });
        });
        return services;
    }
}
```

## Exemplos de Código por Responsabilidade

### Producer

```csharp
var rbtPrm = new Rbt_CS_PRXXX_ProcessoExemplo
{
    InTenantID = tenantId,
    UsuarioID = usuarioId,
    // ... outros campos
};

await _service.SendMessageV2(
    rbtPrm,
    RoutingKeys.ExchangeProcessoExemplo,
    RoutingKeys.ActionProcessoExemplo
);
```

### Consumer

```csharp
public class EvtXXX_ProcessoExemplo : BaseConsumerV3<Rbt_CS_PRXXX_ProcessoExemplo>
{
    public override async Task Consume(ConsumeContext<Rbt_CS_PRXXX_ProcessoExemplo> context)
    {
        await base.Consume(context);
        try
        {
            // ... lógica de negócio
            await NotificarSucessoProcessamento(context, "Processo realizado com sucesso!", ...);
        }
        catch (Exception ex)
        {
            await NotificarFalhaProcessamento(context, "Falha ao processar: " + ex.Message, ...);
            throw;
        }
    }
}
```

### Configuração

```csharp
cfg.CSConfigure<EvtXXX_ProcessoExemplo>(
    context,
    RoutingKeys.FilaProcessoExemplo,
    RoutingKeys.ExchangeProcessoExemplo,
    RoutingKeys.ActionProcessoExemplo
);
```

## Diagrama Descritivo do Fluxo

1. **Producer** constrói e envia mensagem → **Exchange** (RabbitMQ)
2. **Exchange** roteia mensagem → **Fila**
3. **Consumer** consome mensagem da fila
4. **Consumer** executa lógica de negócio
5. **Consumer** notifica sistemas externos (ex: SignalR)
6. **Consumer** registra logs centralizados
7. **Resposta** e status disponíveis para acompanhamento

## Checklist de Validação

- [ ] DTO de mensagem criado e implementa interfaces obrigatórias (`IConsumerUsuarioId`, `ITenantId`)
- [ ] Producer utiliza serviço padronizado para envio de mensagens
- [ ] Consumer herda de `BaseConsumerV3<T>` e implementa lógica de negócio
- [ ] Métodos de notificação e logging utilizados conforme padrão
- [ ] Configuração do RabbitMQ realizada via método centralizado
- [ ] Routing keys, exchanges e filas nomeadas conforme convenção
- [ ] Logs de envio e consumo registrados
- [ ] Notificações de sucesso/falha implementadas
- [ ] Testes de envio e consumo realizados

## Requisitos Técnicos

- Utilizar MassTransit para integração com RabbitMQ
- Definir DTOs específicos para cada processo
- Implementar interfaces de identificação de usuário e tenant
- Utilizar métodos padronizados para logging e notificação
- Centralizar configuração de consumers, exchanges e filas
- Garantir rastreabilidade e auditabilidade de todas as operações
- Seguir convenções de nomenclatura para routing keys, exchanges e filas
- Implementar tratamento de exceções e logs detalhados
- Utilizar injeção de dependências para todos os serviços

---

Este padrão deve ser seguido integralmente para a criação de novos processos assíncronos utilizando RabbitMQ, garantindo padronização, rastreabilidade e robustez em toda a arquitetura corporativa.
Padrão Corporativo para Implementação de Operações CRUD
## Sumário

- 1. Introdução
- 2. Objetivo
- 3. Visão Arquitetural
- 4. Estrutura em Camadas
  - 4.1. Camada de Apresentação (API)
  - 4.2. Camada de Aplicação (Application)
  - 4.3. Camada de Domínio (Domain)
  - 4.4. Camada de Infraestrutura (Infrastructure)
- 5. Fluxo de Execução das Operações CRUD
  - 5.1. Create
  - 5.2. Read (GetById/GetAll)
  - 5.3. Update
  - 5.4. Delete
- 6. Padrão Estrutural Baseado nas Classes Fornecidas
- 7. Exemplos de Código por Responsabilidade
  - 7.1. Controller (API)
  - 7.2. Service (Application)
  - 7.3. Repository (Domain/Infrastructure)
- 8. Contratos de Entrada e Saída (Request/Response)
- 9. Tratamento de Erros e Validações
- 10. Padrão de Mapeamento entre Entidades e DTOs
- 11. Diagrama Descritivo do Fluxo da Requisição
- 12. Checklist Final de Validação

---

## 1. Introdução

Este documento define o padrão oficial e obrigatório para implementação de operações CRUD (Create, Read, Update, Delete) dentro da arquitetura corporativa. O objetivo é garantir padronização, coesão arquitetural, separação de responsabilidades, escalabilidade e manutenibilidade em todos os desenvolvimentos.

## 2. Objetivo

Estabelecer um guia técnico e reutilizável para implementação de CRUD, permitindo que qualquer desenvolvedor realize a entrega de um CRUD completo e aderente à arquitetura, apenas seguindo este documento.

## 3. Visão Arquitetural

A implementação de CRUD deve seguir uma arquitetura em camadas, promovendo a separação de responsabilidades e facilitando a manutenção e evolução do sistema. As camadas são: Apresentação (API), Aplicação (Application), Domínio (Domain) e Infraestrutura (Infrastructure).

## 4. Estrutura em Camadas

### 4.1. Camada de Apresentação (API)

Responsável por expor endpoints RESTful, receber requisições, validar dados de entrada e retornar respostas padronizadas.

### 4.2. Camada de Aplicação (Application)

Contém a lógica de orquestração das operações, validações de negócio e mapeamento entre DTOs e entidades de domínio.

### 4.3. Camada de Domínio (Domain)

Define as entidades, regras de negócio e interfaces de repositório.

### 4.4. Camada de Infraestrutura (Infrastructure)

Implementa o acesso a dados, persistência e integrações externas.

---

## 5. Fluxo de Execução das Operações CRUD

### 5.1. Create

- **Responsabilidade:** Criar um novo registro da entidade.
- **Fluxo:**
  1. Controller recebe o DTO de criação.
  2. Validações de entrada são aplicadas.
  3. Service executa regras de negócio e chama o repositório.
  4. Repositório persiste a entidade.
  5. Service retorna resposta padronizada ao Controller.

### 5.2. Read (GetById/GetAll)

- **Responsabilidade:** Consultar registros, individualmente ou em lista, com ou sem filtros/paginação.
- **Fluxo:**
  1. Controller recebe parâmetros de consulta.
  2. Service executa regras de negócio e chama o repositório.
  3. Repositório retorna entidades.
  4. Service mapeia entidades para DTOs de resposta.
  5. Controller retorna resposta padronizada.

### 5.3. Update

- **Responsabilidade:** Atualizar um registro existente.
- **Fluxo:**
  1. Controller recebe o ID e DTO de atualização.
  2. Validações de entrada são aplicadas.
  3. Service executa regras de negócio e chama o repositório.
  4. Repositório atualiza a entidade.
  5. Service retorna resposta padronizada ao Controller.

### 5.4. Delete

- **Responsabilidade:** Remover um registro existente.
- **Fluxo:**
  1. Controller recebe o ID do registro.
  2. Service executa regras de negócio e chama o repositório.
  3. Repositório remove a entidade.
  4. Service retorna resposta padronizada ao Controller.

---

## 6. Padrão Estrutural Baseado nas Classes Fornecidas

A estrutura padrão para qualquer CRUD deve ser baseada nas seguintes classes e interfaces:

- **Controller:** Exemplo: `XXXXController`
- **Service:** Exemplo: `XXXXService`, `ServiceBaseV3`
- **Repository:** Interface: `IRepositorioBaseV2ComGets<TEntity>`
- **UnitOfWork:** Interface: `IUnitOfWorkBase` / `IABAC_UnitOfWork`
- **DTOs:** Exemplo: `Dto_CreateSy040`, `Dto_GetSy040`, `Dto_UpdateSy040`
- **Response Wrapper:** Exemplo: `DtoApiResponse<T>`

---

## 7. Exemplos de Código por Responsabilidade

### 7.1. Controller (API)

```csharp
[ApiController]
[Route("/api/v1/entity/")]
public class EntityController : ControllerBase
{
    private readonly EntityService _service;

    public EntityController(EntityService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<DtoApiResponse<string>>> Create(Dto_CreateEntity dto)
    {
        await _service.Create(dto, tenant: Constantes.ENTIDADE_SEM_TENANT);
        return Ok(new DtoApiResponse<string> { Success = true, Message = "Criado com sucesso" });
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DtoApiResponse<Dto_GetEntity>>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id, tenant: Constantes.ENTIDADE_SEM_TENANT);
        if (result == null)
            return NotFound(new DtoApiResponse<Dto_GetEntity> { Success = false, Message = "Não encontrado" });
        return Ok(new DtoApiResponse<Dto_GetEntity> { Success = true, Data = result });
    }

    [HttpGet]
    public async Task<ActionResult<DtoApiResponse<PaginationModel<Dto_GetListEntity>>>> GetAll([FromQuery] ParametrosBaseFiltroSemExcederOMaxPageSize prm)
    {
        var result = await _service.GetAllAsyncComPaginacao([], prm.PageNumber, prm.PageSize);
        return Ok(new DtoApiResponse<PaginationModel<Dto_GetListEntity>> { Success = true, Data = result });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<DtoApiResponse<Dto_UpdateEntity>>> Update(string id, Dto_UpdateEntity dto)
    {
        var result = await _service.UpdateAsync(id, tenant: Constantes.ENTIDADE_SEM_TENANT, dto);
        if (result == null)
            return NotFound(new DtoApiResponse<Dto_UpdateEntity> { Success = false, Message = "Não encontrado" });
        return Ok(new DtoApiResponse<Dto_UpdateEntity> { Success = true, Data = result });
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<DtoApiResponse<object?>>> Delete(string id)
    {
        await _service.RemoveAsync(id, tenant: Constantes.ENTIDADE_SEM_TENANT);
        return NoContent();
    }
}
```

### 7.2. Service (Application)

```csharp
public class EntityService : ServiceBaseV3<Entity, Dto_GetListEntity, Dto_GetEntity, Dto_CreateEntity, Dto_UpdateEntity, IUnitOfWork>
{
    public EntityService(IUnitOfWork unitOfWork) : base(unitOfWork) { }

    protected override IRepositorioBaseV2ComGets<Entity> GetRepository()
    {
        return UnitOfWork.GetEntityRepository;
    }

    protected override ICS_GenerateId GetIdGenerator()
    {
        return UnitOfWork.IdGenerator;
    }
}
```

### 7.3. Repository (Domain/Infrastructure)

```csharp
public interface IRepositorioBaseV2ComGets<TEntity> : IRepositorioBaseV2<TEntity>
    where TEntity : class
{
    Task<TEntity?> GetByIdAsync(string id, int tenant);
    Task<IEnumerable<TEntity>> GetAllAsync(IEnumerable<FiltrosDinamicos> filtros);
    Task<(IEnumerable<TEntity> Data, int TotalCount)> GetAllAsyncComPaginacao(IEnumerable<FiltrosDinamicos> filtros, int pageNumber, int pageSize);
    // ... outros métodos padrão
}
```

---

## 8. Contratos de Entrada e Saída (Request/Response)

- **Request DTOs:** Devem conter apenas os campos necessários para a operação.
- **Response DTOs:** Devem ser utilizados para retorno de dados, nunca expondo entidades diretamente.
- **Response Wrapper:** Utilize sempre um wrapper padronizado, como `DtoApiResponse<T>`, contendo propriedades como `Success`, `Message` e `Data`.

---

## 9. Tratamento de Erros e Validações

- Todas as validações de entrada devem ser realizadas na camada de apresentação e/ou aplicação.
- Mensagens de erro devem ser padronizadas e nunca expor detalhes internos.
- Utilize respostas HTTP adequadas (`400`, `404`, `200`, `201`, `204`).
- Em caso de erro de negócio, retorne sempre o wrapper de resposta com `Success = false` e mensagem apropriada.

---

## 10. Padrão de Mapeamento entre Entidades e DTOs

- Utilize métodos de extensão ou interfaces como `IConverteParaDTO<TEntity, TDto>` e `IConverteParaEntidade<TEntity>` para mapear entre entidades e DTOs.
- O mapeamento deve ser centralizado e nunca realizado diretamente no Controller.

---

## 11. Diagrama Descritivo do Fluxo da Requisição

```
[Cliente] 
   ↓
[Controller (API)]
   ↓
[Service (Application)]
   ↓
[Repository (Domain/Infrastructure)]
   ↓
[Database]
   ↑
[Repository]
   ↑
[Service]
   ↑
[Controller]
   ↑
[Cliente]
```

---

## 12. Checklist Final de Validação

- [ ] Endpoints implementados conforme padrão
- [ ] Utilização de DTOs para entrada e saída
- [ ] Respostas padronizadas com `DtoApiResponse<T>`
- [ ] Validações de entrada e negócio aplicadas
- [ ] Separação clara entre camadas
- [ ] Mapeamento entre entidades e DTOs implementado
- [ ] Tratamento de erros padronizado
- [ ] Operações de persistência delegadas ao repositório
- [ ] UnitOfWork utilizado para controle transacional
- [ ] Código revisado e aderente ao padrão

---

**Este documento deve ser seguido integralmente para qualquer novo desenvolvimento de CRUD, garantindo a padronização e qualidade exigidas pela empresa.**
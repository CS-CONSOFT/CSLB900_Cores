# CSModel-900_iCorp

## Modelo para scaffolding
```
dotnet ef dbcontext scaffold "STRING DE CONEXAO" Microsoft.EntityFrameworkCore.SqlServer -o PASTA_DESTINO -t TABELAS DESEJADAS -t TODAS COLOCANDO A FLAG "-t" NA FRENTE --context DEFINE O NOME DO CONTEXTO
```

## Para salvar a variavel de ambiente na maquina
No prompt de comando do Windows ou Linux use

### Linux
```
export CONNECTION_STRING="Server=myServer;Database=myDB;User Id=myUser;Password=myPassword;"
```
### Windows

```
set CONNECTION_STRING=Server=myServer;Database=myDB;User Id=myUser;Password=myPassword;
```

Então roda o scaffold, isso ajuda a lidar com a string de conexão na hora da configuração

### Após fazer o scaffold
Ao fazer o scaffolding, um novo contexto será gerado, as mudanças devem se adequar ao contexto atual!

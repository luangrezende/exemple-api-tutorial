# API REST com .NET Core 3.0 e Entity Framework Core

[![.NET Core](https://img.shields.io/badge/.NET%20Core-3.0-blue)](https://dotnet.microsoft.com/download/dotnet/3.0)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-3.0-green)](https://docs.microsoft.com/ef/core/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Medium Article](https://img.shields.io/badge/Tutorial-Medium-brightgreen)](https://medium.com/@luangrezende/como-criar-uma-api-rest-com-net-core-3-0-e-entity-framework-core-em-15-minutos-cc36e7ca6f2b)

Este projeto é um exemplo de API criada para o tutorial do Medium: [Como criar uma API REST com .NET Core 3.0 e Entity Framework Core em 15 minutos](https://medium.com/@luangrezende/como-criar-uma-api-rest-com-net-core-3-0-e-entity-framework-core-em-15-minutos-cc36e7ca6f2b)

## Requisitos
- .NET Core 3.0 SDK ou superior
- SQL Server
- Visual Studio ou VS Code
- Postman (para testes)
- SQL Server Management Studio

## Principais pacotes NuGet
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
- Microsoft.AspNetCore.Mvc.Formatters.Json

## Como rodar o projeto
1. Clone o repositório:
   ```sh
   git clone https://github.com/luangrezende/exemple-api-tutorial.git
   ```
2. Restaure os pacotes:
   ```sh
   dotnet restore
   ```
3. Configure a connection string em `appsettings.json` para seu SQL Server.
4. Execute as migrações:
   ```sh
   dotnet ef database update
   ```
5. Rode a aplicação:
   ```sh
   dotnet run
   ```

## Testando a API
Utilize o Postman para enviar requisições para os endpoints, por exemplo:
- GET: `https://localhost:{porta}/api/usuarios`
- POST: `https://localhost:{porta}/api/usuarios`
  ```json
  {
    "Nome": "Luan Gomes"
  }
  ```

## Estrutura do projeto
- `Controllers/` - Controllers da API
- `Models/` - Modelos que representam as tabelas do banco
- `Migrations/` - Migrações do Entity Framework
- `dbContextApi.cs` - DbContext principal
- `Startup.cs` e `Program.cs` - Configuração da aplicação

## Links úteis
- [Artigo no Medium](https://medium.com/@luangrezende/como-criar-uma-api-rest-com-net-core-3-0-e-entity-framework-core-em-15-minutos-cc36e7ca6f2b)
- [Projeto no GitHub](https://github.com/luangrezende/exemple-api-tutorial)

---
Tutorial por [Luan Gomes](https://medium.com/@luangrezende)

# :motorcycle: Projeto de API REST - Motos e Usuários

Esta é uma API desenvolvida com ASP.NET Core que permite realizar operações CRUD (Create, Read, Update, Delete) para os recursos **Moto** e **Usuário**.

A aplicação possui validações customizadas para garantir a integridade dos dados. Utiliza **Entity Framework Core** para persistência em banco de dados relacional, com mapeamento das entidades para as tabelas:

- `TB_MTT_VEICULO` (motos)
- `TB_MTT_USUARIO` (usuários)

---

## :pushpin: Rotas Disponíveis

### :closed_lock_with_key: USUÁRIO
- `GET /api/usuario`  
  Lista todos os usuários.
- `GET /api/usuario/{id}`  
  Retorna um usuário pelo ID.
- `POST /api/usuario`  
  Cria um novo usuário.
- `PUT /api/usuario/{id}`  
  Atualiza um usuário existente.
- `DELETE /api/usuario/{id}`  
  Remove um usuário.

### :motorcycle: MOTO
- `GET /api/moto`  
  Lista todas as motos.
- `GET /api/moto/{id}`  
  Retorna uma moto pelo ID.
- `POST /api/moto`  
  Cadastra uma nova moto.
- `PUT /api/moto/{id}`  
  Atualiza uma moto existente.
- `DELETE /api/moto/{id}`  
  Remove uma moto pelo ID.
- `GET /api/moto/marca/{marca}`  
  Filtra motos por marca (busca parcial).
- `GET /api/moto/anoMaiorQue/{ano}`  
  Filtra motos com ano maior que o valor informado.
- `GET /api/moto/filtro/{marca}/{anoMinimo}`  
  Filtra motos pela marca e ano mínimo.

---

## :tools: Instalação dos Pacotes NuGet

Para que o projeto funcione corretamente, instale os seguintes pacotes NuGet no terminal do seu projeto:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add package Swashbuckle.AspNetCore



